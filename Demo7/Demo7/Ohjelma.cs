using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

/// @author jaakkomustalahti
/// @version 28.10.2018
/// <summary>
/// 
/// </summary>
public class Demo7
{
    public static void Main()
    {
        int kMaara = LaskeKirjaimet("kissa", 's');
        Console.WriteLine(kMaara);

        double[,] mat1 = { { 1, 2, 3 }, { 2, 2, 2 }, { 4, 2, 3 } };
        double[,] mat2 = { { 9, 2, 8 }, { 1, 2, 5 }, { 3, 19, -3 } };
        double[,] mat3 = Summa(mat1, mat2);
    }


    /// <summary>
    /// Palauttaa tietyn kirjaimen määrän merkkijonossa
    /// </summary>
    /// <returns>Kirjainten määrä</returns>
    /// <param name="merkkijono">Merkkijono.</param>
    /// <param name="kirjain">Kirjain.</param>
    /// <example>
    /// <pre name="test">
    /// Demo7.LaskeKirjaimet("Tama on merkkijono", 'a') === 2;
    /// Demo7.LaskeKirjaimet("", 'a') === 0;
    /// </pre>
    /// </example>
    public static int LaskeKirjaimet(string merkkijono, char kirjain)
    {
        int maara = 0;
        if ( String.IsNullOrEmpty(merkkijono) ) return maara;

        for (int i = 0; i < merkkijono.Length; i++)
        {
            if (merkkijono[i] == kirjain) maara++;
        }

        return maara;
    }


    /// <summary>
    /// Laskee yhteen kahden matriisin vastinalkiot
    /// </summary>
    /// <returns>Uusi matriisi summattuina tai null, jos matriisit eri pituiset</returns>
    /// <param name="mat1">Matriisi 1</param>
    /// <param name="mat2">Matriisi 2</param>
    /// <example>
    /// <pre name="test">
    /// double[,] mat1 = { {1,2,3}, {2,2,2}, {4,2,3} };
    /// double[,] mat2 = { {9,2,8}, {1,2,5}, {3,19,-3} };
    /// double[,] mat3 = { { 9, 2, 8 }, { 1, 2, 5 } };
    /// Demo7.Summa(mat1, mat2) === new double[,] { {10,  4, 11}, { 3,  4,  7}, { 7, 21,  0} };
    /// Demo7.Summa(mat1, mat3) === null;
    /// </pre>
    /// </example>
    public static double[,] Summa(double[,] mat1, double[,] mat2)
    {
        if (mat1.GetLength(0) != mat2.GetLength(0) || mat1.GetLength(1) != mat2.GetLength(1)) return null;
        double[,] matriisi = new double[mat1.GetLength(0), mat1.GetLength(1)];
        for (int i = 0; i < mat1.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.GetLength(1); j++)
            {
                matriisi[i, j] = mat1[i, j] + mat2[i, j];
            }
        }

        return matriisi;
    }
}
