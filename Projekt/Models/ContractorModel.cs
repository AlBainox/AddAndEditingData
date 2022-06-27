using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{   
    
    public class ContractorModel
    {
		public int ContractorModelId { get; set; }
		public string ContractorsName { get; set; }
        public string Nip { get; set; }
        public string TypeOfContractor { get; set; }
        public string CompanyDescription { get; set; }
        public bool IsActive { get; set; }

    }
   
}
