using System;
using System.Linq;
using System.Text;

namespace P03.ExtractFiles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //String is immutable, cannot be changed directly
            //They must be overwritten
            //We have functions for removing range, replacing characters, taking a
            //substring and so on
            //When we want fast concatenation we use StringBuilder!!!
            //String is reference type which has the behaviour of a value type
            string filePath = Console.ReadLine();

            //Backslash is special character for escpaing
            //Escape escaping character?
            string fileInfo = filePath.Substring(filePath.LastIndexOf('\\') + 1);

            //gotinVirus.pdf.exe
            int dotIndex = fileInfo.LastIndexOf('.');
            string fileName = fileInfo.Substring(0, dotIndex);
            string fileExtension = fileInfo.Substring(dotIndex + 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");

            //Array solution
            //string[] fileInfo = filePath
            //    .Split('\\')
            //    .Last()
            //    .Split('.')
            //    .ToArray();
            //string fileName = String.Join(".", fileInfo.Take(fileInfo.Length - 1));
            //string fileExtension = fileInfo.Last();
            ////string fileName = fileInfo[0];
            ////string fileExtension = fileInfo[1];

            //Console.WriteLine($"File name: {fileName}");
            //Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}
