using System;

namespace day05
{
    class Program
    {
        static void Main(string[] args)
        {
            

            employees[] empArr = new employees[3];
            HiringDate[] H = new HiringDate[3];
            for (int i = 0; i < empArr.Length; i++)
            {
                empArr[i] = new employees();
                H[i]= new HiringDate();




            }

            Console.WriteLine("please enter the data of the employees ");
            for (int i = 0; i < empArr.Length; i++)
            {



                Console.WriteLine("please enter id of employee no:" + i);
                empArr[i].ID = int.Parse(Console.ReadLine());

                Console.WriteLine("please enter the securitylevel of employee no:" + i);
                empArr[i].SecurityLevel = int.Parse(Console.ReadLine());


                Console.WriteLine("please enter the salary of employee no:" + i);
                empArr[i].Salary = int.Parse(Console.ReadLine());


                Console.WriteLine("please enter the hiring date (as d/m/y) of employee no:" + i);
                H[i].Day = int.Parse(Console.ReadLine());
                H[i].Month = int.Parse(Console.ReadLine());
                H[i].Year = int.Parse(Console.ReadLine());
                empArr[i].HireDate = H[i];

                Console.WriteLine("please enter the Gender of employee no:" + i);
                empArr[i].Gender = (GENDER)Enum.Parse(typeof(GENDER), Console.ReadLine());
               





            }

            Array.Sort(empArr);


            foreach (employees element in empArr)
            {
                Console.WriteLine(element.ToString());
            }

        }
    }
}
