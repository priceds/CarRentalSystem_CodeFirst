using Entities.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ReceiptService:IReceiptService
    {
        private readonly IReceiptRepository _receiptRepository;
        public ReceiptService(IReceiptRepository receiptRepository)
        {
            _receiptRepository = receiptRepository;
        }

        public int AddReceipt(Receipt receipt)
        {
            return _receiptRepository.AddReceipt(receipt);
        }

        public Task<IEnumerable<Receipt>> GetAllReceipts()
        {
            return _receiptRepository.GetAllReceipts();
        }

        public Task<Receipt> GetReceiptByBookingId(int id)
        {
            return _receiptRepository.GetReceiptByBookingId(id);
        }

        public int UpdateReceipt(Receipt receipt)
        {
            return _receiptRepository.UpdateReceipt(receipt);
        }
    }
}
