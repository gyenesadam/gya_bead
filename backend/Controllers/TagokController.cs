using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace backend.Controllers
{
    public class TagokController : ApiController
    {
        public HttpResponseMessage Get()
        {
            string query = @"
                select TagID,Nev,SZIG,IR,Cim,Statusz from
                dbo.Tagok
                ";
            DataTable table = new DataTable();

        }
    }
}
