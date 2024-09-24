
namespace Shop.DAL.Core
{
    public abstract class BaseEntity
    {
        public DateTime creation_date { get; set; }
        public int creation_user {  get; set; }
        public DateTime? modify_date { get; set; }
        public int? modify_user { get; set; }
        public int? delete_user { get; set; }
        public DateTime? delete_date { get; set; }
        public bool deleted { get; set; }
    }
}
