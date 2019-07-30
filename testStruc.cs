using System;
using System.Text;

//struct Books
class Books
{
    private string title;
    private string author;
    private string subject;
    private int book_id;

    public Books()
    {
        Console.WriteLine("default Books");
    }
    public Books(string t, string a, string s, int id)
    {
        Console.WriteLine("params Books");
        title = t;
        author = a;
        subject = s;
        book_id = id;
    }
    public void getValues(string t, string a, string s, int id)
    {
        title = t;
        author = a;
        subject = s;
        book_id = id;
    }
    public void display()
    {
        Console.WriteLine("Title : {0}", title);
        Console.WriteLine("Author : {0}", author);
        Console.WriteLine("Subject : {0}", subject);
        Console.WriteLine("Book_id :{0}", book_id);
    }

};

class Shape
{
    protected int width;
    protected int height;
    public Shape()
    {
        Console.WriteLine("default Shape");
    }
    public Shape(int w, int h)
    {
        Console.WriteLine("params Shape");
        width = w;
        height = h;
    }

    public void setWidth(int w)
    {
        width = w;
    }
    public void setHeight(int h)
    {
        height = h;
    }
    
};

class ThreeKing : Books,Shape
{
    public ThreeKing(string t, string a, string s, int id) {
        Books(t,a,s,id);
        Shape(id, id);
        Console.WriteLine("ThreeKing Books");
    }

};

public class testStructure
{
    public static void Main(string[] args)
    {

        Books Book1 = new Books(); /* ���� Book1������Ϊ Book */
        Books Book2 = new Books("aa","bb","cc",6666); /* ���� Book2������Ϊ Book */
        ThreeKing tkBook = new ThreeKing("aa", "bb", "cc", 6666);
        /* ��ӡ Book ��Ϣ */
        Book1.display();
        Book2.display();
        tkBook.display();


        /* book 1 ���� */
        Book1.getValues("C Programming",
        "Nuha Ali", "C Programming Tutorial", 6495407);

        /* book 2 ���� */
        Book2.getValues("Telecom Billing",
        "Zara Ali", "Telecom Billing Tutorial", 6495700);

        /* ��ӡ Book1 ��Ϣ */
        Book1.display();

        /* ��ӡ Book2 ��Ϣ */
        Book2.display();

        Console.ReadKey();

    }
}