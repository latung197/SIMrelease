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
    public interface IProductService
    {
        Product Add(Product product);
        void Update(Product product);
        Product Delete(string id);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllPagin(int page, int pageSize, int totalRow);
        IEnumerable<Product> GetAllByProductPaging(int PostTagId, int page, int pageSize, out int totalRow);
        IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        Product GetById(string id);
        void SaveChanges();
    }
    public class ProductService : IProductService
    {
        public IProductRepository _productRepository;
        public IUnitOfWork _unitOfWork;
        public ProductService (IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this._productRepository = productRepository;
            this._unitOfWork = unitOfWork;
        }
        public Product Add(Product product)
        {
            return _productRepository.Add(product);
        }

        public Product Delete(string id)
        {
            return _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll();
        }


        public IEnumerable<Product> GetAllByProductPaging(int PostTagId, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Status, out totalRow, page, pageSize);
        }

        public IEnumerable<Product> GetAllPagin(int page, int pageSize, int totalRow)
        {
            throw new NotImplementedException();
        }

        public Product GetById(string id)
        {
            return _productRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
