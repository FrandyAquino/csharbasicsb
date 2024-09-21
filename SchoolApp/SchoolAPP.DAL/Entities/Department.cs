

using SchoolAPP.DAL.Core;

namespace SchoolAPP.DAL.Entities
{
    public class Department : BaseEntity
    {
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartDate { get; set; }
        public int? Administrator {  get; set; }

    }
}
