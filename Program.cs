using System;
using System.IO;

namespace Manip.Arq
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\aff-o\source\repos\Manip.Arq\Msg.txt";
            /*
             * sem o @ o caminho do arquivo tem que ficar \\ 
             * <string sourcePath = "C:\\Users\aff-o\\source\\repos\\Manip.Arq";
             */

            string targetPath = @"C:\Users\aff-o\source\repos\Manip.Arq\Msg0.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                //estanciar um objeto por onde o arquivo for passar

                fileInfo.CopyTo(targetPath);
                //para copiar o original para outro arquivo

                string[] lines = File.ReadAllLines(sourcePath);
                //ira ler todos as linhas do arquivo e guardar em um vetor
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
                //todas as linhas do arquivo será mostrado na tela

            }

            catch (IOException e)
            {
                Console.WriteLine("Error");
                Console.WriteLine(e.Message);
                //Ao existir o arquivo exibir uma mensagem de erro.

            }


        }
    }
}
//fonte de dados: https://docs.microsoft.com/pt-br/dotnet/api/system.io.fileinfo.copyto?view=netframework-4.8