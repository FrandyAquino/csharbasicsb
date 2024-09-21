

using SchoolAPP.DAL.Core;

namespace SchoolAPP.DAL.Entities
{
    public class Student : Person
    {
        public DateTime EnrollmentDate { get; set; }
    }
}
