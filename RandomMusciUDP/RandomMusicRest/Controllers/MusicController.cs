using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RandomMusicRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicController : ControllerBase
    {
        private static List<sangpart> spList = new List<sangpart>()
        {
            new sangpart(1,1,"13:10.01"),
            new sangpart(2,1,"13:15.01"),
            new sangpart(2,2,"13:14.10"),
            new sangpart(3,3,"13:18.01"),
            
        };
       
        // GET: api/Music
        [HttpGet]
        public IEnumerable<sangpart> GetAllSp()
        {
            return spList;
        }

        // GET: api/Music/5
        [HttpGet("{id}", Name = "GetOne")]
        public sangpart Get(int id)
        {
            foreach (var sp in spList)
            {
                if (sp.sangid==id)
                {
                    return sp;
                }
            }

            return null;
        }

        // POST: api/Music
        [HttpPost]
        public void Post([FromBody] sangpart newSP)
        {
            spList.Add(newSP);
        }

        // PUT: api/Music/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
