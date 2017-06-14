// Problem: We need a simple way to look at a user's badge count and JavaScript points
// Solution: Use Node.js to connect to Treehouse's API to get profile information to print out
const https = require('https'),
	printMessage = (username, badgeCount, points) => {
		const message = `${username} has ${badgeCount} total badge(s) and ${points} in JavaScript`;
		console.log(message);
};

// function printMessage(username, badgeCount, points) {
// 	const message = `${username} has ${badgeCount} total badge(s) and ${points} in JavaScript`;
// 	console.log(message);
// }

const getProfile = (username) => {
	// Connect to the API URL (https://teamtreehouse.com/user.json)
	try {
		const request = https.get(`https://teamtreehouse.com/${username}.json`, response => {
			let body = "";
			// Read
			response.on('data', data => {
				body += data.toString();
			});
			response.on('end', () => {
				// Parse
				const profile = JSON.parse(body);
				// Print
				printMessage(username, profile.badges.length, profile.points.JavaScript);
			});
		});
		request.on('error', error => {
			console.error(`Problem with request: ${error.message}`);
		});
	} catch (error) {
		console.error(error.message);
	};
};

const [,, ...users] = process.argv;
// const users = process.argv.slice(2);
users.forEach(getProfile);