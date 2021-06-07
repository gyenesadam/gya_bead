using backend.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backend.Controllers
{
    public class TagokController : ApiController
    {
        public HttpResponseMessage Get()                                    //GET metódus kezdete
        {
            string query = @"
                select TagID,Nev,SZIG,IR,Cim,Statusz from
                dbo.Tagok
                ";
            DataTable table = new DataTable();
            using (var con = new SqlConnection(ConfigurationManager.
            ConnectionStrings["gyaDBconn"].ConnectionString))
            using (var cmd = new SqlCommand(query,con))
            using (var da = new SqlDataAdapter(cmd))
            {
                cmd.CommandType = CommandType.Text;
                da.Fill(table);
            }
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }                                                                   //GET metódus vége


        public string Post(Tagok tag)      
        {
            try
            {
                string query = @"
                insert into dbo.Tagok values
                ('"+tag.Nev+ @"',
                '" + tag.SZIG + @"',
                '" + tag.IR + @"',
                '" + tag.Cim + @"',
                '" + tag.Statusz + @"')
                ";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["gyaDBconn"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }
                return "Tag hozzáadása sikeres!";
            }
            catch (Exception)
            {

                return "HIBA az adatbázisművelet közben!";
            }
        }

        public string Put(Tagok tag)
        {
            try
            {
                string query = @"
                update dbo.Tagok set
                Nev='" + tag.Nev + @"',
                SZIG='" + tag.SZIG + @"',
                IR='" + tag.IR + @"',
                Cim='" + tag.Cim + @"',
                Statusz='" + tag.Statusz + @"'
                where TagID=" + tag.TagID + @"
                ";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["gyaDBconn"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }
                return "Tag módosítása sikeres!";
            }
            catch (Exception)
            {

                return "HIBA az adatbázisművelet közben!";
            }
        }

        public string Delete(int id)                                         
        {
            try
            {
                string query = @"
                update dbo.Tagok set                      
                Statusz='PASSZÍV'
                where TagID=" + id + @"
                ";

                DataTable table = new DataTable();
                using (var con = new SqlConnection(ConfigurationManager.
                ConnectionStrings["gyaDBconn"].ConnectionString))
                using (var cmd = new SqlCommand(query, con))
                using (var da = new SqlDataAdapter(cmd))
                {
                    cmd.CommandType = CommandType.Text;
                    da.Fill(table);
                }
                return "Tag törlése sikeres!";
            }
            catch (Exception)
            {

                return "HIBA az adatbázisművelet közben!";
            }
        }

                                /* DELETE metódus mentése
                                        public string Delete(int id)                                          //EZ TÖRÖL, DE CSAK a STÁTUSZT KELLENE PASSZÍVRA ÍRNI!!!!!
                                {
                                    try
                                    {
                                        string query = @"
                                        delete from dbo.Tagok
                                        where TagID=" + id + @"
                                        ";

                                        DataTable table = new DataTable();
                                        using (var con = new SqlConnection(ConfigurationManager.
                                        ConnectionStrings["gyaDBconn"].ConnectionString))
                                        using (var cmd = new SqlCommand(query, con))
                                        using (var da = new SqlDataAdapter(cmd))
                                        {
                                            cmd.CommandType = CommandType.Text;
                                            da.Fill(table);
                                        }
                                        return "Tag törlése sikeres!";
                                    }
                                    catch (Exception)
                                    {

                                        return "HIBA az adatbázisművelet közben!";
                                    }
                                } */

    }
}
