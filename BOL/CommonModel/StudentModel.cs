using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.CommonModel
{
    public partial class StudentModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Branch { get; set; }

        public string Phoneno { get; set; }

        public string AcademicYear { get; set; }

        public byte[] Photo { get; set; }

        public List<StudentModel> StudentModelList { get; set; }
    }
}
