// See https://aka.ms/new-console-template for more information
// System.Collections namespace needed to use Console class
using System.Collections;

// Creates a dictionary called topGames that takes int as the key and string as the value
Dictionary<int, string> topGames = new Dictionary<int, string>();

// Adds Undertale to placement 1
topGames.Add(1, "Undertale");
// Adds Skyrim to placement 2
topGames.Add(2,"Skyrim");
// Adds Minecraft to placement 3
topGames.Add(3,"Minecraft");
// Adds Sly Cooper to placement 4
topGames.Add(4,"Sly Cooper");
// Adds Kingdom Hearts to placement 5
topGames.Add(5,"Kingdom Hearts");
// Adds Borderlands 3 to placement 6
topGames.Add(6,"Borderlands 3");
// Adds 60 Seconds to placement 7
topGames.Add(7,"60 Seconds");
// Adds Pokemon Sword and Shield to placement 8
topGames.Add(8,"Pokemon Sword and Shield");
// Adds Pokemon Scarlet and Violet to placement 9
topGames.Add(9,"Pokemon Scarlet and Violet");
// Adds Hades to placement 10
topGames.Add(10,"Hades");

// Creates a foreach loop that loops through topGames and prints the key/value pairs to the console
foreach (KeyValuePair<int, string> kvp in topGames)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

// Creates an if statement that prints to the console the game in placement 1 as my favorite game if topGames contains key 1
if (topGames.ContainsKey(1))
{
    Console.WriteLine($"My favorite game is {topGames[1]}.");
}

// Creates an empty string called result
string result = "";

// Uses the TryGetValue method for key 11 in topGames and sets the output to result
topGames.TryGetValue(11, out result);

// Creates an if else statements that prints the result to the console if result outputs something
// Else is prints to the console that there is no game in the eleventh position
if(result != "")
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("There is no game in the eleventh position.");
}

// Creates an if statement that will switch the object in key 5 with another game title if topGames contains key 5
if (topGames.ContainsKey(5))
{
    topGames[5] = "Super Marior Bros";
}

// Prints to console the new value at key 5
Console.WriteLine(topGames[5]);

// Creates a new Hashtable called hashTable that is set equal to topGames
Hashtable hashTable = new Hashtable(topGames);

// Creates a string called favGame that is set to value of key 1
string favGame = (string)hashTable[1];

// Prints favGame to console
Console.WriteLine($"Favorite Game: {favGame}");

// Creates a hashtable called capitals
// Initializes it with states as keys and capitals as values
Hashtable capitals = new Hashtable()
{
    {"Oklahoma", "Oklahoma City"},
    {"New York", "Albany"},
    {"Texas", "Austin" },
    {"Ohio", "Columbus" }
};

// Creates a foreach loop to loop through capitals and prints to the console the keys and values of each pair
foreach (DictionaryEntry kvp in capitals)
{
    Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
}

// Clears all elements in the capitals hashtable
capitals.Clear();