// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

    IEnumerable<string>  foundFiles = FindFiles("stores");
    foreach (string folder in foundFiles)
    {
        Console.WriteLine (folder);
    }



 IEnumerable<string> FindFiles (string FolderName) {

    var foundFiles= System.IO.Directory.GetDirectories(FolderName);
    return foundFiles;
 
}
