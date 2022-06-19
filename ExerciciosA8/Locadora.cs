using System;
using System.Collections.Generic;
namespace ExerciciosA8
{
    public class Locadora
    {
        string nome = "4 GAMES";

        public Jogo jogo;
        public Cliente cliente;
        public Emprestimo emprestimo;

        public Locadora(string nome)
        {
            this.nome = nome;
            jogo = new Jogo();
            cliente = new Cliente();
            //emprestimo = new Emprestimo();

            Menu();
        }

        private void Menu()
        {
            int operacao = 0;
            int codigoJogo;
            int codigoCliente;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"-----------------------------------------------------------------");
                Console.WriteLine($"           .L.O.C.A.D.O.R.A.    {nome}                      ");
                Console.WriteLine($"-----------------------------------------------------------------");
                Console.WriteLine( "*****************************************************************");
                Console.WriteLine( "* Escolha a tela/classe?                                        *");
                Console.WriteLine( "* 1 - Cliente                                                   *");
                Console.WriteLine( "* 2 - Jogo                                                      *");
                Console.WriteLine( "* 3 - Emprestimo                                                *");
                Console.WriteLine( "* 4 - Devolução                                                 *");
                Console.WriteLine( "* 0 - Sair.                                                     *");
                Console.WriteLine( "*****************************************************************");
                Console.WriteLine();
        
                try
                {
                    Console.Write("Digite a operação: ");
                    operacao = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                }
                catch (Exception ex)
                {
                    Console.WriteLine();
                    Console.WriteLine("ERRO! INFORMACAO DIGITADA NÃO PREVISTA NO MENU.");
                    Console.WriteLine("Tente novamente.");
                    Console.ReadLine();
                    this.Menu();
                }

                switch (operacao)
                {
                    case 1:
                        this.cliente.Menu();
                        break;
                    case 2:
                        this.jogo.Menu();
                        break;
                    case 3:
                        codigoJogo = 1;
                        codigoCliente = 1;
                        Emprestimo emprestimoteste = new Emprestimo(codigoJogo, "20020618", "", 10, codigoCliente);
                        jogo.Locar(codigoJogo);
                        break;
                    case 4:
                        codigoJogo = 1;
                        codigoCliente = 1;
                        //emprestimoteste.DataDevolução("20020619");
                        jogo.Devolver(codigoJogo);
                        break;
                    default:
                        break;
                }
            } while (operacao != 0);
        }
    }
}
