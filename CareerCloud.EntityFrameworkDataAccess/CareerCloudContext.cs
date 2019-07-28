using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.EntityFrameworkDataAccess
{
    class CareerCloudContext : DbContext
    {

        public CareerCloudContext() : base(ConfigurationManager.ConnectionStrings["dbconnection"].ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        DbSet<ApplicantEducationPoco> ApplicantEducations { get; set; }
        DbSet<ApplicantJobApplicationPoco> ApplicantJobApplications { get; set; }
        DbSet<ApplicantProfilePoco> ApplicantProfiles { get; set; }
        DbSet<ApplicantResumePoco> ApplicantResumes { get; set; }
        DbSet<ApplicantSkillPoco> ApplicantSkills { get; set; }
        DbSet<ApplicantWorkHistoryPoco> ApplicantWorkHistory { get; set; }
        DbSet<CompanyDescriptionPoco> CompanyDescriptions { get; set; }
        DbSet<CompanyJobDescriptionPoco> CompanyJobDescriptions { get; set; }
        DbSet<CompanyJobEducationPoco> CompanyJobEducations { get; set; }
        DbSet<CompanyJobPoco> CompanyJobs { get; set; }
        DbSet<CompanyJobSkillPoco> CompanyJobSkills { get; set; }
        DbSet<CompanyLocationPoco> CompanyLocations { get; set; }
        DbSet<CompanyProfilePoco> CompanyProfiles { get; set; }
        DbSet<SecurityLoginPoco> SecurityLogins { get; set; }
        DbSet<SecurityLoginsLogPoco> SecurityLoginsLogs { get; set; }
        DbSet<SecurityLoginsRolePoco> SecurityLoginsRoles { get; set; }
        DbSet<SecurityRolePoco> SecurityRoles { get; set; }
        DbSet<SystemCountryCodePoco> SystemCountryCodes { get; set; }
        DbSet<SystemLanguageCodePoco> SystemLanguageCodes { get; set; }
    }
}
