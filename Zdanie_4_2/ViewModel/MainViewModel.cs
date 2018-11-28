using Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Mvvm;
using Zdanie_4_2.Model;
using WarstwaUslug;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace Zdanie_4_2.ViewModel
{
    class MainViewModel : BindableBase
    {
        private ObservableCollection<Klient> klient;
        private ObservableCollection<DaneSzczegolne> dane;
        private Klient obecnyKlient;
        private DaneSzczegolne obecneDane;
        private Data dataLayer;
        

        // DANE KLIENTA
        private string newImieKlienta;
        /// <summary>
        /// Właściwość, Binding NewImieKlienta
        /// </summary>
        public string NewImieKlienta
        {
            get => newImieKlienta;
            set
            {
                newImieKlienta = value;
                RaisePropertyChanged();
            }
        }

        private string newNazwiskoKlienta;
        /// <summary>
        /// Właściwość, Binding NewNazwiskoKienta
        /// </summary>
        public string NewNazwiskoKlienta
        {
            get => newNazwiskoKlienta;
            set
            {
                newNazwiskoKlienta = value;
                RaisePropertyChanged();

            }
        }

        private int newWiekKlienta;
        /// <summary>
        /// Właściwość, Binding NewWiekKLienta
        /// </summary>
        public int NewWiekKlienta
        {
            get => newWiekKlienta;
            set
            {
                newWiekKlienta = value;
                RaisePropertyChanged();
            }
        }


        // DANE SZCZEGOLNE KLIENTA
        private int newKlientID;
        /// <summary>
        /// Właściwość, Binding NewKlientID
        /// </summary>
        public int NewKlientID
        {
            get => newKlientID;
            set
            {
                newKlientID = value;
                RaisePropertyChanged();
            }
        }

        private string newMiasto;
        /// <summary>
        /// Właściwość, Binding NewMiasto
        /// </summary>
        public string NewMiasto
        {
            get => newMiasto;
            set
            {
                newMiasto = value;
                RaisePropertyChanged();
            }
        }

        private string newUlica;
        /// <summary>
        /// właściwość, Binding NewUlica
        /// </summary>
        public string NewUlica
        {
            get => newUlica;
            set
            {
                newUlica = value;
                RaisePropertyChanged();
            }
        }

        private string newNumerMieszkania;
        /// <summary>
        /// właściwość, Binding NewNumerMieszkania
        /// </summary>
        public string NewNumerMieszkania
        {
            get => newNumerMieszkania;
            set
            {
                newNumerMieszkania = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Właściwość, Binding ObecneDaneSzczególne
        /// </summary>
        public DaneSzczegolne ObecneDaneSzczegolne
        {
            get => obecneDane;
            set
            {
                obecneDane = value;
                RaisePropertyChanged();
             
                            
                //ObecnyKlient = klient.First(p => p.IDKlienta == (int)obecneDane.IDKlienta);
            }
        }

        /// <summary>
        /// Właściwość, Binding ObecnyKlient
        /// </summary>
        public Klient ObecnyKlient
        {
            get => obecnyKlient;
            set
            {
                obecnyKlient = value;
                RaisePropertyChanged();
            }
        }




        /// <summary>
        /// Właściwość, ustawia lub zwraca kolekcję danychszeczególnych klienta
        /// </summary>
        public ObservableCollection<DaneSzczegolne> DaneSzczegolneKolekcja
        {
            get => dane;
            set { dane = value; RaisePropertyChanged(); }
        }

        /// <summary>
        /// Właściwość, ustawia lub zwraca kolekcje Klienta
        /// </summary>
        public ObservableCollection<Klient> KlientKolekcja
        {
            get => klient;
            set
            {
                klient = value;
                RaisePropertyChanged();
            }
        }

        /// <summary>
        /// Właściwość data, ustawia kolekcja klienta oraz danych szczególnych klienta
        /// </summary>
        public Data DataLayer
        {
            get => dataLayer;
            set
            {
                dataLayer = value;
                DaneSzczegolneKolekcja = new ObservableCollection<DaneSzczegolne>(value.DaneSzczegolneKolekcja);
                KlientKolekcja = new ObservableCollection<Klient>(value.KlientKolekcja);
            }
        }

        public DelegateCommand GetAllData { get; private set; }
        public DelegateCommand AddDaneSzczegolne { get; private set; }
        public DelegateCommand DeleteDaneSzczegolne { get; private set; }
        public DelegateCommand AddKlientWindowOpen { get; private set; }
        public DelegateCommand AddNewKlient { get; private set; }

        /// <summary>
        /// Konstruktor MeinViewModel
        /// </summary>
        public MainViewModel()
        {

            dataLayer = new Data();
           
            GetAllData = new DelegateCommand(() => DataLayer = new Data());
            AddDaneSzczegolne = new DelegateCommand(AddDane);
            dane = new ObservableCollection<DaneSzczegolne>();
            klient = new ObservableCollection<Klient>();
            DeleteDaneSzczegolne = new DelegateCommand(DeleteDaneSzczegolneMetoda);
            AddKlientWindowOpen = new DelegateCommand(AddKlientWindowOpenExecute);
            AddNewKlient = new DelegateCommand(AddKlient);
            



        }

        /// <summary>
        /// Tworzenie nowegoobiektu i  dodanie go do bazy
        /// </summary>
        private void AddDane()
        {
            if (newMiasto.Length<=50 || newUlica.Length <=50)
            {

                DaneSzczegolne d = new DaneSzczegolne()
                {
                   
                    IDKlienta = newKlientID,
                    Miasto = newMiasto,
                    Ulica = newUlica,
                    NumerMieszkania = newNumerMieszkania
                };

                dane.Add(d);
                Task.Run(() => { DataRepository.CreateDane(d); });


            }
            else MessageBox.Show("Złe dane", "Błąd");

        }


        /// <summary>
        /// Metoda wyświetla okno KLIENTA
        /// </summary>
        private void AddKlientWindowOpenExecute()
        {
            NowyKlient  noweOkno = new NowyKlient();
            noweOkno.Show();
            
        }

        /// <summary>
        /// Metoda wysyłą dane do usunięcia danychszczególnych
        /// </summary>
        private void DeleteDaneSzczegolneMetoda()
        {
            Task.Run(() => { DataRepository.DeleteDaneSzczegilne(ObecneDaneSzczegolne.IDDanychSzczegolnych); });
            dane.Remove(obecneDane);
        }

        /// <summary>
        /// Dodawanie nowego klienta
        /// </summary>
        private void AddKlient()
        {
            if(NewImieKlienta.Length<=50 || newNazwiskoKlienta.Length <= 50)
            {
                Klient k = new Klient()
                {
                    Imie = NewImieKlienta,
                    Nazwisko = NewNazwiskoKlienta,
                    wiek = NewWiekKlienta
                };
                klient.Add(k);
                Task.Run(() => { DataRepository.CreateKlient(k); });
               // noweOkno.Close();

            }
            else MessageBox.Show("Złe dane", "Błąd");
        }



      
 





    }
}
