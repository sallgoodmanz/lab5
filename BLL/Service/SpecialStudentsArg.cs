using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class SpecialStudentsArg
    {
        public static bool IsFiveCourseStudent(this Student student)
        {
            if (student.Year == 4 && (student.dateOfBirth.Month <= 5 && student.dateOfBirth.Month >= 3))
            {
                return true;
            }
            return false;
        }
    }
}
