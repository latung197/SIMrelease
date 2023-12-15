using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Simrelease.Data.Infastructure;
using Simrelease.Models.Models;

namespace Simrelease.Data.Repositorys
{
    public interface IDmkhRepository: IRepository<Dmkh>
    {

    }
    public class DmkhRepository: RepositoryBase<Dmkh>, IDmkhRepository
    {
        public DmkhRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
