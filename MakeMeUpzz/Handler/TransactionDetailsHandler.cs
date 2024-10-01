using MakeMeUpzz.Factory;
using MakeMeUpzz.Models;
using MakeMeUpzz.Repository;
using System.Collections.Generic;

namespace MakeMeUpzz.Handlers
{
    public class DetailHandler
    {
        private readonly TransDetailRepo _transactionDetailRepo;

        public DetailHandler()
        {
            _transactionDetailRepo = new TransDetailRepo();
        }

        public void InsertDetail(int tid, int mid, int quantity)
        {
            _transactionDetailRepo.InsertDetail(tid, mid, quantity);
        }

        public List<TransactionDetail> GetAllTransactionDetails()
        {
            return _transactionDetailRepo.GetLLTransDetails();
        }
        public List<TransactionDetail> FindByTransactionId(int tid)
        {
            return _transactionDetailRepo.SearchTransId(tid);
        }
    }
}
