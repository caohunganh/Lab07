using Lab07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab07.Controllers
{
    public class SachController : ApiController
    {
        Sach[] sachs = new Sach[]
        {
            new Sach {Id = 1, Title ="Toi thay hoa vang tren co xanh",AuthorName=
            "Nguyen Nhat Anh", Price = 1, Content = "Truyen ke ve Tuoi tho..."},

            new Sach {Id=2, Title="Pro ASP.NET MVC5", AuthorName="Adam Freeman ",
            Content="The ASP.NET MVC 5 Framework is the latest evolution of Microsoft's ASP.NET web platform.",Price= 3.75M},
        };
        public IEnumerable<Sach>GetAll()
        {
            return sachs;
        }
        public IHttpActionResult GetSach(int id)
        {
            var sach = sachs.FirstOrDefault((p)=> p.Id == id);
            if (sach ==null)
            {
                return NotFound();

            }
            return Ok(sach);
        }
    }
}
