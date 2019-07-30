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