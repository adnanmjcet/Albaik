using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.CommonModel
{
   
    public  class CanteenModel
    {
        

        public int Id { get; set; }

        
        public string Name { get; set; }

        
        public string MenuType { get; set; }

        public decimal? Amount { get; set; }

        public DateTime? PaidDate { get; set; }

        public List <CanteenModel> CanteenModelList { get; set; }
    }
}


