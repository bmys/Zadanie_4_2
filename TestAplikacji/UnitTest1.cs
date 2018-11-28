using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Zdanie_4_2;
using WarstwaUslug;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAplikacji
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataBaseDataContext dataContext = new DataBaseDataContext();
        }
    }
}
