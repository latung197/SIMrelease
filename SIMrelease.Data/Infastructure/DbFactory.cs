using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simrelease.Data.Infastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private SimDbcontext dbcontext;
        public SimDbcontext Init()
        {
            return dbcontext ?? (dbcontext = new SimDbcontext());
        }
        protected override void DisposeCore()
        {
            if(dbcontext != null)
            {
                dbcontext.Dispose();
            }
            
        }
    }
}
