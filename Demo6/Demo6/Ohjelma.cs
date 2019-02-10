using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author jaakkomustalahti
/// @version 20.10.2018
/// <summary>
/// 
/// </summary>
public class Demo6
{
    public static void Main()
    {
        // Kirjoita ohjelmakoodisi tähän
    }


    /// <summary>
    /// Funktio palauttaa luvun itseisarvon
    /// </summary>
    /// <returns>Itseisarvo</returns>
    /// <param name="luku">Luku</param>
    /// <example>
    /// <pre name="test">
    /// Demo6.Itseisarvo(-5) ~~~ 5;
    /// Demo6.Itseisarvo(0) ~~~ 0;
    /// Demo6.Itseisarvo(3) ~~ 3;
    /// </pre>
    /// </example>
    public static double Itseisarvo(double luku)
    {
        double tmp = luku;
        return tmp < 0 ? tmp * -1 : tmp;
    }


    /// <summary>
    /// Laskee kahden luvun etäisyyden
    /// </summary>
    /// <returns>Etäisyys</returns>
    /// <param name="luku1">Luku 1</param>
    /// <param name="luku2">Luku 2</param>
    /// <example>
    /// <pre name="test">
    /// Demo6.Etaisyys(8.5, 3.2) ~~~ 5.3;
    /// Demo6.Etaisyys(4.2, -1.1) ~~~ 5.3;
    /// Demo6.Etaisyys(-3.2, -8.5) ~~~ 5.3;
    /// </pre>
    /// </example>
    public static double Etaisyys(double luku1, double luku2)
    {
        double tmp1 = luku1;
        double tmp2 = luku2;
        return tmp1 > tmp2 ? tmp1 - tmp2 : tmp2 - tmp1;
    }


    /// <summary>
    /// Palauttaa tauluko alkion, joka on lähimpänä alkioiden keskiarvoa
    /// </summary>
    /// <returns>Miidi</returns>
    /// <param name="taulukko">Taulukko</param>
    /// <example>
    /// <pre name="test">
    /// Demo6.Miidi(new double[]{1, 2, 3, 2, 5}) ~~~ 3;
    /// </pre>
    /// </example>
    public static double Miidi(double[] taulukko)
    {
        double summa = 0;
        for (int i = 0; i < taulukko.Length; i++)
        {
            summa += taulukko[i];
        }

        double avg = summa / taulukko.Length;

        return EtsiLahin(taulukko, avg);
    }


    /// <summary>
    /// Palauttaa taulukon alkion, joka on lähinnä annettua lukua
    /// </summary>
    /// <returns>Lähin alkio</returns>
    /// <param name="taulukko">Taulukko</param>
    /// <param name="luku">Luku</param>
    /// <example>
    /// <pre name="test">
    /// Demo6.EtsiLahin(new double[]{1}, 5) ~~~ 1;
    /// Demo6.EtsiLahin(new double[]{3, 3}, 5) ~~~ 3;
    /// Demo6.EtsiLahin(new double[]{}, 5) ~~~ 0;
    /// Demo6.EtsiLahin(new double[]{1, 2, 3, 2, 5}, 2.6) ~~~ 3;
    /// </pre>
    /// </example>
    public static double EtsiLahin(double[] taulukko, double luku)
    {
        if (taulukko.Length > 0)
        {
            double jaannos = taulukko[0] % luku;
            double alkio = taulukko[0];
            for (int i = 1; i < taulukko.Length; i++)
            {
                if (taulukko[i] % luku < jaannos) alkio = taulukko[i];
            }

            return alkio;
        }

        return 0;
    }


    /// <summary>
    /// Tarkistaa onko luvut samat toleranssilla
    /// </summary>
    /// <returns>Totuusarvo</returns>
    /// <param name="a">Luku A</param>
    /// <param name="b">Luku B</param>
    /// <param name="eps">Toleranssi</param>
    /// <example>
    /// <pre name="test">
    /// double a = 7.1001;
    /// double b = 7.1002;
    /// double c = 7.2002;
    /// Demo6.Samat(a, b, 0.01) === true;
    /// Demo6.Samat(a, b) === false;
    /// Demo6.Samat(a, c, 0.01) === false;
    /// Demo6.Samat(a, c, 0.2) === true;
    /// </pre>
    /// </example>
    public static bool Samat(double a, double b, double eps=0.00001)
    {
        double tmpA = a;
        double tmpB = b;
        return tmpA > tmpB ? tmpA - tmpB <= eps : tmpB - tmpA <= eps;
    }


}