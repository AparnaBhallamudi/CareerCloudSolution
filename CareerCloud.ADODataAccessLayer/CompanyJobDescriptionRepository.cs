using CareerCloud.DataAccessLayer;
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
    public class CompanyJobDescriptionRepository : IDataRepository<CompanyJobDescriptionPoco>
    {
        public void Add(params CompanyJobDescriptionPoco[] items)
        {
            SqlConnection conn = new SqlConnection
                                     (
                                       ConfigurationManager
                                       .ConnectionStrings["dbconnection"]
                                       .ConnectionString);
            using (conn)
            {
                foreach (CompanyJobDescriptionPoco item in items)
                {
                    SqlCommand cmd = new SqlCommand(
                                                     @"Insert into [dbo].[Company_Jobs_Descriptions]
                                                       ([Id],[Job],[Job_Name],[Job_Descriptions])
                                                       values
                                                      (@Id,@Job,@Job_Name,@Job_Descriptions)", conn);

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Job", item.Job);
                    cmd.Parameters.AddWithValue("@Job_Name", item.JobName);
                    cmd.Parameters.AddWithValue("@Job_Descriptions", item.JobDescriptions);
                   
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

        public IList<CompanyJobDescriptionPoco> GetAll(params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
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
                                            [Job],
                                            [Job_Name],
                                            [Job_Descriptions],
                                            [Time_Stamp]
                                            FROM [JOB_PORTAL_DB].[dbo].[Company_Jobs_Descriptions]", conn);
                conn.Open();
                int x = 0;
                SqlDataReader rdr = cmd.ExecuteReader();
                CompanyJobDescriptionPoco[] appPocos = new CompanyJobDescriptionPoco[1100];
                while (rdr.Read())
                {
                    CompanyJobDescriptionPoco poco = new CompanyJobDescriptionPoco();
                    poco.Id = rdr.GetGuid(0);
                    poco.Job = rdr.GetGuid(1);
                    poco.JobName = (String)(rdr.IsDBNull(2) ? null : rdr[2]);
                    poco.JobDescriptions = (String)(rdr.IsDBNull(3) ? null : rdr[3]);
                    poco.TimeStamp = (Byte[])(rdr.IsDBNull(4) ? null : rdr[4]);

                    appPocos[x] = poco;
                    x++;

                }
                conn.Close();

                return appPocos.Where(a => a != null).ToList();
            }
        }

        public IList<CompanyJobDescriptionPoco> GetList(Expression<Func<CompanyJobDescriptionPoco, bool>> where, params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyJobDescriptionPoco GetSingle(Expression<Func<CompanyJobDescriptionPoco, bool>> where, params Expression<Func<CompanyJobDescriptionPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyJobDescriptionPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyJobDescriptionPoco[] items)
        {
            SqlConnection conn = new SqlConnection
                                     (
                                       ConfigurationManager
                                       .ConnectionStrings["dbconnection"]
                                       .ConnectionString);
            using (conn)
            {
                foreach (CompanyJobDescriptionPoco item in items)
                {
                    SqlCommand cmd = new SqlCommand(
                                                    $"Delete [dbo].Company_Jobs_Descriptions where Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Update(params CompanyJobDescriptionPoco[] items)
        {
            SqlConnection conn = new SqlConnection
                                     (
                                       ConfigurationManager
                                       .ConnectionStrings["dbconnection"]
                                       .ConnectionString);
            using (conn)
            {
                foreach (CompanyJobDescriptionPoco item in items)
                {
                    SqlCommand cmd = new SqlCommand(@"Update [dbo].[Company_Jobs_Descriptions]
                                                      Set [Job] = @Job,
                                                      [Job_Name] = @Job_Name,
                                                      [Job_Descriptions] = @Job_Descriptions
                                                      where
                                                      [Id] = @Id", conn);

                    cmd.Parameters.AddWithValue("@Job", item.Job);
                    cmd.Parameters.AddWithValue("@Job_Name", item.JobName);
                    cmd.Parameters.AddWithValue("@Job_Descriptions", item.JobDescriptions);
                    cmd.Parameters.AddWithValue("@Id", item.Id);

                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
