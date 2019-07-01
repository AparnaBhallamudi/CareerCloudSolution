using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.BusinessLogicLayer
{
    public class SystemLanguageCodeLogic
    {
        
        public SystemLanguageCodeLogic(IDataRepository<SystemLanguageCodePoco> repository)
        {
        }


        public void Add(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            Add(pocos);
        }

        public void Update(SystemLanguageCodePoco[] pocos)
        {
            Verify(pocos);
            Update(pocos);
        }
        public void Delete(SystemLanguageCodePoco[] pocos)
        {
            Delete(pocos);
        }
        public void GetAll(SystemLanguageCodePoco[] pocos)
        {
            GetAll(pocos);
        }
        public void Get(SystemLanguageCodePoco[] pocos)
        {
            Get(pocos);
        }

        protected void Verify(SystemLanguageCodePoco[] pocos)
        {
            List<ValidationException> exceptions = new List<ValidationException>();

            foreach (var poco in pocos)
            {
                if (string.IsNullOrEmpty(poco.LanguageID))
                {
                    exceptions.Add(new ValidationException(1000, $"LanguageId for {poco.LanguageID} cannot be empty or null"));
                }
                if (string.IsNullOrEmpty(poco.Name))
                {
                    exceptions.Add(new ValidationException(1001, $"Name for {poco.LanguageID} cannot be empty or null"));
                }
                if (string.IsNullOrEmpty(poco.NativeName))
                {
                    exceptions.Add(new ValidationException(1002, $"NativeName for {poco.LanguageID} cannot be empty or null"));
                }

            }

            if (exceptions.Count > 0)
            {
                throw new AggregateException(exceptions);
            }
        }

        
    }
}
