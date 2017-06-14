const https = require('https'),
 	http = require('http'),
	printError = (error) => {
		console.error(error.message);
	},
	printMessage = (username, badgeCount, points) => {
		const message = `${username} has ${badgeCount} total badge(s) and ${points} in JavaScript`;
		console.log(message);
};

// function printMessage(username, badgeCount, points) {
// 	const message = `${username} has ${badgeCount} total badge(s) and ${points} in JavaScript`;
// 	console.log(message);
// }

const get = (username) => {
	// Connect to the API URL (https://teamtreehouse.com/user.json)
	try {
		const request = https.get(`https://teamtreehouse.com/${username}.json`, response => {
			if (response.statusCode === 200) {
				let body = "";
				// Read
				response.on('data', data => {
					body += data.toString();
				});
				response.on('end', () => {
					try {
						// Parse
						const profile = JSON.parse(body);
						// Print
						printMessage(username, profile.badges.length, profile.points.JavaScript);
					} catch (error) {
						printError(error);
					};
				});
			} else {
				const message = `There was an error getting the profile for ${username} (${http.STATUS_CODES[response.statusCode]}) Please try again`;
				const statusCodeError = new Error(message);
				printError(statusCodeError);
			}
			request.on('error', error => {
				console.error(`Problem with request: ${error.message} , Please recheck URL`);
			});
		});
	} catch (error) {
		printError(error);
	};
};

module.exports.get = get;