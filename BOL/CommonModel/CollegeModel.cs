using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.CommonModel
{

    public partial class CollegeModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Location { get; set; }

        public string Affiliation { get; set; }

        public string Contactno { get; set; }

        public string Code { get; set; }

        public int? StudentId { get; set; }

        public int? DepartmentId { get; set; }

        public int? CanteenId { get; set; }

        public int? LibraryId { get; set; }

        public List<CanteenModel> CanteenModelList { get; set; }

        public List<DepartmentModel> DepartmentModelList { get; set; }

        public List<LibraryModel> LibraryModelList { get; set; }

        public List<StudentModel> StudentModelList { get; set; }

        public List <CollegeModel> CollegeModelList { get; set; }
    }
}
