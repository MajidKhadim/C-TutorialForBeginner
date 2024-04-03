using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_TutorialForBeginner.Part40
{
    internal class Class40
    {
        public static void MainFunction()
        {
            StreamReader streamReader = null; 
            try 
            {
                streamReader = new StreamReader(@"C:\Users\PMLS\\Desktop\C#TutorialForBeginner\C#TutorialForBeginner\Part40\data.txt");
                Console.WriteLine(streamReader.ReadToEnd());
                streamReader.Close();
            } catch (Exception ex) 
            { 
                Console.WriteLine($"Error : {ex.Message}");
            }

            finally
            {
                if(streamReader != null)
                streamReader.Close();
            }
            
        }
    }
}
