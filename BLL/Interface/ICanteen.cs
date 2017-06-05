using BOL.CommonModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface ICanteen
    {
        List<CanteenModel> CanteenBsList();

        CanteenModel GetDetails(CanteenModel model);

        int Save(CanteenModel model);

        CanteenModel GetById(int id);

        void Delete(CanteenModel entity);

    }
}
