using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simrelease.Data.Infastructure;
using Simrelease.Models.Models;
namespace Simrelease.Data.Repositorys
{
    public interface IOrderRepository : IRepository<Order>
    {

    }
    public class OrderRepository :RepositoryBase<Order>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }

    }
}
