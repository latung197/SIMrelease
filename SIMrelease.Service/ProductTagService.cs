
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
    public interface IProductTagService
    {
        ProductTag Add(ProductTag productTag);
        void Update(ProductTag productTag);
        ProductTag Delete(string id);
        IEnumerable<ProductTag> GetAll();
        IEnumerable<ProductTag> GetAllPagin(int page, int pageSize, int totalRow);
        IEnumerable<ProductTag> GetAllByCategoryPaging(string productTagID, int page, int pageSize, out int totalRow);
        IEnumerable<ProductTag> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        ProductTag GetById(string id);
        void SaveChanges();
    }
    public class ProductTagService : IProductTagService
    {
        IProductTagRepository _productTagRepository;
        IUnitOfWork _unitOfWork;
        public ProductTagService(IProductTagRepository productTagRepository, IUnitOfWork unitOfWork)
        {
            this._productTagRepository = productTagRepository;
            this._unitOfWork = unitOfWork;
        }
        public ProductTag Add(ProductTag productTag)
        {
            return _productTagRepository.Add(productTag);
        }

        public ProductTag Delete(string id)
        {
            return _productTagRepository.Delete(id);
        }

        public IEnumerable<ProductTag> GetAll()
        {
            return _productTagRepository.GetAll();
        }

        public IEnumerable<ProductTag> GetAllByCategoryPaging(string productTagID, int page, int pageSize, out int totalRow)
        {
            return _productTagRepository.GetMultiPaging(x => x.Product_ID == productTagID, out totalRow, page, pageSize);
        }

        public IEnumerable<ProductTag> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductTag> GetAllPagin(int page, int pageSize, int totalRow)
        {
            return _productTagRepository.GetMultiPaging(x=>x.Product_ID == x.Product_ID, out totalRow, page, pageSize);
        }

        public ProductTag GetById(string id)
        {
            return _productTagRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductTag productTag)
        {
            _productTagRepository.Update(productTag);
        }

    }
}
