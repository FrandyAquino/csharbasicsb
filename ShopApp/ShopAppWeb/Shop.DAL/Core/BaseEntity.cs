﻿
namespace Shop.DAL.Core
{
    public abstract class BaseEntity
    {
        public DateTime CreationDate { get; set; }
        public int CreationUser {  get; set; }
        public DateTime? ModifyDate { get; set; }
        public int? ModifyUser { get; set; }
        public int? DeleteUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public bool Deleted { get; set; }
    }
}
