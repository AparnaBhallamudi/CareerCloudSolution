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
    public class Applicant : IApplicant
    {
        public void AddApplicantEducation(ApplicantEducationPoco[] items)
        {
            var logic = new ApplicantEducationLogic
                (new EFGenericRepository<ApplicantEducationPoco>(false));
            logic.Add(items);
        }

        public void AddApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            var logic = new ApplicantJobApplicationLogic
                (new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            logic.Add(items);
        }

        public void AddApplicantProfile(ApplicantProfilePoco[] items)
        {
            var logic = new ApplicantProfileLogic
                (new EFGenericRepository<ApplicantProfilePoco>(false));
            logic.Add(items);
        }

        public void AddApplicantResume(ApplicantResumePoco[] items)
        {
            var logic = new ApplicantResumeLogic
                (new EFGenericRepository<ApplicantResumePoco>(false));
            logic.Add(items);
        }

        public void AddApplicantSkill(ApplicantSkillPoco[] items)
        {
            var logic = new ApplicantSkillLogic
                (new EFGenericRepository<ApplicantSkillPoco>(false));
            logic.Add(items);
        }

        public void AddApplicantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            var logic = new ApplicantWorkHistoryLogic
                (new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            logic.Add(items);
        }

        public List<ApplicantEducationPoco> GetAllApplicantEducation()
        {
            var logic = new ApplicantEducationLogic
                (new EFGenericRepository<ApplicantEducationPoco>(false));
            return logic.GetAll();
        }

        public List<ApplicantJobApplicationPoco> GetAllApplicantJobApplication()
        {
            var logic = new ApplicantJobApplicationLogic
                (new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            return logic.GetAll();
        }

        public List<ApplicantProfilePoco> GetAllApplicantProfile()
        {
            var logic = new ApplicantProfileLogic
                (new EFGenericRepository<ApplicantProfilePoco>(false));
            return logic.GetAll();
        }

        public List<ApplicantResumePoco> GetAllApplicantResume()
        {
            var logic = new ApplicantResumeLogic
                (new EFGenericRepository<ApplicantResumePoco>(false));
            return logic.GetAll();
        }

        public List<ApplicantSkillPoco> GetAllApplicantSkill()
        {
            var logic = new ApplicantSkillLogic
                (new EFGenericRepository<ApplicantSkillPoco>(false));
            return logic.GetAll();
        }

        public List<ApplicantWorkHistoryPoco> GetAllApplicantWorkHistory()
        {
            var logic = new ApplicantWorkHistoryLogic
                (new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            return logic.GetAll();
        }

        public ApplicantEducationPoco GetSingleApplicantEducation(string Id)
        {
            ApplicantEducationLogic logic =
                new ApplicantEducationLogic
                (new EFGenericRepository<ApplicantEducationPoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public ApplicantJobApplicationPoco GetSingleApplicantJobApplication(string Id)
        {
            ApplicantJobApplicationLogic logic =
                new ApplicantJobApplicationLogic
                (new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public ApplicantProfilePoco GetSingleApplicantProfile(string Id)
        {
            ApplicantProfileLogic logic =
                new ApplicantProfileLogic
                (new EFGenericRepository<ApplicantProfilePoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public ApplicantResumePoco GetSingleApplicantResume(string Id)
        {
            ApplicantResumeLogic logic =
                new ApplicantResumeLogic
                (new EFGenericRepository<ApplicantResumePoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public ApplicantSkillPoco GetSingleApplicantSkill(string Id)
        {
            ApplicantSkillLogic logic =
                new ApplicantSkillLogic
                (new EFGenericRepository<ApplicantSkillPoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public ApplicantWorkHistoryPoco GetSingleApplicantWorkHistory(string Id)
        {
            ApplicantWorkHistoryLogic logic =
                new ApplicantWorkHistoryLogic
                (new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            return logic.Get(Guid.Parse(Id));
        }

        public void RemoveApplicantEducation(ApplicantEducationPoco[] items)
        {
            var logic = new ApplicantEducationLogic
                (new EFGenericRepository<ApplicantEducationPoco>(false));
            logic.Delete(items);
        }

        public void RemoveApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            var logic = new ApplicantJobApplicationLogic
                (new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            logic.Delete(items);
        }

        public void RemoveApplicantProfile(ApplicantProfilePoco[] items)
        {
            var logic = new ApplicantProfileLogic
                (new EFGenericRepository<ApplicantProfilePoco>(false));
            logic.Delete(items);
        }

        public void RemoveApplicantResume(ApplicantResumePoco[] items)
        {
            var logic = new ApplicantResumeLogic
                (new EFGenericRepository<ApplicantResumePoco>(false));
            logic.Delete(items);
        }

        public void RemoveApplicantSkill(ApplicantSkillPoco[] items)
        {
            var logic = new ApplicantSkillLogic
                (new EFGenericRepository<ApplicantSkillPoco>(false));
            logic.Delete(items);
        }

        public void RemoveApplicantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            var logic = new ApplicantWorkHistoryLogic
                (new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            logic.Delete(items);
        }

        public void UpdateApplicantEducation(ApplicantEducationPoco[] items)
        {
            var logic = new ApplicantEducationLogic
                (new EFGenericRepository<ApplicantEducationPoco>(false));
            logic.Update(items);
        }

        public void UpdateApplicantJobApplication(ApplicantJobApplicationPoco[] items)
        {
            var logic = new ApplicantJobApplicationLogic
                (new EFGenericRepository<ApplicantJobApplicationPoco>(false));
            logic.Update(items);
        }

        public void UpdateApplicantProfile(ApplicantProfilePoco[] items)
        {
            var logic = new ApplicantProfileLogic
                (new EFGenericRepository<ApplicantProfilePoco>(false));
            logic.Update(items);
        }

        public void UpdateApplicantResume(ApplicantResumePoco[] items)
        {
            var logic = new ApplicantResumeLogic
                (new EFGenericRepository<ApplicantResumePoco>(false));
            logic.Update(items);
        }

        public void UpdateApplicantSkill(ApplicantSkillPoco[] items)
        {
            var logic = new ApplicantSkillLogic
                (new EFGenericRepository<ApplicantSkillPoco>(false));
            logic.Update(items);
        }

        public void UpdateApplicantWorkHistory(ApplicantWorkHistoryPoco[] items)
        {
            var logic = new ApplicantWorkHistoryLogic
                (new EFGenericRepository<ApplicantWorkHistoryPoco>(false));
            logic.Update(items);
        }
    }
}
