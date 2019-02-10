using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author jaakkomustalahti
/// @version 6.10.2018
/// <summary>
/// 
/// </summary>
public class Demo4
{
    public static void Main()
    {
        int[] t = { 23, 45, 12, 9, 3, 7 };
        Console.WriteLine(string.Join(", ", t));
        Console.WriteLine(string.Join(", ", KasitteleTaulukko(t)));
        int[] a = { 23, 45, 12, 9, 3, 7 };
        Console.WriteLine(string.Join(", ", KasitteleTaulukko2(a)));
        Console.WriteLine(MuutaKirjaimet("Räppäri"));

    }

    public static int[] KasitteleTaulukko(int[] t)
    {
        int lisattava = 5;

        for (int i = 0; i < t.Length; i++)
        {
            t[i] += lisattava;
        }

        return t;
    }

    public static int[] KasitteleTaulukko2(int[] t)
    {
        for (int i = 0; i < t.Length; i++)
        {
            if ( i % 2 == 0 )
            {
                t[i] += t[i + 1];
            } else {
                t[i] = 0;
            }
        }

        return t;
    }

    public static string PidempiMerkkijono(string sana1, string sana2)
    {
        int pituus1 = sana1.Length;
        int pituus2 = sana2.Length;

        if ( pituus1 >= pituus2 )
        {
            return sana1;
        } else {
            return sana2;
        }
    }

    public static int Suurin(int a, int b, int c)
    {
        int suurin = a;
        if (b > a) suurin = b;
        if (c > suurin) suurin = c;

        return suurin;
    }

    public static int Pienin(int a, int b, int c)
    {
        int pienin = a;
        if (b < a) pienin = b;
        if (c < pienin) pienin = c;

        return pienin;
    }

    public static string PoistaEkaSana(string jono)
    {
        string[] sanat = jono.Split(' ');
        if (sanat.Length == 1)
        {
            return "";
        }
        else
        {
            int ekaPituus = sanat[0].Length;
            return jono.Substring(ekaPituus + 1);
        }
    }

    public static string AnnaEkaSana(string jono)
    {
        string[] sanat = jono.Split(' ');
        if (sanat.Length == 1)
        {
            return jono;
        }
        else
        {
            return sanat[0];
        }
    }

    /// <example>
    /// <pre name="test">
    /// KirjaintenMuutos.MuutaKirjaimet("Traktorikuski") === "Tlaktolikuski"
    /// KirjaintenMuutos.MuutaKirjaimet("Rapatessa roiskuu.") === "Lapatessa loiskuu."
    /// </pre>
    /// </example>
    public static string MuutaKirjaimet(string lause)
    {
        return lause.Replace('r', 'l').Replace('R', 'L');
    }
}
