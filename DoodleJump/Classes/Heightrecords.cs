using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Cryptography;
using System.IO.Compression;

namespace DoodleJump.Classes
{
    public class Heightrecords
    {     
        public Heightrecords(int score)
        {
            path = @"C:\Users\madma\Desktop\DoodleJump-c-sharp-master_master\DoodleJump\Records";
            AddtoKatalog(path , score);
        }
        public Heightrecords()
        {
            path = @"C:\Users\madma\Desktop\DoodleJump-c-sharp-master_master\DoodleJump\Records";
            
        }
        string path = @"C:\Users\madma\Desktop\DoodleJump-c-sharp-master_master\DoodleJump\Records";
        
        public void AddtoKatalog(string path , int score)
        {            
                using (StreamWriter writer = new StreamWriter($@"{path}\note.txt" , true))
                {
                    writer.Write(score + " ");
                    writer.Close();
                }                       
        }
        public void AddnewPlayer()
        {
            string path = @"C:\Users\madma\Desktop\DoodleJump-c-sharp-master_master\DoodleJump\Records\note.txt";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (FileStream fs = File.Create(path)) { }
           
        }


        public int[] ReadKatalog()
        {

            StreamReader fstream = new StreamReader($@"C:\Users\madma\Desktop\DoodleJump-c-sharp-master_master\DoodleJump\Records\note.txt");
            int counter = 0;
            string line;
            int[] task = new int[1000];

            while ((line = fstream.ReadLine()) != null && counter <= 1000)
            {
                
                string[] numbers = new string[1000];
                int numCount = 0;
                int i = 0;

                while (i < line.Length)
                {

                    if (line[i] != ' ')
                    {
                        numbers[numCount] = "";
                        while (line[i] != ' ')
                        {

                            numbers[numCount] += line[i];
                            i++;
                            if (i >= line.Length) break;
                        }
                        numCount++;
                    }
                    i++;
                }
                for (int ui = 0; ui < 1000; ui++)
                {
                    task[ui] = Convert.ToInt32(numbers[ui]);
                }
                counter++;               
            }
            fstream.Close();
            Array.Sort(task);
            Array.Reverse(task);
            return task;
        }
    }
}

