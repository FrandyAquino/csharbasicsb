
using SchoolAPP.DAL.Models;

namespace SchoolAPP.DAL.Interfaces
{
    public interface IDepartmentDb
    {
        List<DepartmentModel> GetDepartments();
        DepartmentModel GetDepartmenT(int departmentId);
        void SaveDepartment(DepartmentAddModel departmentAdd);
        void UpdateDepartment(DepartmentUpdateModel departmentAdd);
        void RemoveDepartment(DepartmentRemoveModel departmentAdd);
    }
}
