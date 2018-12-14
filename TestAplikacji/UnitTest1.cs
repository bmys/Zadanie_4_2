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


        [TestMethod()]
        public void GetAllDaneSzczegolne()
        {
            var lista = DataRepository.GetAllDaneSzczegolne().Select(v => v.IDDanychSzczegolnych);

            Assert.AreEqual(3, lista.Count());
            //Podajemy idDanychszczegolnych jakie sa w bazie, id jezeli były 
            //usuwane to nie wypełniają ponownie tych miejsc
            //dlatego takie przeskoki w id
            Assert.IsTrue(lista.Contains(38));
            Assert.IsTrue(lista.Contains(41));
            Assert.IsTrue(lista.Contains(42));
          
        }


        [TestMethod()]
        public void DeleteDaneSzczegolne()
        {
            DaneSzczegolne d = new DaneSzczegolne()
            {

                IDKlienta = 1,
                Miasto = "Wrocław",
                Ulica = "Mieszka",
                NumerMieszkania = "45"
            };


            Assert.AreEqual(DataRepository.GetAllDaneSzczegolne().Count(), 3);
            DataRepository.CreateDane(d);
            Assert.AreEqual(DataRepository.GetAllDaneSzczegolne().Count(), 4);

            int iloscDanych1 = DataRepository.GetAllDaneSzczegolne().Count();
            DataRepository.DeleteDaneSzczegilne(d.IDDanychSzczegolnych);
            int iloscDanych2 = DataRepository.GetAllDaneSzczegolne().Count;
            Assert.AreNotEqual(iloscDanych1, iloscDanych2);
            Assert.AreEqual(DataRepository.GetAllDaneSzczegolne().Count(), 3);
        }




        [TestMethod()]
        public void UpdateTest()
        {
            DaneSzczegolne d = new DaneSzczegolne()
            {

                IDKlienta = 5,
                Miasto = "Kraków",
                Ulica = "Wolczanska",
                NumerMieszkania = "207"
            };

            DataRepository.CreateDane(d);
            Assert.AreEqual(DataRepository.GetAllDaneSzczegolne().Count(), 4);

            d.Miasto = "Częstochowa";

            DataRepository.UpdateDaneSzczegolneKlienta(d);

            List<DaneSzczegolne> ListaDane = DataRepository.GetAllDaneSzczegolne();

            Assert.AreEqual(ListaDane.Last().Miasto, "Częstochowa");
            Assert.AreEqual(ListaDane.Last().IDKlienta, 5);
            Assert.AreEqual(ListaDane.Last().Ulica, "Wolczanska");
            Assert.AreEqual(ListaDane.Last().NumerMieszkania, "207");
            DataRepository.DeleteDaneSzczegilne(d.IDDanychSzczegolnych);
            Assert.AreEqual(DataRepository.GetAllDaneSzczegolne().Count(), 3);
        }






    }
}
