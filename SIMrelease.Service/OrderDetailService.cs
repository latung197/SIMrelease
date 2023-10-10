
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
    public interface IOrderDetailService
    {
        OrderDetail Add(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        OrderDetail Delete(string id);
        IEnumerable<OrderDetail> GetAll();
        IEnumerable<OrderDetail> GetAllPagin(int page, int pageSize, int totalRow);
        IEnumerable<OrderDetail> GetAllByPaging(int PostTagId, int page, int pageSize, out int totalRow);
        IEnumerable<OrderDetail> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        OrderDetail GetById(string id);
        void SaveChanges();

    }
    public class OrderDetailService: IOrderDetailService
    {
        public IOrderDetailRepository _orderDetailRepository;
        public IUnitOfWork _unitOfwork;

        public OrderDetailService(IOrderDetailRepository orderDetailRepository, IUnitOfWork unitOfWork)
        {
            this._orderDetailRepository = orderDetailRepository;
            this._unitOfwork = unitOfWork;
        }
        public OrderDetail Add(OrderDetail orderDetail)
        {
            return _orderDetailRepository.Add(orderDetail);
        }

        public OrderDetail Delete(string id)
        {
            return _orderDetailRepository.Delete(id);
        }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _orderDetailRepository.GetAll();
        }

        public IEnumerable<OrderDetail> GetAllByPaging(int PostTagId, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetail> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderDetail> GetAllPagin(int page, int pageSize, int totalRow)
        {
            return _orderDetailRepository.GetMultiPaging(x => x.Order_ID == x.Order_ID, out totalRow, pageSize);
        }

        public OrderDetail GetById(string id)
        {
            return _orderDetailRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfwork.Commit();
        }

        public void Update(OrderDetail orderDetail)
        {
            _orderDetailRepository.Update(orderDetail);
        }
    }
}
