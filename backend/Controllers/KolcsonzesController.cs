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
    public class KolcsonzesController : ApiController
    {
        public HttpResponseMessage Get()                                    //GET metódus kezdete
        {
            string query = @"
                select KolcsID,Tag,
                Kolcsdatuma,
                Visszadatum,
                Media from
                dbo.Kolcsonzes
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


        public string Post(Kolcsonzes kolcs)                                //EZ SEM MEGY......
        {
            try
            {
                string query = @"
                update dbo.Kolcsonzes set
                Tag='" + kolcs.Tag + @"',
                Koclsdatuma='" + kolcs.Kolcsdatuma + @"',
                Visszadatum='" + kolcs.Visszadatum + @"',
                Media='" + kolcs.Media + @"'
                where KolcsID=" + kolcs.KolcsID + @"
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

                return "Ismeretlen hiba a tag felvitele során!";
            }
        }

        public string Put(Kolcsonzes kolcs)                                //EZ SEM MEGY......
        {
            try
            {
                string query = @"
             update dbo.Kolcsonzes set
                Tag='" + kolcs.Tag + @"',
                Kolcsdatum='" + kolcs.Kolcsdatuma + @"',
                Visszadatum='" + kolcs.Visszadatum + @"',
                Media='" + kolcs.Media + @"'
                where KolcsID=" + kolcs.KolcsID + @"
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

                return "Ismeretlen hiba a tag módosítása során!";
            }
        }

        public string Delete(int id)                                //EZ SEM MEGY......
        {
            try
            {
                string query = @"
                delete from dbo.Kolcsonzes
                where KolcsonzesID=" + id + @"
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

                return "Ismeretlen hiba a tag törlése során!";
            }
        }

    }
}
