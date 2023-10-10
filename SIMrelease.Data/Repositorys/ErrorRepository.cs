using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simrelease.Data.Infastructure;
using Simrelease.Models.Models;
namespace Simrelease.Data.Repositorys
{
    public interface IErrorRepository: IRepository<Error>
    {

    }
    public class ErrorRepository:RepositoryBase<Error>,IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory):base(dbFactory)
        {

        }
    }
}
