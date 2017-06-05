using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.CommonModel
{
   
    public partial class DepartmentModel
    {
       
        public int Id { get; set; }

        public string Name { get; set; }

        public string Hods { get; set; }

        public string Contact { get; set; }

        public List <DepartmentModel> DepartmentModelList { get; set; }
    }
}
