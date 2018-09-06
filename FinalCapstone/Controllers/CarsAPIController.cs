using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Cars.Data;
using FinalCapstone.Models;

namespace FinalCapstone.Controllers
{
    public class CarsAPIController : ApiController
    {
        private CarDbContext db = new CarDbContext();

        // GET: api/CarsAPI
        public IQueryable<Car> GetCars()
        {
            return db.Cars;
        }

        // GET: api/CarsAPI/5
        [ResponseType(typeof(Car))]
        public IHttpActionResult GetCar(int id)
        {
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return NotFound();
            }
            return Ok(car);
        }
        public IQueryable<Car> GetColor(string color)
        {
            return db.Cars.Where(x => x.Color == color);
        }

        public IQueryable<Car> GetModel(string model)
        {
            return db.Cars.Where(x => x.Model == model);
        }

        public IQueryable<Car> GetMake(string make)
        {
            return db.Cars.Where(x => x.Make == make);
        }

        public IQueryable<Car> GetYear(int year)
        {
            return db.Cars.Where(x => x.Year == year);
        }

        // PUT: api/CarsAPI/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCar(int id, Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != car.Id)
            {
                return BadRequest();
            }

            db.Entry(car).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/CarsAPI
        [ResponseType(typeof(Car))]
        public IHttpActionResult PostCar(Car car)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cars.Add(car);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = car.Id }, car);
        }

        // DELETE: api/CarsAPI/5
        [ResponseType(typeof(Car))]
        public IHttpActionResult DeleteCar(int id)
        {
            Car car = db.Cars.Find(id);
            if (car == null)
            {
                return NotFound();
            }

            db.Cars.Remove(car);
            db.SaveChanges();

            return Ok(car);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CarExists(int id)
        {
            return db.Cars.Count(e => e.Id == id) > 0;
        }
    }
}