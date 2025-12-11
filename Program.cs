// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");

int coderreur;
coderreur =findFiles("stores"); 

 int findFiles (string FolderName) {

    var foundFiles= System.IO.Directory.GetDirectories(FolderName);

    foreach (string folder in foundFiles)
    {
        Console.WriteLine (folder);
    }

    return 0;
 
}
