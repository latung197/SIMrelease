using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simrelease.Data.Infastructure
{
    public class UnitOfwork : IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        private SimDbcontext dbContext;
        public UnitOfwork (IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public SimDbcontext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }
        public void Commit()
        {
            DbContext.SaveChanges();
        }
    }
}
