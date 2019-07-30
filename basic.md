- 编译命令

`mcs demo.cs `

`./demo.exe `


- Console code
```C#
using System;
namespace MyApp1 //命名空间也要有{}
{
   public class Pro
    {//C#最小单元 有系统提供的类
        public static void Main(string[] args)
        { //Main方法 程序入口
            const string HW = "Hello World";
            char sex = '男';
            Console.WriteLine(HW + "333" + sex); //+连接 自带结束换行

        }
    }
}

```


