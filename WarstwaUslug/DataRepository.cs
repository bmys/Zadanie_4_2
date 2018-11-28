using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarstwaUslug
{
    public class DataRepository
    {
        private static DataBaseDataContext dataContext = new DataBaseDataContext();

        public static DataBaseDataContext DataContext
        {
            get => dataContext;
            set => dataContext = value;
        }

        /// <summary>
        /// Dodawanie do bazy obiektu insert
        /// </summary>
        /// <param name="dane"></param>
        public static void CreateDane(DaneSzczegolne dane)
        {
            dataContext.DaneSzczegolne.InsertOnSubmit(dane);
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }
        /// <summary>
        /// Dodawanie do bazy obiektu insert
        /// </summary>
        /// <param name="dane"></param>
        public static void CreateKlient(Klient dane)
        {
            dataContext.Klient.InsertOnSubmit(dane);
            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }


        /// <summary>
        /// Select z bazy Danychszczegolnych klienta
        /// </summary>
        /// <returns></returns>
        public static List<DaneSzczegolne> GetAllDaneSzczegolne()
        {
            List<DaneSzczegolne> dane = (from daneSzczegolne in dataContext.DaneSzczegolne
                                           select daneSzczegolne).ToList();

            return dane;
        }

        /// <summary>
        /// select z bazy klientów
        /// </summary>
        /// <returns></returns>
        public static List<Klient> GetAllKlient()
        {
            List<Klient> klient = (from klients in dataContext.Klient
                                      select klients).ToList();
            return klient;
        }

        /// <summary>
        /// usuwanie danych z bazy
        /// </summary>
        /// <param name="id"></param>
        public static void DeleteDaneSzczegilne(int id)
        {
            var danedelete =
                (from dane in dataContext.DaneSzczegolne
                 where dane.IDDanychSzczegolnych == id
                 select dane).First();

            if (danedelete != null)
            {
                DataContext.DaneSzczegolne.DeleteOnSubmit(danedelete);
            }

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception e)
            {

            }
        }


        public static void UpdateDaneSzczegolneKlienta(DaneSzczegolne dane)
        {
            DaneSzczegolne daneDoZmiany = dataContext.DaneSzczegolne.Single(r => r.IDDanychSzczegolnych == dane.IDDanychSzczegolnych);


            daneDoZmiany.IDKlienta = dane.IDKlienta;
            daneDoZmiany.Miasto = dane.Miasto;
            daneDoZmiany.Ulica = dane.Ulica;
            daneDoZmiany.NumerMieszkania = dane.NumerMieszkania;

            try
            {
                dataContext.SubmitChanges();
            }
            catch (Exception)
            {

                
            }
        }
  


    }
}
