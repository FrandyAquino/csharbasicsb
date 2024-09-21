

namespace SchoolAPP.DAL.Core
{
    public abstract class BaseEntity
    {
        public DateTime CreationDate { get; set; }
        public int CreationUser {  get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? UserMod {  get; set; }
        public int? userDeleted { get; set; }
        public DateTime? DeletedDate { get; set; }
        public bool Deleted {  get; set; }
    }
}
