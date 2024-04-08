
using System;

class Program
{
    static void Main(string[] args)
    {
        // Définir la taille des tableaux
        int taille = 7;
        int tailleDouble = taille * 2;

        // Créer les deux tableaux de même taille
        int[] tableau1 = new int[taille];
        int[] tableau2 = new int[taille];

        // Créer le tableau avec le double de la taille
        int[] tableauDouble = new int[tailleDouble];

        // Mettre des valeurs dans les deux premiers tableaux
        for (int i = 0; i < taille; i++)
        {
            tableau1[i] = i * 2; // Exemple de valeurs (0, 2, 4, 6, 8, 10, 12)
            tableau2[i] = i * 3; // Exemple de valeurs (0, 3, 6, 9, 12, 15, 18) 
        }

        // Mettre les valeurs des deux premiers tableaux dans le tableau plus grand
        Array.Copy(tableau1, 0, tableauDouble, 0, taille);
        Array.Copy(tableau2, 0, tableauDouble, taille, taille);

        // Afficher les tableaux
        Console.WriteLine("Tableau 1 :");
        AfficherTableau(tableau1);

        Console.WriteLine("\nTableau 2 :");
        AfficherTableau(tableau2);

        Console.WriteLine("\nTableau Double :");
        AfficherTableau(tableauDouble);
    }

    // Méthode pour afficher un tableau
    static void AfficherTableau(int[] tableau)
    {
        foreach (int valeur in tableau)
        {
            Console.Write(valeur + " ");
        }
        Console.WriteLine();
    }
}
