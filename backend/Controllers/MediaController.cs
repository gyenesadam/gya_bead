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
    public class MediaController : ApiController
    {
        public HttpResponseMessage Get()                                    //GET metódus kezdete
        {
            string query = @"
                select mediaID,Mediatipus,Cim,Szerzo from
                dbo.Media
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
            return Request.CreateResponse(HttpStatusCode.OK, table);
        }                                                                   //GET metódus vége


        public string Post(Media med)                                       //MAGYAROSÍTANI!!!!
        {
            try
            {
                string query = @"
                insert into dbo.Media values
                ('" + med.Mediatipus + @"',
                '" + med.Cim + @"',
                '" + med.Szerzo + @"')
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

        public string Put(Media medi)
        {
            try
            {
                string query = @"
                    update dbo.Media set 
                    Mediatipus='" + medi.Mediatipus + @"'
                    ,Cim='" + medi.Cim + @"'
                    ,Szerzo='" + medi.Szerzo + @"'
                    where mediaID=" + medi.mediaID + @"
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

                return "Média adatai frissültek!";
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
                delete from dbo.Media
                where mediaID=" + id + @"
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
                return "Média törlése sikeres!";
            }
            catch (Exception)
            {

                return "HIBA az adatbázisművelet közben!";
            }
        }

    }
}
