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
    public class Company : ICompany
    {
        public void AddCompanyDescription(CompanyDescriptionPoco[] items)
        {
            var logic = new CompanyDescriptionLogic
                (new EFGenericRepository<CompanyDescriptionPoco>(false));
            logic.Add(items);
        }

        public void AddCompanyJob(CompanyJobPoco[] items)
        {
            var logic = new CompanyJobLogic
                (new EFGenericRepository<CompanyJobPoco>(false));
            logic.Add(items);
        }

        public void AddCompanyJobDescription(CompanyJobDescriptionPoco[] items)
        {
            var logic = new CompanyJobDescriptionLogic
                (new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            logic.Add(items);
        }

        public void AddCompanyJobEducation(CompanyJobEducationPoco[] items)
        {
            var logic = new CompanyJobEducationLogic
                (new EFGenericRepository<CompanyJobEducationPoco>(false));
            logic.Add(items);
        }

        public void AddCompanyJobSkill(CompanyJobSkillPoco[] items)
        {
            var logic = new CompanyJobSkillLogic
                (new EFGenericRepository<CompanyJobSkillPoco>(false));
            logic.Add(items);
        }

        public void AddCompanyLocation(CompanyLocationPoco[] items)
        {
            var logic = new CompanyLocationLogic
                (new EFGenericRepository<CompanyLocationPoco>(false));
            logic.Add(items);
        }

        public void AddCompanyProfile(CompanyProfilePoco[] items)
        {
            var logic = new CompanyProfileLogic
                (new EFGenericRepository<CompanyProfilePoco>(false));
            logic.Add(items);
        }

        public List<CompanyDescriptionPoco> GetAllCompanyDescription()
        {
            var logic = new CompanyDescriptionLogic
               (new EFGenericRepository<CompanyDescriptionPoco>(false));
            return logic.GetAll();
        }

        public List<CompanyJobPoco> GetAllCompanyJob()
        {
            var logic = new CompanyJobLogic
               (new EFGenericRepository<CompanyJobPoco>(false));
            return logic.GetAll();
        }

        public List<CompanyJobDescriptionPoco> GetAllCompanyJobDescription()
        {
            var logic = new CompanyJobDescriptionLogic
               (new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            return logic.GetAll();
        }

        public List<CompanyJobEducationPoco> GetAllCompanyJobEducation()
        {
            var logic = new CompanyJobEducationLogic
               (new EFGenericRepository<CompanyJobEducationPoco>(false));
            return logic.GetAll();
        }

        public List<CompanyJobSkillPoco> GetAllCompanyJobSkill()
        {
            var logic = new CompanyJobSkillLogic
               (new EFGenericRepository<CompanyJobSkillPoco>(false));
            return logic.GetAll();
        }

        public List<CompanyLocationPoco> GetAllCompanyLocation()
        {
            var logic = new CompanyLocationLogic
               (new EFGenericRepository<CompanyLocationPoco>(false));
            return logic.GetAll();
        }

        public List<CompanyProfilePoco> GetAllCompanyProfile()
        {
            var logic = new CompanyProfileLogic
               (new EFGenericRepository<CompanyProfilePoco>(false));
            return logic.GetAll();
        }

        public CompanyDescriptionPoco GetSingleCompanyDescription(string Id)
        {
            CompanyDescriptionLogic logic =
                new CompanyDescriptionLogic
                (new EFGenericRepository<CompanyDescriptionPoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public CompanyJobPoco GetSingleCompanyJob(string Id)
        {
            CompanyJobLogic logic =
                new CompanyJobLogic
                (new EFGenericRepository<CompanyJobPoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public CompanyJobDescriptionPoco GetSingleCompanyJobDescription(string Id)
        {
            CompanyJobDescriptionLogic logic =
                new CompanyJobDescriptionLogic
                (new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public CompanyJobEducationPoco GetSingleCompanyJobEducation(string Id)
        {
            CompanyJobEducationLogic logic =
                new CompanyJobEducationLogic
                (new EFGenericRepository<CompanyJobEducationPoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public CompanyJobSkillPoco GetSingleCompanyJobSkill(string Id)
        {
            CompanyJobSkillLogic logic =
                new CompanyJobSkillLogic
                (new EFGenericRepository<CompanyJobSkillPoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public CompanyLocationPoco GetSingleCompanyLocation(string Id)
        {
            CompanyLocationLogic logic =
                new CompanyLocationLogic
                (new EFGenericRepository<CompanyLocationPoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public CompanyProfilePoco GetSingleCompanyProfile(string Id)
        {
            CompanyProfileLogic logic =
                new CompanyProfileLogic
                (new EFGenericRepository<CompanyProfilePoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveCompanyDescription(CompanyDescriptionPoco[] items)
        {
            var logic = new CompanyDescriptionLogic
                (new EFGenericRepository<CompanyDescriptionPoco>(false));
            logic.Delete(items);
        }

        public void RemoveCompanyJob(CompanyJobPoco[] items)
        {
            var logic = new CompanyJobLogic
                (new EFGenericRepository<CompanyJobPoco>(false));
            logic.Delete(items);
        }

        public void RemoveCompanyJobDescription(CompanyJobDescriptionPoco[] items)
        {
            var logic = new CompanyJobDescriptionLogic
                (new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            logic.Delete(items);
        }

        public void RemoveCompanyJobEducation(CompanyJobEducationPoco[] items)
        {
            var logic = new CompanyJobEducationLogic
                (new EFGenericRepository<CompanyJobEducationPoco>(false));
            logic.Delete(items);
        }

        public void RemoveCompanyJobSkill(CompanyJobSkillPoco[] items)
        {
            var logic = new CompanyJobSkillLogic
                (new EFGenericRepository<CompanyJobSkillPoco>(false));
            logic.Delete(items);
        }

        public void RemoveCompanyLocation(CompanyLocationPoco[] items)
        {
            var logic = new CompanyLocationLogic
                (new EFGenericRepository<CompanyLocationPoco>(false));
            logic.Delete(items);
        }

        public void RemoveCompanyProfile(CompanyProfilePoco[] items)
        {
            var logic = new CompanyProfileLogic
                (new EFGenericRepository<CompanyProfilePoco>(false));
            logic.Delete(items);
        }

        public void UpdateCompanyDescription(CompanyDescriptionPoco[] items)
        {
            var logic = new CompanyDescriptionLogic
                (new EFGenericRepository<CompanyDescriptionPoco>(false));
            logic.Update(items);
        }

        public void UpdateCompanyJob(CompanyJobPoco[] items)
        {
            var logic = new CompanyJobLogic
                (new EFGenericRepository<CompanyJobPoco>(false));
            logic.Update(items);
        }

        public void UpdateCompanyJobDescription(CompanyJobDescriptionPoco[] items)
        {
            var logic = new CompanyJobDescriptionLogic
                (new EFGenericRepository<CompanyJobDescriptionPoco>(false));
            logic.Update(items);
        }

        public void UpdateCompanyJobEducation(CompanyJobEducationPoco[] items)
        {
            var logic = new CompanyJobEducationLogic
                (new EFGenericRepository<CompanyJobEducationPoco>(false));
            logic.Update(items);
        }

        public void UpdateCompanyJobSkill(CompanyJobSkillPoco[] items)
        {
            var logic = new CompanyJobSkillLogic
                (new EFGenericRepository<CompanyJobSkillPoco>(false));
            logic.Update(items);
        }

        public void UpdateCompanyLocation(CompanyLocationPoco[] items)
        {
            var logic = new CompanyLocationLogic
                (new EFGenericRepository<CompanyLocationPoco>(false));
            logic.Update(items);
        }

        public void UpdateCompanyProfile(CompanyProfilePoco[] items)
        {
            var logic = new CompanyProfileLogic
                (new EFGenericRepository<CompanyProfilePoco>(false));
            logic.Update(items);
        }
    }
}
