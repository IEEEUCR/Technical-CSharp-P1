using Newtonsoft.Json;
using System.Collections;
using System;


//This is a Main Method that uses top-level statements
//This means you don't have to create a main class with a main method - it's all done for you!
//Just put your business logic here

//You can't compile a C# file by itself - you need to create a Project file
//The project file manages build info such as output type and target framework

//Install .NET 6.0 SDK and Runtime
//this will give you a command called dotnet

//Steps to create this project:

//mkdir dict								
//dotnet new console					
//dotnet add package Newtonsoft.Json	
//dotnet build							
//dotnet run							

//Repeat ad nauseam
//dotnet build; dotnet run;

//Create a dictionary
Dictionary<string, string> dict = new();
if(File.Exists("dict.json")) {
	//Use Newtonsoft.Json to load dictionary
	dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText("dict.json"));
	
	//Let's print all keys that match a certain prefix
	Console.WriteLine("Prefix: ");
	var prefix = Console.ReadLine();
	
	dict.PrintKeys(prefix);
}
while(true) {
	//Ask for key and value
	(var key, var val) = RequestEntry();
	
	//Add to the dictionary
	dict[key] = val;
	//
	File.WriteAllText("dict.json", JsonConvert.SerializeObject(dict));
	Console.WriteLine("Saved!");
}
//Inner method! Only exists in this scope
//This method returns a *tuple* of string and string
(string, string) RequestEntry() {
	
	Console.WriteLine("Key: ");
	var key = Console.ReadLine();
	
	Console.WriteLine("Value: ");
	var val = Console.ReadLine();
	return (key, val)
}
/*
Console.WriteLine("Truth machine!");

bool active = true;
while(active) {
	var input = Console.ReadLine();
	if(input == "1") {
		Console.WriteLine("Yes");
	} else if(input == "0") {
		Console.WriteLine("Bye");
		active = false;
	}
}
*/