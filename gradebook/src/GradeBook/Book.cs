using System;
using System.Linq;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        /***** Variables *****/

        // Private
        private List<double> grades;
        private static readonly double maximumGrade = 100;
        private static readonly double minimumGrade = 0;


        /***** Methods *****/

        // Private

        // Public
        public Book()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            if(grade >= minimumGrade && grade <= maximumGrade)
                grades.Add(grade);
            else
                Console.WriteLine($"Grade value {grade} is not valid");
        }

        public void PrintGrades()
        {
            System.Console.WriteLine("\nCurrent Grades are:");
            int i = 0;
            foreach(double grade in grades){
                Console.WriteLine($"{i}: {grade}");
                i++;
            }
        }

        public void RemoveGrade(int index)
        {
            if(index >= 0 && index <= grades.Count)
                grades.RemoveAt(index);
            else
                System.Console.WriteLine($"Index {index} does not exist in the current context");
        }

        public void ComputeStatistics()
        {
            var LowestGrade = grades.Min();
            var HighestGrade = grades.Max();
            var averageGrade = grades.Average();
        }
    }
}