﻿using CareerCloud.DataAccessLayer;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.ADODataAccessLayer
{
    public class ApplicantSkillRepository : IDataRepository<ApplicantSkillPoco>
    {
        public void Add(params ApplicantSkillPoco[] items)
        {
            SqlConnection conn = new SqlConnection
                                     (
                                       ConfigurationManager
                                       .ConnectionStrings["dbconnection"]
                                       .ConnectionString);
            using (conn)
            {
                foreach (ApplicantSkillPoco item in items)
                {
                    SqlCommand cmd = new SqlCommand(
                                                     @"Insert into [dbo].[Applicant_Skills]
                                                       ([Id],[Applicant],[Skill],[Skill_Level],[Start_Month],[Start_Year],[End_Month],[End_Year])
                                                       values
                                                      (@Id,@Applicant,@Skill,@Skill_Level,@Start_Month,@Start_Year,@End_Month,@End_Year)", conn);

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Applicant", item.Applicant);
                    cmd.Parameters.AddWithValue("@Skill", item.Skill);
                    cmd.Parameters.AddWithValue("@Skill_Level", item.SkillLevel);
                    cmd.Parameters.AddWithValue("@Start_Month", item.StartMonth);
                    cmd.Parameters.AddWithValue("@Start_Year", item.StartYear);
                    cmd.Parameters.AddWithValue("@End_Month", item.EndMonth);
                    cmd.Parameters.AddWithValue("@End_Year", item.EndYear);

                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void CallStoredProc(string name, params Tuple<string, string>[] parameters)
        {
            throw new NotImplementedException();
        }

        public IList<ApplicantSkillPoco> GetAll(params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            SqlConnection conn = new SqlConnection
                                    (
                                      ConfigurationManager
                                      .ConnectionStrings["dbconnection"]
                                      .ConnectionString);
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(
                                            @"Select [Id],
                                            [Applicant],
                                            [Skill],
                                            [Skill_Level],
                                            [Start_Month],
                                            [Start_Year],
                                            [End_Month],
                                            [End_Year],
                                            [Time_Stamp]
                                            FROM [JOB_PORTAL_DB].[dbo].[Applicant_Skills]", conn);
                conn.Open();
                int x = 0;
                SqlDataReader rdr = cmd.ExecuteReader();
                ApplicantSkillPoco[] appPocos = new ApplicantSkillPoco[1000];
                while (rdr.Read())
                {
                    ApplicantSkillPoco poco = new ApplicantSkillPoco();
                    poco.Id = rdr.GetGuid(0);
                    poco.Applicant = rdr.GetGuid(1);
                    poco.Skill = rdr.GetString(2);
                    poco.SkillLevel = rdr.GetString(3);
                    poco.StartMonth = rdr.GetByte(4);
                    poco.StartYear = rdr.GetInt32(5);
                    poco.EndMonth = rdr.GetByte(6);
                    poco.EndYear = rdr.GetInt32(7);
                    poco.TimeStamp = (byte[])rdr[8];

                    appPocos[x] = poco;
                    x++;

                }
                conn.Close();

                return appPocos.Where(a => a != null).ToList();
            }
        }

        public IList<ApplicantSkillPoco> GetList(Expression<Func<ApplicantSkillPoco, bool>> where, params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public ApplicantSkillPoco GetSingle(Expression<Func<ApplicantSkillPoco, bool>> where, params Expression<Func<ApplicantSkillPoco, object>>[] navigationProperties)
        {
            IQueryable<ApplicantSkillPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params ApplicantSkillPoco[] items)
        {
            SqlConnection conn = new SqlConnection
                                     (
                                       ConfigurationManager
                                       .ConnectionStrings["dbconnection"]
                                       .ConnectionString);
            using (conn)
            {
                foreach (ApplicantSkillPoco item in items)
                {
                    SqlCommand cmd = new SqlCommand(
                                                    $"Delete [dbo].Applicant_Skills where Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Update(params ApplicantSkillPoco[] items)
        {
            SqlConnection conn = new SqlConnection
                                     (
                                       ConfigurationManager
                                       .ConnectionStrings["dbconnection"]
                                       .ConnectionString);
            using (conn)
            {
                foreach (ApplicantSkillPoco item in items)
                {
                    SqlCommand cmd = new SqlCommand(@"Update [dbo].[Applicant_Skills]
                                                      Set [Applicant] = @Applicant,
                                                      [Skill] = @Skill,
                                                      [Skill_Level] = @Skill_Level,
                                                      [Start_Month] = @Start_Month,
                                                      [Start_Year] = @Start_Year,
                                                      [End_Month] = @End_Month,
                                                      [End_Year] = @End_Year
                                                       where
                                                      [Id] = @Id", conn);

                    cmd.Parameters.AddWithValue("@Applicant", item.Applicant);
                    cmd.Parameters.AddWithValue("@Skill", item.Skill);
                    cmd.Parameters.AddWithValue("@Skill_Level", item.SkillLevel);
                    cmd.Parameters.AddWithValue("@Start_Month", item.StartMonth);
                    cmd.Parameters.AddWithValue("@Start_Year", item.StartYear);
                    cmd.Parameters.AddWithValue("@End_Month", item.EndMonth);
                    cmd.Parameters.AddWithValue("@End_Year", item.EndYear);
                    cmd.Parameters.AddWithValue("@Id", item.Id);

                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
