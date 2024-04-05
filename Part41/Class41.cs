using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part41
{
    internal class Class41
    {
        public static void MainFunction()
        {
            try {
                try
                {
                    Console.WriteLine("Enter first nuber : ");
                    int FN = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter second nuber : ");
                    int SN = Convert.ToInt32(Console.ReadLine());

                    int result = FN / SN;
                    Console.WriteLine($"result {result}");
                }
                catch (Exception ex)
                {
                    string filePath = @"C:\Users\PMLS\Desktop\C#TutorialForBeginner\C#TutorialForBeginner\Part41\helloWor.txt";
                    if (File.Exists(filePath))
                    {
                        StreamWriter streamWriter = new StreamWriter(filePath);
                        streamWriter.Write(ex.GetType().Name);
                        streamWriter.Close();
                        Console.WriteLine("There is a problem ");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath+ " does not exist",ex);
                    }
                }
            }
            catch(Exception exp)
            {
                Console.WriteLine("Current Exception : "+ exp.Message);
                Console.WriteLine("Inner exception : " + exp.InnerException);
            }
            }
    }
}
