using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Tests
{
    [TestClass()]
    public class ClientsTests
    {
        [TestMethod()]
        public void TestMethod1_insClTest_ok()
        {
            ISS_Turfirm.Clients = new ISS_Turfirm.Clients()
            Assert.Fail();
        }
    }
}

namespace ISS_TurfimTests
{
    class ClientsTests
    {
    }
}
