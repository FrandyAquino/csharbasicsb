﻿

using Shop.DAL.Models.BaseModels;

namespace Shop.DAL.Models.Suppliers
{
    public class SuppliersUpdateModel : SuppliersBaseModel
    {
        public int supplierid { get; set; }
        public DateTime modify_date { get; set; }
        public int modify_user { get; set; }
    }
}
