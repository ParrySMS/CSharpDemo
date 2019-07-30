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
            
            bool flag = true;
            Console.WriteLine(flag);//输出 True
            
            Console.WriteLine();//换行

        }
    }
}

```

- 数组:  数组经过初始化以后，数组元素有默认的初始值

double 类型为 0.0 ， int 类型为 0 ， char 类型为 'a' ， bool 类型为 false ， string 类型为 null 

``` C#
string[] names = new string[3]; 
int len = names.Length; //长度为属性

char[] ch = {'A','B','C'};
char[] ch = new char[]{'A','B','C'}; //有具体内容可以不指示长度
char[] ch = new char[3]{'A','B','C'}; //等价
```

- 二维数组
```C#
int[,] arr = new int[2,3]; //元素索引从[0,0]到[1,2]
int len0 = arr.GetLength(0); //第0维长度=2
int len1 = arr.GetLength(1);
arr[0,0] = 100; //索引之间用逗号


- foreach 遍历
```

```C#
int[] num = {3,34,42,2,11,19,30,55,20};

foreach(int x in num){
//foreach(类型 变量 in 数组名){
  Console.Write(x+" ");
}
```

  