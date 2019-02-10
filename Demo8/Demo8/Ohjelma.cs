using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author jaakkomustalahti
/// @version 4.11.2018
/// <summary>
/// 
/// </summary>
public class Demo8
{
    public static void Main()
    {
        // Kirjoita ohjelmakoodisi tähän
    }


    /// <summary>
    /// Palauttaa onko vuosi karkausvuosi
    /// </summary>
    /// <returns>Totuusarvo</returns>
    /// <param name="vuosi">Vuosi.</param>
    /// <example>
    /// <pre name="test">
    /// Demo8.Karkausvuosi(12) === true;
    /// Demo8.Karkausvuosi(200) === false;
    /// Demo8.Karkausvuosi(800) === true;
    /// </pre>
    /// </example>
    public static bool Karkausvuosi(int vuosi)
    {
        if ( vuosi % 400 == 0 )
        {
            return true;
        } 
        else if ( vuosi % 100 == 0)
        {
            return false;
        }
        else if ( vuosi % 4 == 0 )
        {
            return true;
        }
        else
        {
            return false;
        }
    }


    /// <summary>
    /// Paluttaa vuodenajan kuukaudelle
    /// </summary>
    /// <returns>Vuodenaika.</returns>
    /// <param name="kuukausi">Kuukausi.</param>
    public static string VuodenaikaIf(int kuukausi)
    {
        if ( kuukausi == 12 || ( kuukausi >= 1 && kuukausi <= 2 ) )
        {
            return "talvi";
        }
        else if ( kuukausi >= 3 && kuukausi <= 5  )
        {
            return "kevät";
        }
        else if ( kuukausi >= 6 && kuukausi <= 8 )
        {
            return "kesä";
        }
        else if ( kuukausi >= 9 && kuukausi <= 11 )
        {
            return "syksy";
        }
        else
        {
            return "";
        }
    }


    public static string VuodenaikaSwitch(int kuukausi)
    {
        switch (kuukausi)
        {
            case 1:
                return "talvi";
            case 2:
                return "talvi";
            case 3:
                return "kevät";
            case 4:
                return "kevät";
            case 5:
                return "kevät";
            case 6:
                return "kesä";
            case 7:
                return "kesä";
            case 8:
                return "kesä";
            case 9:
                return "syksy";
            case 10:
                return "syksy";
            case 11:
                return "syksy";
            case 12:
                return "talvi";
            default:
                return "";
                
        }
    }


    public static string Vuodenaika(int kuukausi)
    {
        string[] vuodenajatKuukausittain = { "talvi", "talvi", "kevät", "kevät", "kevät", "kesä", "kesä", "kesä", "syksy", "syksy", "syksy", "talvi" };
        return (kuukausi >= 1 && kuukausi <= 12) ? vuodenajatKuukausittain[kuukausi - 1] : "";
    }
}
