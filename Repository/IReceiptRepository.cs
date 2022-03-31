using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IReceiptRepository
    {
        int AddReceipt(Receipt receipt);
        int UpdateReceipt(Receipt receipt);
        Task<IEnumerable<Receipt>> GetAllReceipts();
        Task<Receipt> GetReceiptByBookingId(int id);
    }
}
