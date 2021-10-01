using dotnetApi.Context;
using dotnetApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace appNetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    {
        private readonly AppDbContext context;
        public PersonasController(AppDbContext context)
        {
            this.context = context;
        }
        // GET: api/<PersonasController>
        [HttpGet]
        
        public ActionResult Get()

        {
            try
            {
                return Ok(context.Persona.ToList());
            } catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // GET api/<PersonasController>/5
        [HttpGet("{id}", Name ="GetPerson")]
        public ActionResult Get(Guid id)
        {
            try
            {
                var person = context.Persona.FirstOrDefault(g => g.Id == id);
                return Ok(person);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // POST api/<PersonasController>
        [HttpPost]
        public ActionResult Post([FromBody] Persona person)
        {
            try
            {
                context.Persona.Add(person);
                context.SaveChanges();
                return CreatedAtRoute("GetPerson", new { Id = person.Id }, person);
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
            
        }

        // PUT api/<PersonasController>/5
        [HttpPut("{id}")]
        public ActionResult Put(Guid id, [FromBody] Persona person)
        {
            try
            {
                if (person.Id == id)
                {

                context.Entry(person).State = EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("GetPerson", new { Id = person.Id }, person);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<PersonasController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(Guid id)
        {
            try
            {
                var person = context.Persona.FirstOrDefault(g => g.Id == id);
                if(person != null)
                {
                    context.Persona.Remove(person);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {

                return BadRequest(ex.Message);
            }
        }
    }
}
