const http = require('http'),
	https = require('https'),
	api = require('./api.json'),
	// weatherAPI = `api.openweathermap.org/data/2.5/weather?q=${location}${F}${api.key}`,
	//Print out message on search
	printWeather = (weather) => {
		const message = `Current temperature in ${weather.location.city} is ${weather.current_observation.temp_f}F`;
		console.log(message);
	},
	//Print out Error if invalid
	printError = (error) => {
		console.error(error.message);
	};

	const get = (query) => {
    // Take out underscores for readability
    const readableQuery = query.replace('_', ' ');
    try {
        const request = https.get(`https://api.wunderground.com/api/${api.key}/geolookup/conditions/q/${query}.json`, response => {
            if (response.statusCode === 200) {
                let body = "";
                // Read the data
                response.on('data', chunk => {
                    body += chunk;
                });
                response.on('end', () => {
                    try {
                        // Parse the data
                        const weather = JSON.parse(body);
                        // Check if the location was found before printing
                        if (weather.location) {
                            // Print the data
                            printWeather(weather);
                        } else {
                            const queryError = new Error(`The location "${readableQuery}" was not found.`);
                            printError(queryError);
                        }
                    } catch (error) {
                        // Parse Error
                        printError(error);
                    }
                });
            } else {
                // Status Code Error
                const statusCodeError = new Error(`There was an error getting the message for ${readableQuery}. (${http.STATUS_CODES[response.statusCode]})`);
                printError(statusCodeError);
            }

        });

        request.on("error", printError);
    } catch (error) {
        //Malformed URL Error
        printError(error);
    }
}

	// const get = (location) => {
	// 	const request = https.get(`weatherAPI`, response => {
	// 		let body = "";
	// 		//Read Data
	// 		response.on('data', chunk => {
	// 			body += chunk;
	// 		})
	// 		response.on('end', () => {
	// 			console.log(body);
	// 			//Parse Data
	// 			//Printe Data
	// 		})
			
	// // 	});
	// // }

	module.exports.get = get;