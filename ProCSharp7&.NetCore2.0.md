# Notes for Professional C# 7 and .NET Core 2.0

- Code samples for the book Professional C# 7 and .NET Core 2.0：[https://github.com/ProfessionalCSharp/ProfessionalCSharp7](https://github.com/ProfessionalCSharp/ProfessionalCSharp7) 

## 对象和类型

- readonly ：使其只能在构造函数中赋值
- const ：编译器常量，用值替代变量
- static：常驻内存
- namespace 的别名使用   `using Doc = Editor.Doc.Basics;`
- 一个readonly的样例 [DocEditor.cs](https://github.com/ParrySMS/CSharpDemo/blob/master/DocEditor.cs) , [注意 static 的约束]

```C#
using System;
using Doc = Editor.Doc.Basics;
public class Program
{
    static void Main()
    {
        Doc::DocEditor docEd = new Doc::DocEditor();
        Doc::ExcelEditor excEd = new Doc::ExcelEditor();
    }
}

namespace Editor.Doc.Basics
{
    public class DocEditor
    {
        static readonly uint s_maxDocNum;
        static DocEditor()
        {
            s_maxDocNum = 5;
            Console.WriteLine("Max Num:" + s_maxDocNum);
        }
    }

    public class ExcelEditor
    {
        private readonly DateTime _created;
        public ExcelEditor()
        {
            _created = DateTime.Now;
            Console.WriteLine("Created:" + _created);
        }
    }
}
```

- 属性 property : 一个方法或一对方法
	- 私有成员字段可以建立属性来进行 `get`, `set`
	- get 访问器无参，必须返回对应类型
	- set 访问器无显式参数，编译器假定带一个`=`赋值的参数 `value`
	- 属性访问器： 
		- `{执行}`
		- `=>表达式`
		- `自动 get; set; + 初始化`
	- 自动属性将会由编译器产生一个字段，所以无法直接知道此字段名
	- 属性访问器可加访问修饰符
	- 属性中省略 set ，即可产生只读属性. (可配合`readonly`)
	- 只读属性可以在构造函数中显式的初始化
	- 语法糖：表达式体属性，替代`{ return xxx}`
	- 改善`string.Format`使用的`$`格式化可以不用再写占位符
	- 不可变类型：对象中只有只读成员
	- 一个 property 的样例 [PropertyGetSet.cs](https://github.com/ParrySMS/CSharpDemo/blob/master/PropertyGetSet.cs) , [注意 static 的约束]

```C#
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
```


