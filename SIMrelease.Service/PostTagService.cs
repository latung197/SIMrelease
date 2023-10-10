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
    public interface IPostTagService
    {
        PostTag Add(PostTag postTag);
        void Update(PostTag postTag);
        PostTag Delete(string id);
        IEnumerable<PostTag> GetAll();
        IEnumerable<PostTag> GetAllPagin(int page, int pageSize, int totalRow);
        IEnumerable<PostTag> GetAllByCategoryPaging(int PostTagId, int page, int pageSize, out int totalRow);
        IEnumerable<PostTag> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow);
        PostTag GetById(string id);
        void SaveChanges();
    }

    public class PostTagService : IPostTagService
    {
        IPostTagRepository _postTagRepository;
        IUnitOfWork _unitOfWork;
        public PostTagService(IPostTagRepository postTagRepository, IUnitOfWork unitOfWork)
        {
            this._postTagRepository = postTagRepository;
            this._unitOfWork = unitOfWork;
        }

        public PostTag Add(PostTag postTag)
        {
            return _postTagRepository.Add(postTag);
        }

        public PostTag Delete(string id)
        {
            return _postTagRepository.Delete(id);
        }

        public IEnumerable<PostTag> GetAll()
        {
            return _postTagRepository.GetAll();
        }

        public IEnumerable<PostTag> GetAllByCategoryPaging(int PostTagId, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostTag> GetAllByTagPaging(string tag, int page, int pageSize, out int totalRow)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PostTag> GetAllPagin(int page, int pageSize, int totalRow)
        {
            throw new NotImplementedException();
        }

        public PostTag GetById(string id)
        {
            return _postTagRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostTag postTag)
        {
            _postTagRepository.Update(postTag);
        }
    }
}
