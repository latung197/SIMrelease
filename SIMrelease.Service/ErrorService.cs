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
    public interface IErrorService
    {
        Error Create(Error error);
        void Save();
    }
    public class ErrorService : IErrorService
    {
        IErrorRepository _errorRepository;
        IUnitOfWork _unitOfwork;

        public ErrorService(IUnitOfWork unitOfwork, IErrorRepository errorRepository)
        {
            this._errorRepository = errorRepository;
            this._unitOfwork = unitOfwork;
        }
        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }
        public void Save()
        {
            _unitOfwork.Commit();
        }
    }
}
