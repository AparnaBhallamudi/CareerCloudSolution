﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;

namespace CareerCloud.WCF
{
    public class System : ISystem
    {
        public void AddSystemCountryCode(SystemCountryCodePoco[] items)
        {
            var logic = new SystemCountryCodeLogic
                (new EFGenericRepository<SystemCountryCodePoco>(false));
            logic.Add(items);
        }

        public void AddSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            var logic = new SystemLanguageCodeLogic
                (new EFGenericRepository<SystemLanguageCodePoco>(false));
            logic.Add(items);
        }

        public List<SystemCountryCodePoco> GetAllSystemCountryCode()
        {
            var logic = new SystemCountryCodeLogic
               (new EFGenericRepository<SystemCountryCodePoco>(false));
            return logic.GetAll();
        }

        public List<SystemLanguageCodePoco> GetAllSystemLanguageCode()
        {
            var logic = new SystemLanguageCodeLogic
               (new EFGenericRepository<SystemLanguageCodePoco>(false));
            return logic.GetAll();
        }

        public SystemCountryCodePoco GetSingleSystemCountryCode(string code)
        {

            SystemCountryCodeLogic logic =
                            new SystemCountryCodeLogic
                            (new EFGenericRepository<SystemCountryCodePoco>(false));
            return logic.Get(code);
        }

        public SystemLanguageCodePoco GetSingleSystemLanguageCode(string LanguageID)
        {
            SystemLanguageCodeLogic logic =
                            new SystemLanguageCodeLogic
                            (new EFGenericRepository<SystemLanguageCodePoco>(false));
            return logic.Get(LanguageID);
        }

        public void RemoveSystemCountryCode(SystemCountryCodePoco[] items)
        {
            var logic = new SystemCountryCodeLogic
                (new EFGenericRepository<SystemCountryCodePoco>(false));
            logic.Delete(items);
        }

        public void RemoveSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            var logic = new SystemLanguageCodeLogic
                (new EFGenericRepository<SystemLanguageCodePoco>(false));
            logic.Delete(items);
        }

        public void UpdateSystemCountryCode(SystemCountryCodePoco[] items)
        {
            var logic = new SystemCountryCodeLogic
                (new EFGenericRepository<SystemCountryCodePoco>(false));
            logic.Update(items);
        }

        public void UpdateSystemLanguageCode(SystemLanguageCodePoco[] items)
        {
            var logic = new SystemLanguageCodeLogic
                (new EFGenericRepository<SystemLanguageCodePoco>(false));
            logic.Update(items);
        }
    }
}
