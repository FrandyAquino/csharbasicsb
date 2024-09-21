

namespace SchoolAPP.DAL.Core
{
    public abstract class Person : BaseEntity
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }

    }
}
