using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            book.AddGrade(89.1);
            book.AddGrade(93.2);
            book.AddGrade(62.5);
            book.AddGrade(23);
            book.AddGrade(0);
            book.AddGrade(-34);
            book.AddGrade(101);
            book.AddGrade(100);

            book.PrintGrades();

            book.RemoveGrade(3);

            book.PrintGrades();
        }
    }
}
