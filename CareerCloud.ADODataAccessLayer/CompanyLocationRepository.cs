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
    public class CompanyLocationRepository : IDataRepository<CompanyLocationPoco>
    {
        public void Add(params CompanyLocationPoco[] items)
        {
            SqlConnection conn = new SqlConnection
                                     (
                                       ConfigurationManager
                                       .ConnectionStrings["dbconnection"]
                                       .ConnectionString);
            using (conn)
            {
                foreach (CompanyLocationPoco item in items)
                {
                    SqlCommand cmd = new SqlCommand(
                                                     @"Insert into [dbo].[Company_Locations]
                                                       ([Id],[Company],[Country_Code],[State_Province_Code],[Street_Address],[City_Town],[Zip_Postal_Code])
                                                       values
                                                      (@Id,@Company,@Country_Code,@State_Province_Code,@Street_Address,@City_Town,@Zip_Postal_Code)", conn);

                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    cmd.Parameters.AddWithValue("@Company", item.Company);
                    cmd.Parameters.AddWithValue("@Country_Code", item.CountryCode);
                    cmd.Parameters.AddWithValue("@State_Province_Code", item.Province);
                    cmd.Parameters.AddWithValue("@Street_Address", item.Street);
                    cmd.Parameters.AddWithValue("@City_Town", item.City);
                    cmd.Parameters.AddWithValue("@Zip_Postal_Code", item.PostalCode);

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

        public IList<CompanyLocationPoco> GetAll(params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
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
                                            [Company],
                                            [Country_Code],
                                            [State_Province_Code],
                                            [Street_Address],
                                            [City_Town],
                                            [Zip_Postal_Code],
                                            [Time_Stamp]
                                            FROM [JOB_PORTAL_DB].[dbo].[Company_Locations]", conn);
                conn.Open();
                int x = 0;
                SqlDataReader rdr = cmd.ExecuteReader();
                CompanyLocationPoco[] appPocos = new CompanyLocationPoco[1000];
                while (rdr.Read())
                {
                    CompanyLocationPoco poco = new CompanyLocationPoco();
                    poco.Id = rdr.GetGuid(0);
                    poco.Company = rdr.GetGuid(1);
                    poco.CountryCode = rdr.GetString(2);
                    poco.Province = (String)(rdr.IsDBNull(3) ? null : rdr[3]);
                    poco.Street = (String)(rdr.IsDBNull(4) ? null : rdr[4]);
                    poco.City = (String)(rdr.IsDBNull(5) ? null : rdr[5]);
                    poco.PostalCode = (String)(rdr.IsDBNull(6) ? null : rdr[6]);
                    poco.TimeStamp = (Byte[])rdr[7];

                    appPocos[x] = poco;
                    x++;

                }
                conn.Close();

                return appPocos.Where(a => a != null).ToList();
            }
        }

        public IList<CompanyLocationPoco> GetList(Expression<Func<CompanyLocationPoco, bool>> where, params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            throw new NotImplementedException();
        }

        public CompanyLocationPoco GetSingle(Expression<Func<CompanyLocationPoco, bool>> where, params Expression<Func<CompanyLocationPoco, object>>[] navigationProperties)
        {
            IQueryable<CompanyLocationPoco> pocos = GetAll().AsQueryable();
            return pocos.Where(where).FirstOrDefault();
        }

        public void Remove(params CompanyLocationPoco[] items)
        {
            SqlConnection conn = new SqlConnection
                                     (
                                       ConfigurationManager
                                       .ConnectionStrings["dbconnection"]
                                       .ConnectionString);
            using (conn)
            {
                foreach (CompanyLocationPoco item in items)
                {
                    SqlCommand cmd = new SqlCommand(
                                                    $"Delete [dbo].Company_Locations where Id = @Id", conn);
                    cmd.Parameters.AddWithValue("@Id", item.Id);
                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }

        public void Update(params CompanyLocationPoco[] items)
        {
            SqlConnection conn = new SqlConnection
                                     (
                                       ConfigurationManager
                                       .ConnectionStrings["dbconnection"]
                                       .ConnectionString);
            using (conn)
            {
                foreach (CompanyLocationPoco item in items)
                {
                    SqlCommand cmd = new SqlCommand(@"Update [dbo].[Company_Locations]
                                                      Set [Company] = @Company,
                                                      [Country_Code] = @Country_Code,
                                                      [State_Province_Code] = @State_Province_Code,
                                                      [Street_Address] = @Street_Address,
                                                      [City_Town] = @City_Town,
                                                      [Zip_Postal_Code] = @Zip_Postal_Code
                                                       where
                                                      [Id] = @Id", conn);

                    cmd.Parameters.AddWithValue("@Company", item.Company);
                    cmd.Parameters.AddWithValue("@Country_Code", item.CountryCode);
                    cmd.Parameters.AddWithValue("@State_Province_Code", item.Province);
                    cmd.Parameters.AddWithValue("@Street_Address", item.Street);
                    cmd.Parameters.AddWithValue("@City_Town", item.City);
                    cmd.Parameters.AddWithValue("@Zip_Postal_Code", item.PostalCode);
                    cmd.Parameters.AddWithValue("@Id", item.Id);

                    conn.Open();
                    int rowEffected = cmd.ExecuteNonQuery();
                    conn.Close();
                }
            }
        }
    }
}
