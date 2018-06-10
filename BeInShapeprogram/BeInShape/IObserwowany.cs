using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeInShape
{
    public interface IObserwowany
    {
        void dodajDiete(IObserwator o);
        void usunDiete(IObserwator o);
        string powiadomDiety();
        double wyliczBMI(double waga, double wzrost);
        int wyliczWspolczynnikBMI();
        double wyliczAF(int indexAF);
        double wyliczWspolczynnikAF();
        int pobierzBMI();
        double pobierzAF();
    }
}
