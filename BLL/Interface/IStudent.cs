using BOL.CommonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
 public interface IStudent
    {
        List<StudentModel>StudentBsList();

        StudentModel GetDetails(StudentModel model);

        int Save(StudentModel model);

        StudentModel GetById(int id);

        void Delete(StudentModel entity);

    }
}
