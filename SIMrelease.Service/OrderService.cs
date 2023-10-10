
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simrelease.Data.Infastructure;
using Simrelease.Data.Repositorys;
using Simrelease.Models.Models;

namespace Simrelease.Service
{
    public interface IOrderService
    {
        Order Add(Order Order);
        void Update(Order Order);
        Order Delete(string id);
        IEnumerable<Order> GetAll();
        IEnumerable<Order> GetAllPagin(int page, int pageSize, int totalRow);
        IEnumerable<Order> GetAllByMenuPaging(int OrderId, int page, int pageSize, out int totalRow);
        IEnumerable<Order> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        Order GetById(string id);
        void SaveChanges();
    }
    public class OrderService : IOrderService
    {
        public IOrderRepository _orderRepository;
        public IUnitOfWork _unitOfwork;

        public OrderService(IOrderRepository orderRepository, IUnitOfWork unitOfWork)
        {
            this._orderRepository = orderRepository;
            this._unitOfwork = unitOfWork;
        }
        public Order Add(Order order)
        {
            return _orderRepository.Add(order);
        }

        public Order Delete(string id)
        {
            return _orderRepository.Delete(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public IEnumerable<Order> GetAllByMenuPaging(int OrderId, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllPagin(int page, int pageSize, int totalRow)
        {
            return _orderRepository.GetMultiPaging(x => x.Status, out totalRow, pageSize);
        }

        public Order GetById(string id)
        {
            return _orderRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfwork.Commit();
        }

        public void Update(Order order)
        {
            _orderRepository.Update(order);
        }
    }
}
