using System.Collections.Generic;
using System.Linq;
using ParksAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;

namespace ParksAPI.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/parks")]
    [ApiController]
    public class ParksV1Controller : ControllerBase
    {
        private ParksAPIContext _db;
        public ParksV1Controller(ParksAPIContext db)
        {
            _db = db;
        }

        //GET api/parks
        [HttpGet]
        public ActionResult<IEnumerable<Park>> GetAction(int parkId, string parkLocation, string parkName, string description)
        {
            var query = _db.Parks.AsQueryable();

            if (parkId != 0)
            {
                query = query.Where(entry => entry.ParkId == parkId);
            }

            if (parkLocation != null)
            {
                query = query.Where(entry => entry.ParkLocation == parkLocation);
            }

            if (parkName != null)
            {
                query = query.Where(entry => entry.ParkName == parkName);
            }

            if (description != null)
            {
                query = query.Where(entry => entry.Description == description);
            }
            return query.ToList();
        }

        [ApiVersion("2.0")]
        [EnableCors("AnotherPolicy")]
        [Route("api/{v:ApiVersion}/parks")]
        [ApiController]
        public class ParksV2Controller : ControllerBase
        {
            private ParksAPIContext _db;
            public ParksV2Controller(ParksAPIContext db)
            {
                _db = db;
            }

            // POST api/parks
            [HttpPost]
            public void Post([FromBody] Park park)
            {
                _db.Parks.Add(park);
                _db.SaveChanges();
            }

            //GET api/parks
            [HttpGet("{id}")]
            public ActionResult<Park> Get(int id)
            {
                return _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
            }

            //PUT api/park/3
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] Park park)
            {
                park.ParkId = id;
                _db.Entry(park).State = EntityState.Modified;
                _db.SaveChanges();
            }

            //DELETE api/park/3
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
                var parkToDelete = _db.Parks.FirstOrDefault(entry => entry.ParkId == id);
                _db.Parks.Remove(parkToDelete);
                _db.SaveChanges();
            }
        }
    }
}
