using System;
using System.IO;

public class Class1
{
	public Class1()
	{
        //test code 
        string folderName = string.Empty;
        int i = 1;
        string fileName = "file" + i + ".json";
        folderName = @"C:/ZoomFiles";
        if (!Directory.Exists(folderName))
        {
            Directory.CreateDirectory(folderName);
        }

        using (var writer = new StreamWriter($@"{folderName}\{fileName}", false))
        {
            writer.WriteLine("Test function to check azure functions");
        }
        //till here
    }
}
