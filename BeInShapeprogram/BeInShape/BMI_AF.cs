using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeInShape
{
    class BMI_AF : IObserwowany 
    {
        private List<IObserwator> _listaDiet = new List<IObserwator>();
        private double wBMI = 0;
        private int wAF = 0;
        private string ktoraDieta = "";


        public void dodajDiete(IObserwator o)
        {
            _listaDiet.Add(o);
        }

        public void usunDiete(IObserwator o)
        {
            _listaDiet.Remove(o);
        }

        public string powiadomDiety()
        {
            foreach (var item in _listaDiet)
            {
                ktoraDieta = item.aktualizacjaDanych();
            }

            return ktoraDieta;
        }

        public double wyliczBMI(double waga, double wzrost)
        {
            if (waga > 0 && wzrost > 0)
            {
                wBMI = Convert.ToDouble(waga) / Math.Pow(Convert.ToDouble(wzrost) / 100, 2);
            }

            return wBMI;
        }

        public int wyliczWspolczynnikBMI()
        {
            int wspolczynnikBMI = 0;
            //sprawdzanie wspolczynnikow dla BMI
            if (wBMI > 0 && wBMI <= 17)
            {
                wspolczynnikBMI = 1;
            }
            if (wBMI > 17.1 && wBMI < 25.9)
            {
                wspolczynnikBMI = 10;
            }
            if (wBMI > 26)
            {
                wspolczynnikBMI = 100;
            }

            return wspolczynnikBMI;
        }

        public double wyliczAF(int indexAF)
        {
            wAF = indexAF;
            return wAF;
        }

        public double wyliczWspolczynnikAF()
        {
            double wspolczynnikAF = 0;
            //sprawdzanie wspolczynnikow dla AF
            if (wAF == 0)
            {
                wspolczynnikAF = 1.4;
            }
            if (wAF == 1)
            {
                wspolczynnikAF = 1.7;
            }
            if (wAF == 2)
            {
                wspolczynnikAF = 2.0;
            }

            return wspolczynnikAF;
        }

        public int pobierzBMI()
        {
            return wyliczWspolczynnikBMI();
        }

        public double pobierzAF()
        {
            return wyliczWspolczynnikAF();
        }


    }
}
