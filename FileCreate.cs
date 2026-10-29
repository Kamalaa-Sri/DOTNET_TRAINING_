using System;
using System.IO;
class FileCreate
{
    static void Main(string[] args)
    {
        string path = "C:\\Users\\kamalaa\\OneDrive\\Documents\\Desktop\\Csharp\\myFile.txt";
        File.Create(path).Close();
        Console.WriteLine("File created successfully!");
        File.WriteAllText(path, "Kamalaa sri");
        string content = File.ReadAllText(path);
        Console.WriteLine("File content: " + content);
        string folderPath = Directory.GetCurrentDirectory();
        string filePath = Path.Combine(folderPath, "myFile.txt");
        Console.WriteLine("Current folder: " + folderPath);
        Console.WriteLine("Sample file path: " + filePath);
    }
}
