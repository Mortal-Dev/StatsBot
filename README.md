# StatsBot
# DOCUMENTATION

**Program.cs**
bot is initialized and set to run asyncrounously infinitely

**Bot.cs**
opens the config.json file and deserialises the data into a ConfigJson object, and the credentials/prefix are used to connect the bot to the discord API

**IAPIRequest**
used to organize api requests into a dictionary in the stats command in /Commands/Stats

**/API**
all the APIs that implement the IAPIRequest interface that interact with their respected APIs

**/JsonObjects**
classes that the APIs deserialize into once they recieve their json response

**/Commands**
all the commands that the bot can perform, stats command has a dictionary that stores a string as the key so a user can access a game's stats, and an IAPIRequest as its value, 
which stores the respected classes that implement IAPIrequest from the **/API** namespace
