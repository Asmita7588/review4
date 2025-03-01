using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace review4Week
{
    internal class FileOperations
    {
        //Read and Write to a File: Write a program to read from and write to a text file.
        //Read a JSON File and Parse Data: Read a JSON file, parse the content, and display it.

        public static void WriteToFile()
        {
            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\review4Week\review4Week\Student.txt";
            //File.Create(path);
            var studentData = new List<Student>
            {
             new Student{ Id = 101, Name = "Asmita", City = "khat" },
             new Student{ Id = 102, Name = "puja", City = "shirpur" },
             new Student{ Id = 103, Name = "Rishikesh", City = "bhusaval"}
            };

            using (StreamWriter streamWriter = new StreamWriter(path))
            {

                foreach (Student student in studentData)
                {
                    streamWriter.WriteLine($"Id = {student.Id}, name = {student.Name}, city= {student.City}");
                }
            }

        }

        public static void ReadFromFile()
        {

            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\review4Week\review4Week\Student.txt";

            string[] lines;
            lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }

        public static void WriteToJsonFile()
        {
            Console.WriteLine("Writting to the flie");

            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\review4Week\review4Week\StudentJson.json";

            var studentData = new List<Student>
            {
             new Student{ Id = 101, Name = "Asmita", City = "khat" },
             new Student{ Id = 102, Name = "puja", City = "shirpur" },
             new Student{ Id = 103, Name = "Rishikesh", City = "bhusaval"}
            };

            string jsonData = JsonConvert.SerializeObject(studentData, Formatting.Indented);
            File.WriteAllText(path, jsonData);


            Console.WriteLine("File written successfully.");
        }






        public static void ReadFromJsonFile()
        {
            string path = @"C:\Users\asmita1\source\repos\Bridgelabz_practice_program\review4Week\review4Week\StudentJson.json";
            string jsonRead = File.ReadAllText(path);
            
            var deserializedData = JsonConvert.DeserializeObject<List<Student>>(jsonRead);

            foreach (var student in deserializedData)
            {
                Console.WriteLine($"StudentID ={student.Id}, StudentNamr = {student.Name}, StudentCity = {student.City}");
            }
        }
    }
}
