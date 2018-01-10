using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace elso
{
    class Program
    {
        static void eldont()
        {
            try
            {
                int[] szamok = new int[3];
                Console.Write("Az első számot: ");
                szamok[0] = int.Parse(Console.ReadLine());
                Console.Write("A második számot: ");
                szamok[1] = int.Parse(Console.ReadLine());
                Console.Write("A harmadik számot: ");
                szamok[2] = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("A legnagyobb: {0} a legkisebb pedig: {1}", szamok.Max(), szamok.Min());

            }
            catch (Exception e)
            {
                Console.WriteLine("Szóval ezt kezelni kéne: {0}", e);
            }
        }
        static void napok()
        {
            try
            {
                byte nap;
                Console.Write("Egytől hétig (1-től 7-ig) kérek számot, ha nem azt kapok morcos leszek: ");
                bool be = byte.TryParse(Console.ReadLine(), out nap);
                if (!be || nap < 1 || nap > 7)
                {
                    Console.WriteLine("Nem figyelsz rám? hát akkor rekurzió!");
                    nap = 0;
                    be = false;
                    napok();
                }
                else
                {
                    switch (nap)
                    {
                        case 1:
                            Console.WriteLine("Hétfő");
                            break;
                        case 2:
                            Console.WriteLine("Kedd");
                            break;
                        case 3:
                            Console.WriteLine("Szerda");
                            break;
                        case 4:
                            Console.WriteLine("Csütrötök");
                            break;
                        case 5:
                            Console.WriteLine("Péntek");
                            break;
                        case 6:
                            Console.WriteLine("Szombat");
                            break;
                        case 7:
                            Console.WriteLine("Vasárnap");
                            break;

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }
        }
        static void nap()
        {
            try
            {
                Console.WriteLine("A dátum: {0} és a mai nap: {1}", DateTime.Today.ToString("yyyy/M/d"), DateTime.Now.DayOfWeek.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }
        }
        static void szamlal()
        {
            try
            {
                List<double> szamok = new List<double>();
                double ossz = 0;
                while (ossz < 100)
                {
                    Console.WriteLine("A beírt számok összege: {0}", ossz);
                    Console.WriteLine("Írj be egy számot");
                    double seged;
                    bool be = double.TryParse(Console.ReadLine(), out seged);
                    if (be)
                    {
                        szamok.Add(seged);
                        ossz += seged;
                    }
                    else
                    {
                        Console.WriteLine("Ez nem sikerült kérlek szépen");
                    }
                }
                uint paros = 0;
                uint paratlan = 0;
                for (int i = 0; i < szamok.Count; i++)
                {
                    if (szamok[i] % 2.0 == 0)
                    {
                        paros++;
                    }
                    else
                    {
                        paratlan++;
                    }
                }
                Console.WriteLine("Páros számok: {0}", paros);
                Console.WriteLine("Páratlan számok: {0}", paratlan);
            }

            catch (Exception e)
            {
                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }

        }
        static int gcd(int x, int y)
        {
            try
            {
                while (x != y)
                {
                    if (x < y)
                    {
                        y = y - x;
                    }
                    else
                    {
                        x = x - y;
                    }
                }
                return x;
            }
            catch (Exception e)
            {
                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
                return x;
            }

        }
        static int divi(int x, int y)
        {
            try
            {

                int marad, szam;
                marad = x;
                szam = 0;
                while (marad >= y)
                {
                    marad = marad - y;
                    szam++;
                }
                return (szam);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
                return (x);
            }


        }
        static void tort()
        {
            try
            {
                int szamlal, nevez, div, egyszam, egynev;
                Console.WriteLine("Kérek egy számlálót:");
                szamlal = int.Parse(Console.ReadLine());
                Console.WriteLine("Most pedig egy nevezőt");
                nevez = int.Parse(Console.ReadLine());
                div = gcd(szamlal, nevez);
                if (div != 1)
                {
                    egyszam = divi(szamlal, div);
                    egynev = divi(nevez, div);
                    Console.WriteLine("A tört: {0}/{1} lett", egyszam, egynev);
                }
                else
                {
                    Console.WriteLine("Ez nem fog menni");
                }
                //Console.WriteLine(div);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }

        }
        static void eger()
        {
            try
            {
                int L, eu, ev, U, V, T, talal;
                bool eub, evb;
                Console.WriteLine("Milyen hosszú legyen a csatorna?");
                L = int.Parse(Console.ReadLine());
                Console.WriteLine("Milyen gyors az első egér?");
                U = int.Parse(Console.ReadLine());
                Console.WriteLine("Milyen gyors a második egér?");
                V = int.Parse(Console.ReadLine());
                Console.WriteLine("Mennyi ideig futkároznak?");
                T = int.Parse(Console.ReadLine());
                eu = 1;
                ev = L;
                talal = 0;
                eub = true;
                evb = false;
                for (int i = 0; i < T; i++)
                {
                    if (eub)
                    {
                        if ((eu + U) <= L)
                        {
                            eu += U;
                        }
                        else
                        {
                            int plus = (eu + U) - L;
                            eu = L;
                            eu = L - plus;
                            eub = false;
                        }
                    }
                    else
                    {
                        if ((eu - U) > 1)
                        {
                            eu -= U;
                        }
                        else
                        {
                            eu = 1;
                            eub = true;
                        }
                    }

                    if (evb)
                    {
                        if ((ev + V) <= L)
                        {
                            ev += V;
                        }
                        else
                        {
                            int plus = (ev + V) - L;
                            ev = L;
                            ev = L - plus;
                            evb = false;
                        }
                    }
                    else
                    {
                        if ((ev - V) > 1)
                        {
                            ev -= V;
                        }
                        else
                        {
                            ev = 1;
                            evb = true;
                        }
                    }

                    if (ev == eu)
                    {
                        talal++;
                        //Console.WriteLine("Itt találkoztak: {0} és ekkor {1}",ev, i);
                    }
                    //Console.WriteLine("{0} {1}", i, eu);
                    //Console.WriteLine("{0} {1}", i, ev);
                }
                Console.WriteLine("Összesen találkoztak {0} darabszor", talal);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }

        }
        static void fejviras()
        {
            try
            {
                uint hany, fej, ir;
                fej = 0;
                ir = 0;
                Random rnd = new Random();
                Console.WriteLine("Na hányszor dobjunk fel egy bitcoint? (ahányszor lefuttatod annyit kell fizetni érte)");
                hany = uint.Parse(Console.ReadLine());
                for (uint i = 0; i < hany; i++)
                {
                    int fi = rnd.Next(1, 3); //ez a szar nem tud byte-ból randomot csinálni?
                    if (fi == 1)
                    {
                        fej++;
                        Console.WriteLine("A {0}. dobás fej lett", i + 1);
                    }
                    else
                    {
                        ir++;
                        Console.WriteLine("A {0}. dobás írás lett", i + 1);
                    }
                }
                Console.WriteLine("Összes fej: {0} és összes írás {1}", fej, ir);
            }
            catch (Exception e)
            {

                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }
        }
        static void koszon()
        {
            try
            {
                //Console.WriteLine(DateTime.Now.Hour);
                if (DateTime.Now.Hour < 12 && 8 <= DateTime.Now.Hour)
                {
                    Console.WriteLine("Jó reggelt");
                }
                else if (12 <= DateTime.Now.Hour && 18 < DateTime.Now.Hour)
                {
                    Console.WriteLine("Jó napot");
                }
                else if (18 <= DateTime.Now.Hour && 23 <= DateTime.Now.Hour)
                {
                    Console.WriteLine("Jó estét");
                }
                else
                {
                    Console.WriteLine("Te nem vagy normális az biztos");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }
        }
        static double[] be()
        {
            try
            {
                double[] asd = new double[10];
                for (int i = 0; i < 10; i++)
                {
                    Console.Write("Akkor a {0} számot: ", i + 1);
                    bool szam = double.TryParse(Console.ReadLine(), out asd[i]);
                    Console.WriteLine();
                    if (!szam)
                    {
                        Console.WriteLine("Hát ez nem szám, na próbáljuk meg újra");
                        i--;
                    }
                }
                return asd;

            }
            catch (Exception e)
            {
                double[] err = { 0, 0 };
                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
                return err;
            }
        }
        static double[] rnd()
        {
            try
            {
                Random rnd = new Random();
                double[] asd = new double[10];
                for (int i = 0; i < 10; i++)
                {
                    asd[i] = rnd.Next(int.MinValue, int.MaxValue);
                }
                return asd;
            }
            catch (Exception e)
            {

                double[] err = { 0, 0 };
                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
                return err;
            }
        }
        static void legnagy()
        {
            try
            {
                Console.WriteLine("Hogy kérjünk be 10 számot? random vagy te adod meg? ha random írj-t R-t ha nem random akármi mást");
                string seged = Console.ReadLine().ToUpper();
                double[] szamok;
                if (seged == "R")
                {
                    szamok = rnd();
                    Console.WriteLine("Legnagyobb: {0}", szamok.Max());
                    Console.WriteLine("Legkisebb: {0}", szamok.Min());
                }
                else
                {
                    Console.WriteLine("akkor adjál meg 10 számot");
                    szamok = be();
                    Console.WriteLine("Legnagyobb: {0}",szamok.Max());
                    Console.WriteLine("Legkisebb: {0}", szamok.Min());
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }
        }
        static void mertani()
        {
            try
            {
                Console.WriteLine("Akkor kéne 10 szám, hogy megnézzük mértani vagy számtani sorozat");
                double[] elemek = be();
                bool szamtani = true;
                double egy = elemek[9] - elemek[8];
                double ketto = elemek[8] - elemek[7];
                byte i = 7;
                while (szamtani && i>1)
                {
                    if (egy == 0 && ketto == 0)
                    {
                        egy = ketto;
                        ketto = elemek[i] - elemek[i - 1];
                        i--;
                        //Console.WriteLine("Mi a fasz van?");
                    }
                    else if (egy == ketto)
                    {
                        egy = ketto;
                        ketto = elemek[i] - elemek[i - 1];
                        i--;
                        //Console.WriteLine("egy: {0} ketto {1}", egy, ketto);
                    }
                    else
                    {
                        //Console.WriteLine("Nem számtani sorozat");
                        szamtani = false;
                    }

                }
                bool mertani = true;
                egy = elemek[9] / elemek[8];
                ketto = elemek[8] / elemek[7];
                i = 7;
                while (mertani && i>1)
                {
                    if (egy == 1 && ketto == 1)
                    {
                        egy = ketto;
                        ketto = elemek[i]/elemek[i - 1];
                        i--;

                    }
                    else if (egy == ketto)
                    {
                        egy = ketto;
                        ketto = elemek[i]/elemek[i - 1];
                        i--;
                    }
                    else
                    {
                        mertani = false;
                    }

                }
                if (mertani && szamtani)
                {
                    Console.WriteLine("Egyszerre mértani és számtani (csaknem ugyanazok a számok?)");
                }
                else if (mertani)
                {
                    Console.WriteLine("ez egy mértani sorozat");
                }
                else if (szamtani)
                {
                    Console.WriteLine("Ez egy számtani sorozat");
                }
                else
                {
                    Console.WriteLine("hát valszeg ez nem sorozat");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }
        }
        static void atvalt()
        {
            try
            {
                int dec;
                Console.WriteLine("Adj 1 számot, ami 10-es számrendszerben van");
                bool num = int.TryParse(Console.ReadLine(), out dec);
                if (num)
                {
                    Console.WriteLine("A szám: {0} és a bináris szám: {1}", dec, Convert.ToString(dec, 2));
                }
                else
                {
                    Console.WriteLine("Ez nem is szám :(");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }
        }
        static void cimlet()
        {
            try
            {
                Console.WriteLine("Szóval hány forintot akarsz okosan kifizetni?");
                int szam;
                bool num = int.TryParse(Console.ReadLine(), out szam);
                if (num)
                {
                    uint huszas = 0;
                    while (szam >= 20000)
                    {
                        huszas++;
                        szam -= 20000;
                    }
                    uint tizes = 0;
                    while (szam >= 10000)
                    {
                        tizes++;
                        szam -= 10000;
                    }

                    uint otos = 0;
                    while (szam >= 5000)
                    {
                        otos++;
                        szam -= 5000;
                    }
                    uint kettes = 0;
                    while (szam >= 2000)
                    {
                        kettes++;
                        szam -= 2000;
                    }
                    uint ezres = 0;
                    while (szam >= 1000)
                    {
                        ezres++;
                        szam -= 1000;
                    }
                    uint otsza = 0;
                    while (szam >= 500)
                    {
                        otsza++;
                        szam -= 500;
                    }
                    uint ketsza = 0;
                    while (szam >= 200)
                    {
                        ketsza++;
                        szam -= 200;
                    }
                    uint szaz = 0;
                    while (szam >= 100)
                    {
                        szaz++;
                        szam -= 100;
                    }
                    uint otven = 0;
                    while (szam >= 50)
                    {
                        otven++;
                        szam -= 50;
                    }
                    uint husz = 0;
                    while (szam >= 20)
                    {
                        husz++;
                        szam -= 20;
                    }
                    uint tiz = 0;
                    while (szam >= 10)
                    {
                        tiz++;
                        szam -= 10;
                    }
                    uint ot = 0;
                    while (szam >= 5)
                    {
                        ot++;
                        szam -= 5;
                    }
                    Console.WriteLine("Ezt tudod fizetni {0} darab Deákkal\n{1} darab Pistával\n{2} darab Széchényivel\n{3} darab Gabcsival\n{4} darab Matyival\n{5} darab Ferivel\n{6} darab híddal\n{7} darab címerrel\n{8} darab madárral\n{9} darab virággal\n{10} darab olcsó címerrel\n{11} darab olcsó maráddal\nja és kaparj össze {12} darab fillért", huszas, tizes, otos, kettes, ezres, otsza, ketsza, szaz, otven, husz, tiz, ot, szam);

                }
                else
                {
                    Console.WriteLine("Vmi szar van a levesben");
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }
        }
        static void beolvas()
        {
            try
            {
                if (File.Exists("th.txt"))
                {
                    StreamReader txt = new StreamReader("th.txt");
                    Console.WriteLine("Na akkor mond meg melyik karaktert keressem meg sokszor a szövegben");
                    char src;
                    bool ize = char.TryParse(Console.ReadLine(), out src);
                    if (!ize)
                    {
                        Console.WriteLine("akkor próbáljuk meg újra");
                        beolvas();
                    }
                    uint db = 0;
                    while (!txt.EndOfStream)
                    {
                        string seged = txt.ReadLine();
                        for (int i = 0; i < seged.Length; i++)
                        {
                            if (seged[i] == src)
                            {
                                db++;
                            }
                        }
                    }
                    Console.WriteLine("Van benne {0} méghozzá {1} példányban", src, db);

                }
                else
                {
                    Console.WriteLine("ÚRISTEN HOL A FÁJLOM?");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }
        }
        static string reverseString(string s)
        {
            try
            {
                char[] arr = s.ToCharArray();
                Array.Reverse(arr);
                return new string(arr);
            }
            catch (Exception e)
            {

                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
                return "error";
            }
        }
        static void paladrin()
        {
            try
            {
                Console.WriteLine("Na mondják vicces mondatot");
                string mondat = Console.ReadLine();
                mondat = mondat.Replace(" ", string.Empty).ToLower();
                if (mondat == reverseString(mondat))
                {
                    Console.WriteLine("Azért vicces, mert a c# sír érte");
                }
                else
                {
                    Console.WriteLine("Ez nem is olyan vicces így");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Ezt is kezelni kéne: {0}", e);
            }
        }
        static void Main(string[] args)
        {
            //eldont();
            //napok();
            //nap();
            //szamlal();
            tort();
            //eger();
            //fejviras();
            //koszon();
            //legnagy();
            //mertani();
            //atvalt();
            //cimlet();
            //beolvas();
            //paladrin();
            Console.ReadKey();
        }
    }
}
