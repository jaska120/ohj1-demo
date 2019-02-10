using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author jaakkomustalahti
/// @version 18.11.2018
/// <summary>
/// 
/// </summary>
public class Demo10
{
    /// <summary>
    /// Aliohjelma tulostaa 7 + 3 lottorivin.
    /// </summary>
    public static void Main()
    {
        int[] karkkimaarat = new int[] { 3, 0, 7, 6, 5, 99, 5 };
        double ka = Keskiarvo(karkkimaarat, 0, 99);
        System.Console.WriteLine(ka);

        List<int> pallot = new List<int>();
        for (int i = 0; i < 39; i++)
        {
            pallot.Add(i + 1);
        }

        Jypeli.RandomGen.Shuffle(pallot);

        // 7 ekaa
        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine(pallot[i]);
        }

        // 3 seuraavaa
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(pallot[i + 8]);
        }
    }


    /// <summary>
    /// Aliohjelma palauttaa taulukon keskiarvon määrätyin ehdoin.
    /// </summary>
    /// <returns>The keskiarvo.</returns>
    /// <param name="taulukko">Taulukko.</param>
    /// <param name="vialliset">Vialliset.</param>
    /// <param name="lopetus">Lopetus.</param>
    /// <example>
    /// <pre name="test">
    /// int[] taulukko = new int[] { 12, 0, 42, 14, 99, 12, 55 };
    /// Demo10.Keskiarvo(taulukko, 1, 42) === 12;
    /// taulukko = new int[] { 12, 0, 42, 14, 100, 12, 55 };
    /// Demo10.Keskiarvo(taulukko, -1, 41) === 6;
    /// taulukko = new int[] { 12, 0, 42, 14, 99, 12, 55 };
    /// Demo10.Keskiarvo(taulukko, 0, 0) === 0;
    /// taulukko = new int[] { };
    /// Demo10.Keskiarvo(taulukko, 0, 99) === 0;
    /// taulukko = new int[] { 0, 10 };
    /// Demo10.Keskiarvo(taulukko, 0, 99) === 10;
    /// taulukko = new int[] { -1, -2, 99, 1 };
    /// Demo10.Keskiarvo(taulukko, 0, 99) === 0;
    /// taulukko = new int[] { 12, 0, 42, 14, 99, 12, 55 };
    /// Demo10.Keskiarvo(taulukko, 99, 0) === 99;
    /// taulukko = new int[] { 12, 0, 42, 14, 99, 12, 55 };
    /// Demo10.Keskiarvo(taulukko, 98, 0) === 98;
    /// taulukko = new int[] { -1, 0, 1 };
    /// Demo10.Keskiarvo(taulukko, -10, 99) === 0;
    /// taulukko = new int[] { -1, 0, 1 };
    /// Demo10.Keskiarvo(taulukko, -1, 99) === 0.5;
    /// </pre>
    /// </example>
    public static double Keskiarvo(int[] taulukko, int vialliset, int lopetus)
    {
        double summa = 0;
        int maara = 0;
        for (int i = 0; i < taulukko.Length; i++)
        {
            if (taulukko[i] >= lopetus) break;

            if (taulukko[i] > vialliset) 
            {
                summa += taulukko[i];
                maara++;
            }
        }

        return Math.Abs(summa) < Double.Epsilon && maara == 0 ? vialliset : summa/maara;
    }
}
