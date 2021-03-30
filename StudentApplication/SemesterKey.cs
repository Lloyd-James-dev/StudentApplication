using System;

namespace StudentApplication {

    /// <summary>
    /// For easy access to values of the composite keys of Semester
    /// </summary>
    public class SemesterKey {

        /// <summary>
        /// Returns a five digit integer for (4 digit year followed directly by 1 or 2 for semester)<br></br>
        /// For chronological comparison of semester timelines
        /// </summary>
        public int Key { get; }
        /// <summary>
        /// Returns a four digit integer for the  year
        /// </summary>
        public int Year { get; }
        /// <summary>
        /// Returns a 1 or a 2 as an integer for the semester
        /// </summary>
        public int Semester { get; }

        // Requires a string of 5 numbers (4 digit year followed directly by 1 or 2 for semester)
        public SemesterKey(string key) {
            Year = int.Parse(key.Substring(0, 4));
            Semester = int.Parse(key.Substring(4, 1));
            Key = int.Parse(key);
        }

        // Requires an integer of 5 digits (4 digit year multiplied by ten then add 1 or 2 for semester)
        public SemesterKey(int key) {
            Year = key / 10;
            Semester = key % 10;
            Key = key;
        }

        // Requires a date of Jan 1 for the year and bool as true for second semester otherwise false
        public SemesterKey(DateTime date, bool isSecondSemester) {
            Year = date.Year;
            Semester = isSecondSemester ? 2 : 1;
            Key = (Year * 10) + Semester;
        }

        // Requires type of Semester
        public SemesterKey(StudentApp_Model.Semester semester) {
            Year = semester.Year.Year;
            Semester = semester.SecondSemester ? 2 : 1;
            Key = (Year * 10) + Semester;
        }
    }
}
