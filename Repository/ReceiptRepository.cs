using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ReceiptRepository : IReceiptRepository
    {
        private readonly CarRentalDbContext _context;
        public ReceiptRepository(CarRentalDbContext context)
        {
            _context = context;
        }
        public int AddReceipt(Receipt receipt)
        {
            _context.Receipts.Add(receipt);
            return _context.SaveChanges();
        }

        public async Task<IEnumerable<Receipt>> GetAllReceipts()
        {
            return await _context.Receipts.ToListAsync();
        }

        public async Task<Receipt> GetReceiptByBookingId(int id)
        {
            return await _context.Receipts.Where(receipt => receipt.BookingId == id).SingleOrDefaultAsync();
        }

        public int UpdateReceipt(Receipt receipt)
        {
            throw new NotImplementedException();
        }
    }
}
