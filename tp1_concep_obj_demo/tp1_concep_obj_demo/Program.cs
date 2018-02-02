using System;


namespace tp1_concep_obj_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Affichage table de 8
            //Concaténation: +
            //Saut de ligne \n
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            const int multiple = 8;
            const int valMax = 10;

            string affichage = "";

            for (int i=0;i<= valMax;i++)
            {
                // Interpolated string (C# >=v6)
                affichage +=
                   $"{i} x {multiple} = {i * multiple:C}";
                affichage += "\n";
            }
            Console.WriteLine(affichage);
            Console.ReadKey();
            
        /*Console.WriteLine("Voici la table de 8");
            int i = 0;
            string
            for(i=0;i<=10;i++)
            {
                Console.WriteLine(" {0} * 8 = {1}", i, i * 8);
            }
            Console.ReadKey();*/
            
            }
    }
}
