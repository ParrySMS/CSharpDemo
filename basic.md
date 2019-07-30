
- 编译命令

linux（安装mono）: `mcs demo.cs `
win :  `csc demo.cs`
`./demo.exe `


- Console code
```C#
using System; // 在任何 C# 程序中的第一条语句都是 using System;
namespace MyApp1 //命名空间也要有{}
{
   public class Pro 
    {//有系统提供的类 文件名可以不同于类的名称
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

- 值数据类型（Value types）

  值类型变量可以直接分配给一个值。它们是**从类 System.ValueType 中派生的**。
  
| 类型	|举例|
| ----|----|
|整数类型|	sbyte、byte、short、ushort、int、uint、long、ulong 和 char|
|浮点型|	float 和 double|
|十进制类型	|decimal|
|布尔类型|	true 或 false 值，指定的值|
|空类型	|可为空值的数据类型|

------------------------------

| 类型 | 描述 | 范围 | 默认值|
| ---- | ---- | ---- |:----:|
|byte	|8 位无符号整数|0 到 255|0|
|sbyte	|8 位有符号整数类型|-128 到 127|	0|
|decimal	|128 位精确的十进制值，28-29 有效位数|(-7.9 x 1028 到 7.9 x 1028)/100 到 28|0.0M|
|short	|16 位有符号整数类型|	-32,768 到 32,767|	0|



- 类型转化
```c#
double d = 2345.7652;
Console.WriteLine(d.ToString()); //变量.ToXXXX() 

```

-  引用类型（Reference types）

内置的 引用类型有：**object、dynamic 和 string **
用户自定义引用类型有：**class、interface 或 delegate**
```C#
//所有数据类型的终极基类 可以被分配任何其他类型
object obj = 100; // 这是装箱

//类型检查是在运行时发生
dynamic data = 20.214;

//String 类型是 System.String 类的别名。它是从对象（Object）类型派生的。
// 字符串 String 类型的值可以通过两种形式进行分配：引号和 @引号。

string str = "C:\\Windows";//转义
string str = @"C:\Windows"; //等价转义

//@ 字符串中可以任意换行，换行符及缩进空格都计算在字符串长度之内。
string str = @"<script type=""text/javascript"">
    <!--
    -->
</script>";
```

- 可空类型（Nullable）：给赋值域增加一个 `null`, 声明加多一个`?`即可
```C#
int? num1 = null;
int? num2 = 45;
double? num3 = new double?();
double? num4 = 3.14157;
```
- Null 合并运算符（ ?? ） :  `非空条件返回原本值？？空条件返回值`
```C#
double? num1 = null;
double? data;
data = num1 ?? 5.34;
//if num1 null : data <-- 5.34
// else:  data <--num1
```


-  数组:  声明一个数组不会在内存中初始化数组。数组经过初始化以后，数组元素才有默认的初始值

double 类型为 0.0 ， int 类型为 0 ， char 类型为 'a' ， bool 类型为 false ， string 类型为 null 

``` C#
string[] names = new string[3]; 
int len = names.Length; //长度为属性

char[] ch = {'A','B','C'};
char[] ch = new char[]{'A','B','C'}; //有具体内容可以不指示长度
char[] ch = new char[3]{'A','B','C'}; //等价
```

- 多维数组 : 整个定义的全部向量空间值，
```C#
int[,] arr = new int[2,3]; //元素索引从[0,0]到[1,2]
int len0 = arr.GetLength(0); //第0维长度=2
int len1 = arr.GetLength(1);
arr[0,0] = 100; //索引之间用逗号

int[, ,] muarr = new int[2, 2, 3]//元素索引从[0,0,0] 到[1,1,2]
{
  {{1,2,3},{4,5,6}},
  {{7,8,9},{2,3,4}}  
};
```

- 交错数组:  数组的数组，逐层的一维指向。
```C#

int[][] a = new int[3][]; 
// 声明一个交错数组 a, a 中有三个元素，分别是 a[0],a[1],a[2] 
// 每个元素都是一个数组

