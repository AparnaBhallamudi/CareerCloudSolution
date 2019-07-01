using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemCountryCodeLogic : SystemCountryCodePoco
    {
        
        public SystemCountryCodeLogic(IDataRepository<SystemCountryCodePoco> repository) 
        {
        }


        public void Add(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            Add(pocos);
        }

        public void Update(SystemCountryCodePoco[] pocos)
        {
            Verify(pocos);
            Update(pocos);
        }
        public void Delete(SystemCountryCodePoco[] pocos)
        {
            Delete(pocos);
        }
        public void GetAll(SystemCountryCodePoco[] pocos)
        {
            GetAll(pocos);
        }
        public void Get(SystemCountryCodePoco[] pocos)
        {
            Get(pocos);
        }

               
        protected void Verify(SystemCountryCodePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (var poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.Code))
                {
                    exceptions.Add(new ValidationException(900, $"Code for {poco.Code} cannot be empty or null"));
                }
                if (string.IsNullOrEmpty(poco.Name))
                {
                    exceptions.Add(new ValidationException(901, $"Name for {poco.Code} cannot be empty or null"));
                }

            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }
    }
}
