// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Collections.Generic;


Console.WriteLine("Hello, World!");

IEnumerable<string>  foundFiles = FindFiles("stores");
foreach (string folder in foundFiles)
{
    Console.WriteLine (folder);
}

 IEnumerable<string> FindFiles (string folderName)
 {
    var foundFiles = System.IO.Directory.EnumerateFiles(folderName);
    return foundFiles;
 }