//以下是声明交错数组的每一个元素数组，每个数组的长度可以不同
a[0] = new int[] { 1,2,3 };
a[1] = new int[] { 4,5,6,7,8 };
a[2] = new int[] { 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
```

- `foreach` 遍历

```C#
int[] num = {3,34,42,2,11,19,30,55,20};

foreach(int x in num){
//foreach(类型 变量 in 数组名){
  Console.Write(x+" ");
}
```

- 字符串
```C#
 //通过使用 string 构造函数 传入字符数组
char[] letters = { 'H', 'e', 'l', 'l','o' };
string greetings = new string(letters);

//合并字符串数组
string[] sarray = { "Hello", "From", "Tutorials", "Point" };
string message = String.Join("--", sarray);
//message: Hello--From--Tutorials--Point

//日期格式
DateTime dt = new DateTime(2017,4,1,13,16,32,108);
dt.ToString("yyyy/MM/dd HH:mm:ss.fff");　//2017/04/01 13:16:32.108
dt.ToString("yyyy/MM/dd dddd");　　　　　　//2017/04/01 星期六
```
- 结构体
  - 值类型，存储在栈中。描述一个轻量级对象的时候，结构可提高效率。
  - 可带有方法、字段、索引、属性、运算符方法和事件。
  - 可定义**有参数的构造函数**，但默认无参构造函数是自动定义的，且不能被改变。
  - 可实现一个或多个接口
  - 声明无法直接赋初值
  - 直接实例化，使用 **New** 创建则会自动赋值默认值，不用 **New** 则需要自行初始化全部字段才能被使用。
  - 不支持继承
  - 成员不能指定为 abstract、virtual 或 protected
```C#
struct Books
{
   private string title;
   private string author;
   private string subject;
   private int book_id;
   public void getValues(string t, string a, string s, int id)
   {
      title = t;
      author = a;
      subject = s;
      book_id =id; 
   }
};


```
- 类
```C#
using System;
namespace RectangleApplication 
{
    class Rectangle
    {
        // 成员变量
        double length;
        double width;
        public void Acceptdetails()
        {
            length = 4.5;    
            width = 3.5;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", width);
            Console.WriteLine("Area: {0}", GetArea());
        }
    }
    
    class ExecuteRectangle
    {
        static void Main(string[] args)   //Main方法是在类里的
        {
            Rectangle r = new Rectangle(); //实例化对象 new 类名()
            r.Acceptdetails();
            r.Display();
            Console.ReadLine();
        }
    }
}
```


- 访问修饰符: (默认private)

  - public：所有对象都可以访问；
  - private：对象本身在对象内部可以访问；
  - protected：只有该类对象及其子类对象可以访问
  - **internal**：同一个程序集的对象可以访问；（允许一个类将其成员变量和成员函数暴露给当前程序中的其他函数和对象，暴露给调用者）
  - **protected internal**：访问限于当前程序集或派生自包含类的类型。

  

- 引用传递参数

```C#
  public void swap(ref int x, ref int y){...}
  //表示使用引用传入，引用传递必须是初始化的变量，才能指向有效地址。
```

 - 输出传递参数
```C#
  public void swap(out int x, out int y){...}
  //表示使用引用传出，用于从参数没有指定初始值的方法中返回一些值
```

- 引用传递与输出传递的应用举例

```C#
using System;
namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void getValues1(out int x, out int y)
        {
            Console.WriteLine("getValues1 请输入第一个值： ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("getValues1 请输入第二个值： ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public void getValues2(ref int x, ref int y)
        {
            Console.WriteLine("getValues2 请输入第一个值： ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("getValues2 请输入第二个值： ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            /* 局部变量定义 */
            int a, b;
            int c=0, d=0;

            /* 调用函数来获取值 */
            n.getValues1(out a, out b);
            Console.WriteLine("在方法调用之后，a 的值： {0}", a);
            Console.WriteLine("在方法调用之后，b 的值： {0}", b);
           
			//引用传递必须要是已经赋值的内容
            n.getValues2(ref c, ref d);
            /** 否则会报错
             * CalcuApp.cs(36,30): error CS0165: 使用了未赋值的局部变量“c”
             * CalcuApp.cs(36,37): error CS0165: 使用了未赋值的局部变量“d”
             **/
            Console.WriteLine("在方法调用之后，c 的值： {0}", c);
            Console.WriteLine("在方法调用之后，d 的值： {0}", d);
            Console.ReadLine();
        }
    }
}
```

