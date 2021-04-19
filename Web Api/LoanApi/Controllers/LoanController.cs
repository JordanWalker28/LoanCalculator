using LoanApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoanApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoanController : ControllerBase
    {
        private readonly LoanContext _context;

        public LoanController(LoanContext context)
        {
            _context = context;
        }

        [HttpGet("/api/loans")]
        public async Task<ActionResult<IEnumerable<Loan>>> GetLoans()
        {
            return await _context.Loans.ToListAsync();
        }

        [HttpGet("/api/loans/{id}")]
        public async Task<ActionResult<Loan>> GetLoan(long id)
        {
            var loan = await _context.Loans.FindAsync(id);

            if (loan == null)
            {
                return NotFound();
            }

            return loan;
        }

        [HttpPost("/api/loans")]
        public async Task<ActionResult<Loan>> PostLoan(Loan loan)
        {
            _context.Loans.Add(loan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLoan", new { id = loan.Id }, loan);
        }

        [HttpDelete("/api/loans/{id}")]
        public async Task<ActionResult<Loan>> DeleteLoan(long id)
        {
            var loan = await _context.Loans.FindAsync(id);
            if (loan == null)
            {
                return NotFound();
            }

            _context.Loans.Remove(loan);
            await _context.SaveChangesAsync();

            return loan;
        }
    }
}
