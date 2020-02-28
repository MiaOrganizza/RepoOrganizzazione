using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsPag85N31Project
{
    /* MIA modifica  */

    /* Ho aggiunto un po' di modifiche io ora
     * Dimmi che ne pansi.
     * Grazie
     */
        
    class Program
    {

        static void Main(string[] args)
        {
            /* aggiunta opzione su Github in modo che cancelli in automatico il ramo
             * quando viene fatto il merge dello stesso
             */

            /* Modifiche da Fenice */
            int r, c;
            string s;

            /* inserisco modifiche per
             * documentazione
             */

            do
            {
                Console.Write("Inserisci il numero di righe: ");
                s = Console.ReadLine();

            } while (!int.TryParse(s, out r));

            do
            {
                Console.Write("Inserisci il numero di colonne: ");
                s = Console.ReadLine();

            } while (!int.TryParse(s, out c));

            int[,] mat = new int[r, c];
            int sommaNumeri = 0;
            Random ran = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = 1;// ran.Next();
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (i == 0) sommaNumeri += mat[i, j];
                    if (i == mat.GetLength(0)-1) sommaNumeri += mat[i, j];
                    if (j == 0) sommaNumeri += mat[i, j];
                    if (j == mat.GetLength(1)-1) sommaNumeri += mat[i, j];
                }
            }

            Console.WriteLine("Somma: " + sommaNumeri);
            Console.ReadKey();
            
        }
    }
}
