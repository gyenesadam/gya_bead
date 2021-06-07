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
        public HttpResponseMessage Get()                                    //GET eleje
        {
            string query = @"
                    select KolcsId,Tag,
                    convert(varchar(10),Kolcsdatuma,120) as Kolcsdatuma,
                    convert(varchar(10),Visszadatum,120) as Visszadatum,
                    Media
                    from
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


        }                                                                   //GET vége

        public string Post(Kolcsonzes kolcs)                                //POST eleje
        {
            try
            {
                string query = @"
                    insert into dbo.Kolcsonzes values
                    (
                    '" + kolcs.Tag + @"',
                    '" + kolcs.Kolcsdatuma + @"',
                    '" + kolcs.Visszadatum + @"',
                    '" + kolcs.Media + @"'
                    )
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

                return "Kölcsönzés rögzítve!";
            }
            catch (Exception)
            {

                return "HIBA az adatbázisművelet közben!";
            }
        }                                                                   //POST vége


        public string Put(Kolcsonzes kolcs)                                 //PUT eleje
        {
            try
            {
                string query = @"
                    update dbo.Kolcsonzes set 
                    Tag='" + kolcs.Tag + @"',
                    Kolcsdatuma='" + kolcs.Kolcsdatuma + @"',
                    Visszadatum='" + kolcs.Visszadatum + @"',
                    Media='" + kolcs.Media+ @"'
                    where KolcsId=" + kolcs.KolcsID + @"
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

                return "Kölcsönzési adatok frissítve!";
            }
            catch (Exception)
            {

                return "HIBA az adatbázisművelet közben!";
            }
        }                                                                   //PUT vége


        public string Delete(int id)                                        //DEL eleje
        {
            try
            {
                string query = @"
                    delete from dbo.Kolcsonzes 
                    where KolcsID=" + id + @"
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

                return "Sikeres törlés!";
            }
            catch (Exception)
            {

                return "HIBA az adatbázisművelet közben!";
            }
        }                                                                   //DEL vége
    }
}


