using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Models
{
    internal class Initializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ContractorDbContext>
    {
        protected override void Seed(ContractorDbContext context)
        {
            SeedContractor(context);
            base.Seed(context);
        }

        private void SeedContractor(ContractorDbContext context)
        {
            var listOfContractors = new List<ContractorModel> {
          new ContractorModel() { ContractorsName = "ZUS", Nip = "097523273", TypeOfContractor = "Klient", CompanyDescription = "abcdefghijklmnoprstuwxyz", IsActive =true },
            new ContractorModel() { ContractorsName = "GUS", Nip = "086332578", TypeOfContractor = "Klient", CompanyDescription = "abcdefghijklmnoprstuwxyz", IsActive =true },
           new ContractorModel() { ContractorsName = "PZU", Nip = "028748393", TypeOfContractor = "Potencjalny klient", CompanyDescription = "abcdefghijklmnoprstuwxyz", IsActive =true }
            };
        
            listOfContractors.ForEach( c=> context.Set<ContractorModel>().Add(c));
            context.SaveChanges();
            
        }          
    }
    
}
