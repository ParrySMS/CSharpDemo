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