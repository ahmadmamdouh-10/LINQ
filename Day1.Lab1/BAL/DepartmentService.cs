using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class DepartmentService
    {
        DbHelper dbHelper = new DbHelper();

        public List<Department> GetDepartments()
        {
            List<Department> departments = new List<Department>();

            foreach (DataRow row in dbHelper.GetAllDepartments().Rows)
            {
                departments.Add(new Department
                {
                    Dnum = (int)row["Dnum"],
                    Dname = row["Dname"].ToString(),
                }
                );
            }

            return departments;
        }

        public void AddDepartment(Department department)
        {

        }
    }
}
