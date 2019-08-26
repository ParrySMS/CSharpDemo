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

