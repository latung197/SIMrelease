
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
    public interface IFooterService
    {
        Footer Create(Footer footer);
        void Update(Footer footer);
        void Save();

    }
    public class FooterService : IFooterService
    {
        IFooterRepository _footerRepository;
        IUnitOfWork _unitOfwork;
        public FooterService(IFooterRepository footerRepository, IUnitOfWork unitOfWork)
        {
            this._footerRepository = footerRepository;
            this._unitOfwork = unitOfWork;
        }

        public Footer Create(Footer footer)
        {
            return _footerRepository.Add(footer);
        }

        public void Save()
        {
            _unitOfwork.Commit();
        }

        public void Update(Footer footer)
        {
            _footerRepository.Update(footer);
        }
    }
}
