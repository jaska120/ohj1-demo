using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author jaakkomustalahti
/// @version 13.10.2018
/// <summary>
/// 
/// </summary>
public class Demo5
{
    public static void Main()
    {
        StringBuilder jono;
        jono = new StringBuilder("kissa istuu");
        LisaaAlkuunJaLoppuun(jono, "***"); // jono muuttuu
        Console.WriteLine("Jono on nyt " + jono);
        // tulostaa: Jono on nyt *** kissa istuu ***

        int[] luvut = { 7, 9, 2 };

        int suurin = Suurin(luvut);
        int pienin = Pienin(luvut);

        Console.WriteLine("Suurin luku on " + suurin);
        Console.WriteLine("Pienin luku on " + pienin);

        TulostaKertotaulu(3);
        Console.WriteLine("-------------------");
        TulostaKertotauluWhile(3, 5);
        Console.WriteLine("-------------------");
        TulostaKertotauluDoWhile(6, 0);
    }


    /// <summary>
    /// Lisätään jonon alkuun ja loppuun sama teksti
    /// </summary>
    /// <param name="jono">Mihin jonoo lisätään</param>
    /// <param name="lisa">mitä lisätään</param>
    /// <example>
    /// <pre name="test">
    ///   StringBuilder j1 = new StringBuilder("123");
    ///   Demo5.LisaaAlkuunJaLoppuun(j1,"XX");
    ///   j1.ToString() === "XX 123 XX";
    ///   StringBuilder j2 = new StringBuilder("");
    ///   Demo5.LisaaAlkuunJaLoppuun(j2,"X");
    ///   j2.ToString() === "X  X";
    /// </pre>
    /// </example>
    private static void LisaaAlkuunJaLoppuun(StringBuilder jono, string lisa)
    {
        jono.Insert(0, " ");
        jono.Insert(0, lisa);
        jono.Append(" ");
        jono.Append(lisa);
    }


    /// <summary>
    /// Aliohjelma tutkii, mikä annetuista
    /// kolmesta kokonaisluvuista on pienin,
    /// ja palauttaa sen.
    /// </summary>
    /// <param name="luvut">3 paikkainen taulukko jossa on luvut</param>
    /// <returns>Pienin luku kolmesta</returns>
    /// <example>
    /// <pre name="test">
    /// SuurinJaPienin.Pienin(new int[]{1, 2 ,3}) === 1;
    /// SuurinJaPienin.Pienin(new int[]{2, 1, 3}) === 1;
    /// SuurinJaPienin.Pienin(new int[]{2, 3, 1}) === 1;
    /// SuurinJaPienin.Pienin(new int[]{3, 3, 2}) === 2;
    /// SuurinJaPienin.Pienin(new int[]{3, 3, 3}) === 3;
    /// </pre>
    /// </example>
    private static int Pienin(int[] luvut)
    {
        int pienin = luvut[0];

        for (int i = 1; i < luvut.Length; i++)
        {
            if (luvut[i] < pienin) pienin = luvut[i];
        }

        return pienin;
    }

    /// <summary>
    /// Aliohjelma tutkii, mikä annetuista
    /// kolmesta kokonaisluvuista on suurin,
    /// ja palauttaa sen.
    /// </summary>
    /// <param name="luvut">3 paikkainen taulukko jossa on luvut</param>
    /// <returns>Suurin luku kolmesta</returns>
    /// <example>
    /// <pre name="test">
    /// SuurinJaPienin.Suurin(new int[]{3, 2, 1}) === 3;
    /// SuurinJaPienin.Suurin(new int[]{2, 3, 1}) === 3;
    /// SuurinJaPienin.Suurin(new int[]{2, 1, 3}) === 3;
    /// SuurinJaPienin.Suurin(new int[]{4, 2, 4}) === 4;
    /// SuurinJaPienin.Suurin(new int[]{1, 1, 1}) === 1;
    /// </pre>
    /// </example>
    private static int Suurin(int[] luvut)
    {
        int suurin = luvut[0];

        for (int i = 1; i < luvut.Length; i++)
        {
            if (luvut[i] > suurin) suurin = luvut[i];
        }

        return suurin;
    }


    /// <summary>
    /// Aliohjelma tulostaa annetulla kertojalla kertotaulun 1-10
    /// </summary>
    /// <param name="kertoja">Kertoja.</param>
    private static void TulostaKertotaulu(int kertoja)
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("{0} * {1} =  {2}", (i < 9) ? $" {i+1}" : $"{i+1}", kertoja, (i*kertoja < 10) ? $" {i*kertoja}" : $"{i*kertoja}");
        }
    }


    /// <summary>
    /// Aliohjelma tulostaa kertotaulun
    /// </summary>
    /// <param name="n">Kertotaulu</param>
    /// <param name="m">Rivien määrä</param>
    private static void TulostaKertotauluWhile(int n, int m)
    {
        int i = 0;
        while (i < m)
        {
            Console.WriteLine("{0} * {1} =  {2}", (i < 9) ? $" {i + 1}" : $"{i + 1}", n, ((i+1) * n < 10) ? $" {(i+1) * n}" : $"{(i+1) * n}");
            i++;
        }
    }


    /// <summary>
    /// Aliohjelma tulostaa kertotaulun
    /// </summary>
    /// <param name="n">Kertotaulu</param>
    /// <param name="m">Rivien määrä</param>
    private static void TulostaKertotauluDoWhile(int n, int m)
    {
        int i = 0;
        do
        {
            if (m > 0)
            {
                Console.WriteLine("{0} * {1} =  {2}", (i < 9) ? $" {i + 1}" : $"{i + 1}", n, ((i + 1) * n < 10) ? $" {(i + 1) * n}" : $"{(i + 1) * n}");
                i++;
            }
        } while (i < m);
    }
}
