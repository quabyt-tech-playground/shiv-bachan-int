// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
List<string> names = new List<string> {"raju","rahul","abhishek","shiv"};

string firstName = names.FirstOrDefault(x => x.FirstOrDefault(x.Replace("shiv","bachan")));

Console.WriteLine(firstName); // Output: 2
