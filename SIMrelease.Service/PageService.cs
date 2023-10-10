
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
    public interface IPageService
    {
        Page Add(Page page);
        void Update(Page page);
        Page Delete(string id);
        IEnumerable<Page> GetAll();
        IEnumerable<Page> GetAllPagin(int page, int pageSize, int totalRow);
        IEnumerable<Page> GetAllByPagePaging(int PostTagId, int page, int pageSize, out int totalRow);
        IEnumerable<Page> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        Page GetById(string id);
        void SaveChanges();
    }
    public class PageService : IPageService
    {
        public IPageRepository _pageRepository;
        public IUnitOfWork _unitofwork;
        public PageService(IPageRepository pageRepository, IUnitOfWork unitOfWork)
        {
            this._pageRepository = pageRepository;
            this._unitofwork = unitOfWork;
        }
         
        public Page Add(Page page)
        {
            return _pageRepository.Add(page);
        }

        public Page Delete(string id)
        {
            return _pageRepository.Delete(id);
        }

        public IEnumerable<Page> GetAll()
        {
            return _pageRepository.GetAll();
        }

        public IEnumerable<Page> GetAllByPagePaging(int PostTagId, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Page> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Page> GetAllPagin(int page, int pageSize, int totalRow)
        {
            throw new NotImplementedException();
        }

        public Page GetById(string id)
        {
            return _pageRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitofwork.Commit();
        }

        public void Update(Page page)
        {
            _pageRepository.Update(page);
        }
    }
}
