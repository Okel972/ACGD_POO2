using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public class Plante
        {
            protected int petale;
            protected int taille;
            protected string couleur;
        }

        public class Fruit: Plante
        {
            string gout;
            string pays;

            public Fruit (string gout, string pays, int petale, int taille, string couleur)
            {
                this.gout = gout;
                this.pays = pays;
                this.petale = petale;
                this.taille = taille;
                this.couleur = couleur;
            }
        }
        public class Article
        {
            int identifiant;
            string nom;
            string description;
            double prix;
            int stock;

            public Article(int identifiant, string nom, string description, double prix, int stock)
            {
                this.identifiant = identifiant;
                this.nom = nom;
                this.description = description;
                this.prix = prix;
                this.stock = stock;
            }
            public int getIdentifiant()
            {
                return identifiant;
            }
            public void setIdentifiant(int valeur)
            {
                identifiant = valeur;
            }
            public string Nom
            {
                get { return nom; }
                set { nom = value; }
            }
            public string Description
            {
                get { return description; }
                set { description = value; }
            }
            public double Prix
            {
                get { return prix; }
                set { prix = value; }
            }
            public int Stock
            {
                get { return stock; }
                set { stock = value; }
            }

            public void AfficherArticle()
            {
                Console.WriteLine($"L'identifiant est : {getIdentifiant}");
                Console.WriteLine($"Le nom est : {Nom}");
                Console.WriteLine($"La description est : {Description}");
                Console.WriteLine($"Son prix est : {Prix} en euros");
                Console.WriteLine($"Le stock est de : {Stock}");
            }
        }
        static void Main(string[] args)
        {
            Article article1 = new Article(1, "T-shirt", "T-shirt en coton", 19.99, 10);

            article1.AfficherArticle();

            article1.Prix = 24.99;
            article1.Stock = 5;

            Console.WriteLine("\nInformations de l'article après modification :");
            article1.AfficherArticle();
        }
    }
}