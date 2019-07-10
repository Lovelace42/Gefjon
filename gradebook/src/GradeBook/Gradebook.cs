using System.Linq;
using System.Collections.Generic;

namespace GradeBook
{
    class Gradebook
    {
        /***** Variables *****/

        // Private
        private List<double> grades;


        /***** Methods *****/

        // Private

        // Public
        public Gradebook()
        {
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void ComputeStatistics()
        {
            var minimumGrade = grades.Min();
            var maximumGrade = grades.Max();
            var averageGrade = grades.Average();
        }
    }
}