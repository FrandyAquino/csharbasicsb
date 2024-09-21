
using SchoolAPP.DAL.Context;
using SchoolAPP.DAL.Interfaces;
using SchoolAPP.DAL.Models;

namespace SchoolAPP.DAL.Daos
{
    public class DepartmentDb : IDepartmentDb
    {
        private readonly SchoolContext context;
        public DepartmentDb(SchoolContext context) 
        { 
        this.context = context;
        }
        public DepartmentModel GetDepartmenT(int departmentId)
        {
            throw new NotImplementedException();
        }

        public List<DepartmentModel> GetDepartments()
        {
            throw new NotImplementedException();
        }

        public void RemoveDepartment(DepartmentRemoveModel departmentAdd)
        {
            throw new NotImplementedException();
        }

        public void SaveDepartment(DepartmentAddModel departmentAdd)
        {
            throw new NotImplementedException();
        }

        public void UpdateDepartment(DepartmentUpdateModel departmentAdd)
        {
            throw new NotImplementedException();
        }
    }
}
