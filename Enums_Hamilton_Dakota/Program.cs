using System;
using System.IO;
/// <summary>
/// 
/// CREATS A NEW FILE OR REPLACES IT IF THE FILE ALREADY EXISTS
/// 
/// </summary>
namespace Enums_Hamilton_Dakota
{
    enum Months
    {
        Jan = 1,
        Feb,
        Mar,
        Apr,
        May,
        Jun,
        Jul,
        Aug,
        Sep,
        Oct,
        Nov,
        Dec
    }

    class Program
    {
        static void Main(string[] args)
        {
            int myBirthMonth = (int)Months.Feb;
            int myBirthDay = 11;
            int myBirthYear = 2002;
            string myBirthDate = $"My birthday is on {myBirthMonth}/{myBirthDay}/{myBirthYear}.";

            File.WriteAllText("myFile.txt", "Dakota's Birthday");
            Console.WriteLine(File.ReadAllText("myFile.txt"));
            
            File.AppendAllText("myFile.txt", "\n");
            Console.WriteLine(File.ReadAllText("myFile.txt"));

            if (File.Exists("myFile.txt"))
            {
                File.Copy("myFile.txt", "newFile.txt");
            }
            else
            {
                File.Replace("newFile.txt", "myFile.txt", "backupFile.txt");
            }

            File.AppendAllText("newFile.text", myBirthDate);
            Console.WriteLine(File.ReadAllText("newFile.txt"));
        }
        
    }
}
