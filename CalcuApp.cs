using System;

namespace CalculatorApplication
{
    class NumberManipulator
    {
        public void getValues1(out int x, out int y)
        {
            Console.WriteLine("getValues1 �������һ��ֵ�� ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("getValues1 ������ڶ���ֵ�� ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        public void getValues2(ref int x, ref int y)
        {
            Console.WriteLine("getValues2 �������һ��ֵ�� ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("getValues2 ������ڶ���ֵ�� ");
            y = Convert.ToInt32(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            NumberManipulator n = new NumberManipulator();
            /* �ֲ��������� */
            int a, b;
            int c=0, d=0;

            /* ���ú�������ȡֵ */
            n.getValues1(out a, out b);
            Console.WriteLine("�ڷ�������֮��a ��ֵ�� {0}", a);
            Console.WriteLine("�ڷ�������֮��b ��ֵ�� {0}", b);

            //���ô��ݱ���Ҫ���Ѿ���ֵ������
            n.getValues2(ref c, ref d);
            /** ����ᱨ��
             * CalcuApp.cs(36,30): error CS0165: ʹ����δ��ֵ�ľֲ�������c��
             * CalcuApp.cs(36,37): error CS0165: ʹ����δ��ֵ�ľֲ�������d��
             **/
            Console.WriteLine("�ڷ�������֮��c ��ֵ�� {0}", c);
            Console.WriteLine("�ڷ�������֮��d ��ֵ�� {0}", d);
            Console.ReadLine();
        }
    }
}