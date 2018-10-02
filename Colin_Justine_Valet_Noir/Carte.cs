namespace Colin_Justine_Valet_Noir
{
    public class Carte
    {
        public int Num_Carte;
        public string Couleur;
        public string Symbole;
        public bool Valet = false;
        public static int Num = 0;
        public int Valeur;

        public Carte()
        { }

        public Carte(int N)
        {
            this.Num_Carte = N;
            if (Num_Carte == 12 || Num_Carte == 25 || Num_Carte == 38)
                Num = 0;
            Num++;
            Valeur = Num;
            if (Num_Carte == 10)
                Valeur = 12;
            if (Num_Carte == 11)
                Valeur = 13;
        }
    }
}
