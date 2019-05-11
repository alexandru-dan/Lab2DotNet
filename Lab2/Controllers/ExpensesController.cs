using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class ExpensesController : Controller
    {
        private IntroDbContext context; 

        public ExpensesController(IntroDbContext context)
        {
            this.context = context;
        }

        // GET: api/Expenses
        [HttpGet]
        public IEnumerable<Expenses> Get()
        {
            return context.Expenses;
        }

        // GET: api/Expenses/5
        [HttpGet("{id}", Name = "Get")]
        public Expenses Get(int id)
        {
            return context.Expenses.FirstOrDefault(c => c.Id == id);
        }
       
        // POST: api/Expenses
        [HttpPost]
        public IActionResult Post([FromBody] Expenses expenses)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            context.Expenses.Add(expenses);
            context.SaveChanges();
            return Ok();
        }

        // PUT: api/Expenses/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Expenses expenses)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var existing = context.Expenses.FirstOrDefault(c => c.Id == id);
            if (existing != null)
            {
                expenses.Id = existing.Id;
                context.Expenses.Remove(existing);
            }

            context.Expenses.Add(expenses);
            context.SaveChanges();
            return Ok();
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var found = context.Expenses.FirstOrDefault(c => c.Id == id);
            if (found == null)
            {
                return NotFound();
            }

            context.Expenses.Remove(found);
            context.SaveChanges();
            return Ok();
        }
    }
}