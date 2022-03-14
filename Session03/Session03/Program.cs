using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.IO;

namespace Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Student s;
            string fileName = "student_s.json";
            string jsonStr = File.ReadAllText(fileName);
            s = JsonSerializer.Deserialize<Student>(jsonStr);


            //Student s = new Student();
            //int age = Convert.ToInt32(Console.ReadLine());
            //string name = Console.ReadLine();   
            //int regNumber = Convert.ToInt32(Console.ReadLine());
            //s.Age = age;
            //s.Name = name;  
            //s.RegistrationNumber = regNumber;

            //string jsonStr = JsonSerializer.Serialize(s);
            //string fileName = "student_s.json";
            //File.WriteAllText(fileName, jsonStr);
        }
    }
}
