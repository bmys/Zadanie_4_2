using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarstwaUslug;

namespace Zdanie_4_2.Model
{
    public class Data
    {

        public IEnumerable<Klient> KlientKolekcja
        {
            get
            {
                List<Klient> klient = DataRepository.GetAllKlient();
                return klient;
            }
        }

        public IEnumerable<DaneSzczegolne> DaneSzczegolneKolekcja
        {
            get
            {
                List<DaneSzczegolne> dane = DataRepository.GetAllDaneSzczegolne();
                return dane;
            }
        }


    }
}
