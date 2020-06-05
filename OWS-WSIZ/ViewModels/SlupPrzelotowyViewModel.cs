using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using OWS_WSIZ.Models;

namespace OWS_WSIZ.ViewModels
{
    public class SlupPrzelotowyViewModel : Screen
    {
        //ilosc kabli
        /// <summary>
        /// Propercje Ilosc Kabla Głównego
        /// </summary>
        public int IloscKabel1 { get; set; } = 0;
        public int IloscKabel2 { get; set; } = 0;
        public int IloscKabel3 { get; set; } = 0;
        public int IloscKabel4 { get; set; } = 0;
        public int IloscKabel5 { get; set; } = 0;



        /// <summary>
        /// Propercje ilość Kabla Przyłączeniowego
        /// </summary>
        public int IloscPrzylacz1 { get; set; } = 0;
        public int IloscPrzylacz2 { get; set; } = 0;
        public int IloscPrzylacz3 { get; set; } = 0;
        public int IloscPrzylacz4 { get; set; } = 0;
        public int IloscPrzylacz5 { get; set; } = 0;


        /// <summary>
        /// Propercje długość kabla przyłączeniowego
        /// </summary>
        public float DlugoscPrzylacz1 { get; set; } = 0;
        public float DlugoscPrzylacz2 { get; set; } = 0;
        public float DlugoscPrzylacz3 { get; set; } = 0;
        public float DlugoscPrzylacz4 { get; set; } = 0;
        public float DlugoscPrzylacz5 { get; set; } = 0;
        public float DlugoscPrzesla { get; set; } = 0;

        ///<values>full property Pud, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Pud
        ///</values>
        private float _pud;
        public float Pud
        {
            get { return _pud; }
            set
            {
                _pud = value;
                NotifyOfPropertyChange(() => Pud);
            }
        }

        ///<values>full property Pp, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Pp
        ///</values>
        private float _pp;
        public float Pp
        {
            get { return _pp; }
            set
            {
                _pp = value;
                NotifyOfPropertyChange(() => Pp);
            }
        }
        private float _po;
        public float Po
        {
            get { return _po; }
            set
            {
                _po = value;
                NotifyOfPropertyChange(() => Po);
            }
        }

        ///<values>full property Pr, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Pr
        ///</values>
        private float _pr;
        public float Pr
        {
            get { return _pr; }
            set
            {
                _pr = value;
                NotifyOfPropertyChange(() => Pr);
            }
        }

        ///<values>full property Pu, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Pu
        ///</values>
        private float _pu;
        public float Pu
        {
            get { return _pu; }
            set
            {
                _pu = value;
                NotifyOfPropertyChange(() => Pu);
            }
        }

        ///<values>full property Wynik, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Wynik
        ///</values>
        private string _wynik = "----";
        public string Wynik
        {
            get { return _wynik; }
            set
            {
                _wynik = value;
                NotifyOfPropertyChange(() => Wynik);
            }
        }

        ///<values>full property Pud, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Pud
        ///</values>
        private string _nrSlupa = "-";
        public string NrSlupa
        {
            get { return _nrSlupa; }
            set
            {
                _nrSlupa = value;
                NotifyOfPropertyChange(() => NrSlupa);
            }
        }


        // wybór stref klimatycznych
        ///<values>Propercja SKlimat, kolekcja typu BindableCollection skłądająca się z obiektów typu StrefaKlimatyczna 
        ///</values>
        public BindableCollection<StrefaKlimatyczna> SKlimat { get; set; }

        ///<values>full property SelectedSWiatrowa, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole SelectedSWiatrowa
        ///</values>
        private StrefaKlimatyczna _selectedSWiatrowa;
        public StrefaKlimatyczna SelectedSWiatrowa
        {
            get { return _selectedSWiatrowa; }
            set
            {
                _selectedSWiatrowa = value;
                NotifyOfPropertyChange(() => SelectedSWiatrowa);
            }
        }

        ///<values>full property SelectedSSadziowa, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole SelectedSSadziowa
        ///</values>
        private StrefaKlimatyczna _selectedSSadziowa;
        public StrefaKlimatyczna SelectedSSadziowa
        {
            get { return _selectedSSadziowa; }
            set
            {
                _selectedSSadziowa = value;
                NotifyOfPropertyChange(() => SelectedSSadziowa);
            }
        }

        //latarnia
        ///<values>Propercja ComboLatarnia, kolekcja typu BindableCollection skłądająca się z obiektów typu ObcLatarnia zawiera metode NotifyOfPropertyChange()
        ///</values>
        private BindableCollection<ObcLatarnia> _comboLatarnia;
        public BindableCollection<ObcLatarnia> ComboLatarnia
        {
            get { return _comboLatarnia; }
            set
            {
                _comboLatarnia = value;
                NotifyOfPropertyChange(() => ComboLatarnia);
            }
        }
        ///<values>full property SelectedComboLatarnia, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole SelectedComboLatarnia
        ///</values>
        private ObcLatarnia _selectedComboLatarnia;
        public ObcLatarnia SelectedComboLatarnia
        {
            get { return _selectedComboLatarnia; }
            set
            {
                _selectedComboLatarnia = value;
                NotifyOfPropertyChange(() => SelectedComboLatarnia);
            }
        }

        ///<values>Propercja ComboSlupy, kolekcja typu BindableCollection skłądająca się z obiektów typu Slupy zawiera metode NotifyOfPropertyChange()
        ///</values>
        private BindableCollection<Slupy> _comboSlupy;
        public BindableCollection<Slupy> ComboSlupy
        {
            get { return _comboSlupy; }
            set
            {
                _comboSlupy = value;
                NotifyOfPropertyChange(() => ComboSlupy);
            }
        }

        ///<values>full property SelectedSlupy, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole SelectedSlupy
        ///</values>
        private Slupy _selectedSlupy;
        public Slupy SelectedSlupy
        {
            get { return _selectedSlupy; }
            set
            {
                _selectedSlupy = value;
                NotifyOfPropertyChange(() => SelectedSlupy);
            }
        }


        ///<values>full property Slupy, zawiera metode NotifyOfPropertyChange() dynamicznie 
        ///aktualizującą pole Slupy
        ///</values>
        private ObliczoneSlupy _slup;
        public ObliczoneSlupy Slup
        {
            get { return _slup; }
            set
            {
                _slup = value;
                NotifyOfPropertyChange(() => Slup);
            }
        }

    }
}
