namespace TP_Cercle
{
    internal class Point
    {//Attributs de la classe:
        private int x;
        private int y;
        private int r;
        //Constructeur de la classe:
        public Point(int x, int y, int r)
        {
            Console.WriteLine("Donner l'abcissedu centre:");
            x = int.Parse(Console.ReadLine());
            this.x = x;
            Console.WriteLine("Donner l'ordonné du centre:");
            y = int.Parse(Console.ReadLine());
            this.y = y;
            Console.WriteLine("Donner le rayon:");
            r = int.Parse(Console.ReadLine());
            this.R = r;
        }
        //Accesseurs:
        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public int R { get => r; set => r = value; }

        //Méthode afficher:
        //TODO:construire la Méthode CalculerSurface.
        public double CalculerSurface(int rayon)
        {
            double surface = Math.PI * Math.Pow(rayon, 2);
            return surface;
        }
        /// <summary>
        /// Méthode CalculerPerimetre qqqqqqqqui calcule le périmètre d'un cercle en fonction de son rayon.
        /// </summary>
        /// <param name="rayon"></param>
        /// <returns></returns>
        double CalculerPerimetre(int rayon)
        {
            double Perimeter = 2 * Math.PI * rayon;
            return Perimeter;
        }
        //TODO: finir la méthode Afficher.
        public void Afficher()
        {
            Console.WriteLine($"Le périmètre est: {CalculerPerimetre(r)}");
            Console.WriteLine($"La surface est: {CalculerSurface(r)}");
        }
    }
}
