using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeInShape
{
    class Dieta : IObserwator
    {
        //konstruktor
        private BMI_AF bmiaf;
        private tworzenieDiety wyborDiety;
        //prywatne pola do przechowywania BMI i AF
        private int bmi;
        private double af;
        private double wzor = 0;
        private string ktoraDieta = "Wybierz parametry";
        private int suma;

        List<string> jadlospis = new List<string>();
        List<int> kalorie = new List<int>();

        public Dieta(BMI_AF o)
        {
            bmiaf = o;
        }

        public string aktualizacjaDanych()
        {
            bmi = bmiaf.pobierzBMI();
            af = bmiaf.pobierzAF();
            ktoraDieta = wybierzDiete();
           
            return ktoraDieta;
          
        }

        public string wybierzDiete()
        {
            string wybranaDieta = "";
            wzor = bmi * af;
            //wzor = 14;
            wyborDiety = new tworzenieDiety();

            if (wzor == 1.4)
            {
                kalorie.Clear();
                kalorie.Add(1032);
                kalorie.Add(70);
                kalorie.Add(270);
                kalorie.Add(808);
                kalorie.Add(140);
                kalorie.Add(400);

                jadlospis.Clear();
                jadlospis.Add(string.Format("{0}{1}{2}{3}", "owsianka z żurawiną (250gr)".PadRight(40), kalorie[0] + "kcal", Environment.NewLine + "sok z mandarynek (100ml)".PadRight(46), kalorie[1] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "ciasto jogurtowe (140gr)".PadRight(48), kalorie[2] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "polędwiczki wieprzowe" + Environment.NewLine + "z cebulą (250gr)".PadRight(54), kalorie[3] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "koktajl owsiano-jagodowy (125gr)".PadRight(39), kalorie[4] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "bułka grahamka z serkiem" + Environment.NewLine + "wiejskim i szczypiorkiem (240gr)".PadRight(41), kalorie[5] + "kcal"));

                suma = kalorie.Sum();

                wybranaDieta = wyborDiety.utworzenieDiety(jadlospis) + Environment.NewLine + string.Format("{0}{1}", "Łączna ilość kalorii:".PadRight(58), suma);
            }

            if (wzor == 14)
            {
                kalorie.Clear();
                kalorie.Add(724);
                kalorie.Add(280);
                kalorie.Add(222);
                kalorie.Add(678);
                kalorie.Add(35);
                kalorie.Add(120);
                kalorie.Add(330);

                jadlospis.Clear();
                jadlospis.Add(string.Format("{0}{1}{2}{3}", "placki owsiane z bananem (400gr)".PadRight(36), kalorie[0] + "kcal", Environment.NewLine + "batonik proteinowy (100gr)".PadRight(45), kalorie[1] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "kanapka z jajkiem na twardo (125gr)".PadRight(36), kalorie[2] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}{2}{3}", "spaghetti carbonara (300gr)".PadRight(44), kalorie[3] + "kcal", Environment.NewLine + "sok pomarańczowy (100ml)".PadRight(44), kalorie[4] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "kremowe lody z banana (125gr)".PadRight(39), kalorie[5] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "sałatka z kaszy kus-kus" + Environment.NewLine + "i pestkami granata (200gr)".PadRight(46), kalorie[6] + "kcal"));

                suma = kalorie.Sum();

                wybranaDieta = wyborDiety.utworzenieDiety(jadlospis) + Environment.NewLine + string.Format("{0}{1}", "Łączna ilość kalorii:".PadRight(58), suma);
            }

            if (wzor == 140)
            {
                kalorie.Clear();
                kalorie.Add(800);
                kalorie.Add(203);
                kalorie.Add(620);
                kalorie.Add(102);
                kalorie.Add(305);

                jadlospis.Clear();
                jadlospis.Add(string.Format("{0}{1}", "razowe ciasto bananowe (300gr)".PadRight(38), kalorie[0] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "mus czekoladowo-bananowy" + Environment.NewLine + "(200gr)".PadRight(61), kalorie[1] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "fasolka po Bretońsku (250gr)".PadRight(43), kalorie[2] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "koktajl truskawkowy (100gr)".PadRight(45), kalorie[3] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "tosty z sadzonym jajkiem (200gr)".PadRight(40), kalorie[4] + "kcal"));

                suma = kalorie.Sum();

                wybranaDieta = wyborDiety.utworzenieDiety(jadlospis) + Environment.NewLine + string.Format("{0}{1}", "Łączna ilość kalorii:".PadRight(58), suma);            
            }

            if (wzor == 1.7)
            {
                kalorie.Clear();
                kalorie.Add(1104);
                kalorie.Add(84);
                kalorie.Add(302);
                kalorie.Add(860);
                kalorie.Add(150);
                kalorie.Add(442);

                jadlospis.Clear();
                jadlospis.Add(string.Format("{0}{1}{2}{3}", "4x ciabatta z serkiem" + Environment.NewLine + "Camembert (400gr)".PadRight(46), kalorie[0] + "kcal", Environment.NewLine + "sok proteinowy".PadRight(57), kalorie[1] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "batonik bounty (100gr)".PadRight(49), kalorie[2] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "burger wołowy z sałatą, serem," + Environment.NewLine + "jajkiem, bekonem i ostrym" + Environment.NewLine + "sosem (250gr)".PadRight(54), kalorie[3] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "kanapka z polędwicą Sopocką," + Environment.NewLine + "zielonym ogórkiem" + Environment.NewLine + "i kiełkami (100gr)".PadRight(54), kalorie[4] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "jajecznica z łososiem (220gr)".PadRight(43), kalorie[5] + "kcal"));

                suma = kalorie.Sum();

                wybranaDieta = wyborDiety.utworzenieDiety(jadlospis) + Environment.NewLine + string.Format("{0}{1}", "Łączna ilość kalorii:".PadRight(58), suma);
            }

            if (wzor == 17)
            {
                kalorie.Clear();
                kalorie.Add(1089);
                kalorie.Add(262);
                kalorie.Add(800);
                kalorie.Add(134);
                kalorie.Add(390);
                kalorie.Add(20);

                jadlospis.Clear();
                jadlospis.Add(string.Format("{0}{1}", "pancakes gryczane (480gr)".PadRight(41), kalorie[0] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "kromka z serem topionym" + Environment.NewLine + "i łososiem (120gr)".PadRight(53), kalorie[1] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "pierogi z soczewicy (320gr)".PadRight(45), kalorie[2] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "deser jabłkowy z orzechami" + Environment.NewLine + "i miodem (133gr)".PadRight(52), kalorie[3] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}{2}{3}", "burger ze szpinakiem, kurczakiem" + Environment.NewLine + "i serem mozarella (190gr)".PadRight(45), kalorie[4] + "kcal", Environment.NewLine + "sok marchewkowy".PadRight(52), kalorie[5] + "kcal"));

                suma = kalorie.Sum();

                wybranaDieta = wyborDiety.utworzenieDiety(jadlospis) + Environment.NewLine + string.Format("{0}{1}", "Łączna ilość kalorii:".PadRight(58), suma);
            }

            if (wzor == 170)
            {
                kalorie.Clear();
                kalorie.Add(884);
                kalorie.Add(240);
                kalorie.Add(800);
                kalorie.Add(61);
                kalorie.Add(360);

                jadlospis.Clear();
                jadlospis.Add(string.Format("{0}{1}", "tosty z serkiem śmietankowym" + Environment.NewLine + "i dżemem (400gr)".PadRight(51), kalorie[0] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "jogurt z awokado (100gr)".PadRight(46), kalorie[1] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "schabowy z ziemniakami i" + Environment.NewLine + "surówką (300gr)".PadRight(53), kalorie[2] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "jogurt pitny (100gr)".PadRight(56), kalorie[3] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "muffinki z musem jabłkowym" + Environment.NewLine + "i płatkami owsianymi (150gr)".PadRight(43), kalorie[4] + "kcal"));

                suma = kalorie.Sum();

                wybranaDieta = wyborDiety.utworzenieDiety(jadlospis) + Environment.NewLine + string.Format("{0}{1}", "Łączna ilość kalorii:".PadRight(58), suma);
            }

            if (wzor == 2.0)
            {
                kalorie.Clear();
                kalorie.Add(1068);
                kalorie.Add(355);
                kalorie.Add(320);
                kalorie.Add(1040);
                kalorie.Add(170);
                kalorie.Add(520);

                jadlospis.Clear();
                jadlospis.Add(string.Format("{0}{1}{2}{3}", "kakaowa jaglanka z" + Environment.NewLine + "wiórkami kokosowymi (400gr)".PadRight(38), kalorie[0] + "kcal", Environment.NewLine + "4 banany".PadRight(59), kalorie[1] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "wafelek Prince Polo (60gr)".PadRight(46), kalorie[2] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "duszona wołowina z" + Environment.NewLine + "pieczonymi ziemniakami (330gr)".PadRight(36), kalorie[3] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "sałatka Caprese (150gr)".PadRight(47), kalorie[4] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "mieszanka pestek (100gr)".PadRight(44), kalorie[5] + "kcal"));

                suma = kalorie.Sum();

                wybranaDieta = wyborDiety.utworzenieDiety(jadlospis) + Environment.NewLine + string.Format("{0}{1}", "Łączna ilość kalorii:".PadRight(58), suma);
            }

            if (wzor == 20)
            {
                kalorie.Clear();
                kalorie.Add(1170);
                kalorie.Add(50);
                kalorie.Add(308);
                kalorie.Add(960);
                kalorie.Add(133);
                kalorie.Add(400);
                kalorie.Add(80);

                jadlospis.Clear();
                jadlospis.Add(string.Format("{0}{1}{2}{3}", "makowe batoniki (250gr)".PadRight(43), kalorie[0] + "kcal", Environment.NewLine + "sok marchewkowy".PadRight(52), kalorie[1] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "baton proteinowy (100gr)".PadRight(46), kalorie[2] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "makaron z domowym pesto" + Environment.NewLine + "pomidorowym (200gr)".PadRight(46), kalorie[3] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "jajka z jarmużowym nadzieniem" + Environment.NewLine + "(100gr)".PadRight(61), kalorie[4] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}{2}{3}", "kanapki z serkiem koperkowym" + Environment.NewLine + "i rzodkiewką (200gr)".PadRight(51), kalorie[5] + "kcal", Environment.NewLine + "kawa z mlekiem i cukrem (80ml)".PadRight(41), kalorie[6] + "kcal"));

                suma = kalorie.Sum();

                wybranaDieta = wyborDiety.utworzenieDiety(jadlospis) + Environment.NewLine + string.Format("{0}{1}", "Łączna ilość kalorii:".PadRight(58), suma);
            }

            if (wzor == 200)
            {
                kalorie.Clear();
                kalorie.Add(1100);
                kalorie.Add(276);
                kalorie.Add(836);
                kalorie.Add(160);
                kalorie.Add(430);

                jadlospis.Clear();
                jadlospis.Add(string.Format("{0}{1}", "ryż na mleku w zalewie" + Environment.NewLine + "śmietanowej z truskawkami i" + Environment.NewLine + "kawałkami czekolady (250gr)".PadRight(39), kalorie[0] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "brownie z batatów (100gr)".PadRight(45), kalorie[1] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "gulasz wołowy z kaszą" + Environment.NewLine + "i żurkiem (100gr)".PadRight(54), kalorie[2] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "kanapka z pastą jajeczną" + Environment.NewLine + "(100gr)".PadRight(61), kalorie[3] + "kcal"));
                jadlospis.Add(string.Format("{0}{1}", "zapiekana bagietka z łososiem," + Environment.NewLine + "serem i ogórkiem (100gr)".PadRight(45), kalorie[4] + "kcal"));

                suma = kalorie.Sum();

                wybranaDieta = wyborDiety.utworzenieDiety(jadlospis) + Environment.NewLine + string.Format("{0}{1}", "Łączna ilość kalorii:".PadRight(58), suma);
            }

            return wybranaDieta;

        }
    }
}
