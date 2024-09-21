
using SchoolAPP.DAL.Core;

namespace SchoolAPP.DAL.Entities
{
    public class Course : BaseEntity
    {
        public int CourseID { get; set; }
        public string? Title { get; set; }
        public int Crediits { get; set; }
        public int DepartmentID { get; set; }

    }
}
