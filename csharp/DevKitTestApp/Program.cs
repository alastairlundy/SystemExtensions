// See https://aka.ms/new-console-template for more information

using System;
using System.Collections;
using AluminiumTech.DevKit.DeveloperKit;

Console.WriteLine("Hello, World!");
    
HashMap<string, string> hashMap = new();

Hashtable table = new();

table["binger"] = "dumb";

hashMap.ImportHashtable(table);

Console.WriteLine();