namespace ExerciciosA8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A8E2LocadoraJogos();
        }

        static void A8E2LocadoraJogos()
        {
            string nomeLocadora = ".4.GAMES.";

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("               .L.O.C.A.D.O.R.A.                  ");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            //Console.Write("Nome da locadora: ");
            //nomeLocadora = Console.ReadLine();

            Locadora locadora = new Locadora(nomeLocadora);

        }
    }
}