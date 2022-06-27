using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
	static public class ChangingDataContractor
	{		
		static public string ContractorsName { get; set; }
		static public string Nip { get; set; }
		static public string TypeOfContractor { get; set; }
		static public string CompanyDescription { get; set; }
		static public bool IsActive { get; set; }
		static public bool AddClicked { get;  set; }
		static public bool EditClicked { get;  set; }
	}
}
