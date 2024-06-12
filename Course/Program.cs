using System;
using System.IO;

namespace Course
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sourcepath = @"c:\temp\file1.txt";
            string targetpath = @"c:\temp\file2.txt";

            try
            {
                //Ler todo conteudo e guardar no vetor de arquivos
                string[] lines = File.ReadAllLines(sourcepath);

                //Transformar tudo em letra maiscula
                using (StreamWriter sw = File.AppendText(targetpath))
                {
                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
