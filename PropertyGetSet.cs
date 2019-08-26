using System;
using Stu;
public class Program
{
    static void Main()
    {
        Student stu = new Student("SZU","computer_science", "computer_science");
        stu.Age = -23;
        stu.Name = "ParrySMS";

        Console.WriteLine(stu.Name);
        Console.WriteLine(stu.Age);
        Console.WriteLine(stu.University);
        Console.WriteLine(stu.College);
        Console.WriteLine(stu.Major);
    }
}
namespace Stu
{
    public class Student
    {
        protected string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //// use specific expression 
        protected string major;
        public string Major
        {
            get => major;
            protected set => major = value;
        }

        //// auto getter and setter if no logical process
        public string University { public get; protected set; } = "MIT";

        //// add logic in setter
        protected int age;
        public int Age
        {
            get;
            set
            {
                age = (value > 0 || !string.Empty) ? value : 0;
            }
        }
        //// auto read only
        private readonly string StuID { get; } = Guid.NewGuid().ToString();

        //// manual read only, set value in class
        protected string college;
        public string College
        {
            get;
        }

        //// => and $
        public string UniStuID => $"{University}{StuID}";

        //// set read-only property in __construct
        public Student(string stuCollege) => College = stuCollege;

        public Student(string university, string college, string major)
        {
            University = university;
            College = college;
            Major = major;
        }

    }
}
