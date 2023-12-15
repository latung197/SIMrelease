using Microsoft.VisualStudio.TestTools.UnitTesting;
using Simrelease.Data.Infastructure;
using Simrelease.Data.Repositorys;
using Simrelease.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simrelease.UniTest.RepositoryTest
{
    [TestClass]
    public class DmkhRepositoryTest
    {
        IDbFactory dbFactory;
        IDmkhRepository objRepository;
        IUnitOfWork unitOfWork;

        [TestInitialize]
        public void Initialize()
        {
            dbFactory = new DbFactory();
            objRepository = new DmkhRepository(dbFactory);
            unitOfWork = new UnitOfwork(dbFactory);
        }

        [TestMethod]
        public void Dmkh_Repository_Create()
        {
            Dmkh dmkh = new Dmkh();
            dmkh.Ma_kh = "0";
            dmkh.Ten_kh = "Test category";
            dmkh.nh_kh1 = "Test-category";
            dmkh.Status = true;
            var result = objRepository.Add(dmkh);
            unitOfWork.Commit();
            Assert.IsNotNull(result);
            Assert.AreEqual(4, result.Ma_kh);
        }
    }
}
