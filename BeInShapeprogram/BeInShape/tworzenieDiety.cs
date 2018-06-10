using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeInShape
{
    class tworzenieDiety
    {
        string[] posilki = { "ŚNIADANIE", "DRUGIE ŚNIADANIE", "OBIAD", "PODWIECZOREK", "KOLACJA" };  
        private string dieta1 = "";

        public string utworzenieDiety(List<string> jadlospis)
        {
            for (int i = 0; i < posilki.Length; i++)
            {
                dieta1 = dieta1 + Environment.NewLine + posilki[i]
                     + Environment.NewLine + jadlospis[i] + Environment.NewLine + "___________________________________";
            }

            return dieta1;
        }
    }
}
