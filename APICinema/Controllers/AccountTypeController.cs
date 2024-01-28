using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using APICinema.Models;

namespace APICinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountTypeController : ControllerBase
    {
        private readonly AccountTypeContext _context;

        public AccountTypeController(AccountTypeContext context)
        {
            _context = context;
        }

        // GET: api/AccountType
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountType>>> GetAccountTypes()
        {
            return await _context.AccountTypes.ToListAsync();
        }

        // GET: api/AccountType/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccountType>> GetAccountType(int id)
        {
            var accountType = await _context.AccountTypes.FindAsync(id);

            if (accountType == null)
            {
                return NotFound();
            }

            return accountType;
        }

        // PUT: api/AccountType/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccountType(int id, AccountType accountType)
        {
            if (id != accountType.AccountId)
            {
                return BadRequest();
            }

            _context.Entry(accountType).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccountTypeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AccountType
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AccountType>> PostAccountType(AccountType accountType)
        {
            _context.AccountTypes.Add(accountType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAccountType", new { id = accountType.AccountId }, accountType);
        }

        // DELETE: api/AccountType/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccountType(int id)
        {
            var accountType = await _context.AccountTypes.FindAsync(id);
            if (accountType == null)
            {
                return NotFound();
            }

            _context.AccountTypes.Remove(accountType);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AccountTypeExists(int id)
        {
            return _context.AccountTypes.Any(e => e.AccountId == id);
        }
    }
}
