using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humanity
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                var studentData = Console.ReadLine().Split();
                var werkerData = Console.ReadLine().Split();

                try
                {
                    var student = new Student(studentData[0], studentData[1], (Gender)Enum.Parse(typeof(Gender), studentData[2]), studentData[3]);
                    var worker = new Worker(werkerData[0], werkerData[1], (Gender)Enum.Parse(typeof(Gender), werkerData[2]), decimal.Parse(werkerData[3]), double.Parse(werkerData[4]));
                   
                    Console.WriteLine(student);
                    Console.WriteLine(worker);
                    Console.WriteLine("Workers: " + Worker.Counter);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }

                if (Worker.Counter == 3)
                {
                    break;
                }

                
            }
            
        }
    }
}
