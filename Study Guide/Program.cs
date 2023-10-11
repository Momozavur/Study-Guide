
string path = @"D:\\programming guyyys";

DirectoryInfo directoryInfo = new DirectoryInfo(path);

//create directory - > folder ( do you type it in path?)
directoryInfo.Create();


//check if exists
if (!directoryInfo.Exists)
{
    Console.WriteLine("Directory doesn't exist,");
    
}

else
{
    Console.WriteLine("Directory exists!");

}
// copy file 

var initial = $@"{path}\Initial.txt";

var final = $@"{path}\Final.txt";

string hello = "hello guys";

File.WriteAllText(initial, hello);
File.Copy(initial, final);
//note: need to delete the created files to copy them after you run it ones

//move to another file 
var initial1 = $@"{path}\Initial1.txt";

var final2 = $@"{path}\Final2.txt";

string hihi = "hihi friend";

File.WriteAllText(initial1, hihi);
File.Move(initial1, final2);


//create file
var file = $"{path}/file.txt";


// add some stuff 
Console.WriteLine("Tell me your first name!");
string firstName = Console.ReadLine(); 

Console.WriteLine("Tell me your age!");
string age = Console.ReadLine();


string[] info = {firstName, age};

//writes it in file
File.WriteAllLines(file, info);

//goes through stuff in file and prints it onto the console 
foreach (string item in File.ReadAllLines(file))
{
    Console.WriteLine($"Data is:{item}");

    //checks for blank spaces?
    if (item.Contains(' '))
            {
        Console.WriteLine("not funny");
        Environment.Exit(0);
    }
}





