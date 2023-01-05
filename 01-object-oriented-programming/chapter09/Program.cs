using chapter09;
using System;
namespace _chapter_09
{

    struct jobInfo
    {
        public string name;
        public int ID;
        public double salary;

    };
    class Program
    {
        static void Main(string[] args)
        {

            jobInfo job = new jobInfo();

            job.name = "xev";
            job.ID = 1001;
            job.salary = 65000;

            Console.WriteLine(job.name);
            Console.WriteLine(job.ID);
            Console.WriteLine(job.salary);

            //Student studentInfo = new Student();

            //studentInfo.name = "talha";
            //studentInfo.cGPA = 3.15;
            //studentInfo.age = 19;

            //Student studentInfo1 = studentInfo;

            //studentInfo1.name = "mahmud";
            //studentInfo1.cGPA = 3.50;
            //studentInfo1.age = 18;

            //Console.WriteLine(studentInfo.name);
            //Console.WriteLine(studentInfo.cGPA);
            //Console.WriteLine(studentInfo.age);
            //Console.WriteLine("-----------");
            //Console.WriteLine(studentInfo1.name);
            //Console.WriteLine(studentInfo1.cGPA);
            //Console.WriteLine(studentInfo1.age);

            Student s1 = new Student();
            s1.name = "raisa";
            s1.cGPA = 4.00;
            s1.age = 20;

            Console.WriteLine("Before: " + s1.name + " " +
                                s1.cGPA + " " + s1.age);

            changeStudentInfo(s1);

            Console.WriteLine("After: " + s1.name + " " +
                                s1.cGPA + " " + s1.age);
        }

        public static void changeStudentInfo(Student s1)
        {
            s1.name = "mim";
            s1.cGPA = 3.99;
            s1.age = 21;
        }
    }
}