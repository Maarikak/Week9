
//string fileDirectoryPath = @"C:\data";
//string fileName = "chuck.txt";

//string fullFilePath = Path.Combine(fileDirectoryPath, fileName);

//if (File.Exists(fullFilePath))
//{
//    Console.WriteLine($"File {fileName} exists in {fileDirectoryPath}");
//    string [] chuckJokes = File.ReadAllLines(fullFilePath);
//    Console.WriteLine($"There are {chuckJokes.Length} jokes about Chuck Norris in the file.");

//    foreach(string joke in chuckJokes)
//    {
//        Console.WriteLine(joke);
//    }
//}
//else
//{
//    Console.WriteLine($"File {fileName} was not found.");
//}


using System.Xml.Serialization;

string fileDirectoryPath = @"C:\data";
string fileName = "chuck.txt";

string fullFilePath = Path.Combine(fileDirectoryPath, fileName);

readfromfile(fullFilePath);



static void displayDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

static void readfromfile(string filePath)
{
    if (File.Exists(filePath))
    {
        string[] tempArray = File.ReadAllLines(filePath);
        Console.WriteLine($"There are {tempArray.Length} lines in the file.");
        Console.Write("Do You want to see all lines or pick a random one? all/random");
        string userChoice = Console.ReadLine();

        if (userChoice == "all")
        {
            displayDataFromArray(tempArray);
        }
        else if (userChoice == "random")
        {
            displayrandomelement(tempArray);
        }

        else
        {
            Console.WriteLine("Try again.");
        }

    }
    else
    {
        Console.WriteLine($"File was not found.");
    }
}
static void displayrandomelement(string[] someArray)
{
    Random rnd = new Random();
    int randomindex = rnd.Next(0, someArray.Length);
    Console.WriteLine(someArray[randomindex]);
}


