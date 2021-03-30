using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp_Model.Validation {
    public class RegisteredStudentEnrolInCourseValidation : AbstractValidator<RegisteredStudentEnrolInCourseAtSemesterAtCollege> {

        public RegisteredStudentEnrolInCourseValidation() {

            RuleFor(c => c.CourseCollegeId).Equal(s => s.StudentCollegeId);
            RuleFor(c => c.CourseYear).Equal(s => s.StudentYear);
            RuleFor(c => c.CourseSecondSemester).Equal(s => s.StudentSecondSemester);

        }
    }
}
