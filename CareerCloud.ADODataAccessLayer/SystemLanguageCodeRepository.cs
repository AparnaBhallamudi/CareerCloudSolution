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
    public class SystemLanguageCodeRepository : IDataRepository<SystemLanguageCodePoco>

    {
        public void Add(params SystemLanguageCodePoco[] items)
        {
            SqlConnection conn = new SqlConnection
                                     (
                                       ConfigurationManager
                                       .ConnectionStrings["dbconnection"]
                                       .ConnectionString);
            using (conn)
            {
                foreach (SystemLanguageCodePoco item in items)
                {
                    SqlCommand cmd = new SqlCommand(
                                                     @"Insert into [dbo].[System_Language_Codes]
                                                       ([LanguageID],[Name],[Native_Name])
                                                       values
                                                      (@LanguageID,@Name,@Native_Name)", conn);

                    cmd.Parameters.AddWithValue("@LanguageID", item.LanguageID);
                    cmd.Parameters.AddWithValue("@Name", item.Name);
                    cmd.Parameters.AddWithValue("@Native_Name", item.NativeName);
                  

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

        public IList<SystemLanguageCodePoco> GetAll(params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            SqlConnection conn = new SqlConnection
                                    (
                                      ConfigurationManager
                                      .ConnectionStrings["dbconnection"]
                                      .ConnectionString);
            using (conn)
            {
                SqlCommand cmd = new SqlCommand(
                                            @"Select [LanguageID],
                                            [Name],
                                            [Native_Name]
                                            FROM [JOB_PORTAL_DB].[dbo].[System_Language_Codes]", conn);
                conn.Open();
                int x = 0;
                SqlDataReader rdr = cmd.ExecuteReader();
                SystemLanguageCodePoco[] appPocos = new SystemLanguageCodePoco[1000];
                while (rdr.Read())
                {
                    SystemLanguageCodePoco poco = new SystemLanguageCodePoco();
                    poco.LanguageID = rdr.GetString(0);
                    poco.Name = rdr.GetString(1);
                    poco.NativeName = rdr.GetString(2);

                    appPocos[x] = poco;
                    x++;

                }
                conn.Close();

                return appPocos.Where(a => a != null).ToList();
            }
        }

        public IList<SystemLanguageCodePoco> GetList(Expression<Func<SystemLanguageCodePoco, bool>> where, params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public SystemLanguageCodePoco GetSingle(Expression<Func<SystemLanguageCodePoco, bool>> where, params Expression<Func<SystemLanguageCodePoco, object>>[] navigationProperties)
        {
            IQueryable<SystemLanguageCodePoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params SystemLanguageCodePoco[] items)
        {
            SqlConnection conn = new SqlConnection
                                     (
                                       ConfigurationManager
                                       .ConnectionStrings["dbconnection"]
                                       .ConnectionString);
            using (conn)
            {
                foreach (SystemLanguageCodePoco item in items)
                {
                    SqlCommand cmd = new SqlCommand(
                                                    $"Delete [dbo].System_Language_Codes where LanguageID = @LanguageID", conn);
                    cmd.Parameters.AddWithValue("@LanguageID", item.LanguageID);
                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Update(params SystemLanguageCodePoco[] items)
        {
            SqlConnection conn = new SqlConnection
                                     (
                                       ConfigurationManager
                                       .ConnectionStrings["dbconnection"]
                                       .ConnectionString);
            using (conn)
            {
                foreach (SystemLanguageCodePoco item in items)
                {
                    SqlCommand cmd = new SqlCommand(@"Update [dbo].[System_Language_Codes]
                                                      Set [Name] = @Name,
                                                      [Native_Name] = @Native_Name
                                                      where
                                                      [LanguageID] = @LanguageID", conn);

                    cmd.Parameters.AddWithValue("@Name", item.Name);
                    cmd.Parameters.AddWithValue("@Native_Name", item.NativeName);
                    cmd.Parameters.AddWithValue("@LanguageID", item.LanguageID);

                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
