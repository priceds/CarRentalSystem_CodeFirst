using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IReceiptService
    {
        int AddReceipt(Receipt receipt);
        int UpdateReceipt(Receipt receipt);
        Task<IEnumerable<Receipt>> GetAllReceipts();
        Task<Receipt> GetReceiptByBookingId(int id);
    }
}
