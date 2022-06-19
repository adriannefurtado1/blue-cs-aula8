
namespace ExerciciosA8
{
    public class Jogo
    {
        string[] nome        = new string[10];
        string[] genero      = new string[10];
        int[]    classEtaria = new int[10];
        double[] codigo      = new double[10];
        double[] anoLancam   = new double[10];
        bool[]   emprestado  = new bool[10];

        public void Menu()
        {
            int operacao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"-----------------------------------------------------------------");
                Console.WriteLine($"                       .L.O.C.A.D.O.R.A.                         ");
                Console.WriteLine($"-----------------------------------------------------------------");
                Console.WriteLine( "*****************************************************************");
                Console.WriteLine( "********                 :: J O G O ::                   ********");
                Console.WriteLine( "*****************************************************************");
                Console.WriteLine( "*****************************************************************");
                Console.WriteLine( "* Escolha a operação?                                           *");
                Console.WriteLine( "* 1 - Cadastrar                                                 *");
                Console.WriteLine( "* 2 - Pesquisar Jogo                                            *");
                Console.WriteLine( "* 3 - Listar Jogos Cadastrados                                  *");
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
                        this.Cadastrar();
                        break;
                    case 2:
                        this.ImprimirInformações();
                        break;
                    case 3:
                        this.ListarJogos();
                        break;
                    default:
                        break;
                }

            } while (operacao != 0);
        }

        public void Cadastrar()
        {
            int proximoCodigo = -1;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"-----------------------------------------------------------------");
            Console.WriteLine($"                       .L.O.C.A.D.O.R.A.                         ");
            Console.WriteLine($"-----------------------------------------------------------------");
            Console.WriteLine($"*****************************************************************");
            Console.WriteLine($"********                 :: J O G O ::                   ********");
            Console.WriteLine($"*****************************************************************");
            Console.WriteLine($"********              :: CADASTRAR JOGO ::               ********");
            Console.WriteLine($"*****************************************************************");
            Console.WriteLine();

            proximoCodigo = Array.IndexOf(this.codigo, 0);

            try 
            {

                if (proximoCodigo >= 10)
                {
                    throw new IndexOutOfRangeException();
                }

                Console.WriteLine("PREENCHER");
                Console.WriteLine();

                this.codigo[proximoCodigo] = proximoCodigo + 1;
                
                Console.Write("Nome do Jogo: ");
                this.nome[proximoCodigo] = Console.ReadLine();
                
                Console.Write("Genero: ");
                this.genero[proximoCodigo] = Console.ReadLine();
                
                Console.Write("Classificação Etária: ");
                this.classEtaria[proximoCodigo] = int.Parse(Console.ReadLine());
                
                 Console.Write("Ano Lançamento: ");
                this.anoLancam[proximoCodigo] = double.Parse(Console.ReadLine());

                this.emprestado[proximoCodigo] = false;

                Console.WriteLine();
                Console.WriteLine($"Jogo {this.codigo[proximoCodigo]} - {this.nome[proximoCodigo]} cadastrado com sucesso!");
                Console.WriteLine();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine();
                Console.WriteLine("Não há mais espaços nessa locadora para armazenar jogos.");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Não foi possível cadastrar o jogo. Tente novamente.");
                Console.WriteLine($"{e}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        public void ImprimirInformações()
        {
            double codigoPesquisa;
            string nomePesquisa;
            string emprestadoSN;
            int indicePesquisa = -1;
            int operacao = 0;
            bool locarJogo = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"-----------------------------------------------------------------");
            Console.WriteLine($"                       .L.O.C.A.D.O.R.A.                         ");
            Console.WriteLine($"-----------------------------------------------------------------");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("********                 :: J O G O ::                   ********");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("********         :: VER INFORMACOES DO JOGO ::           ********");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("* Escolha a operação?                                           *");
            Console.WriteLine("* 1 - Código                                                    *");
            Console.WriteLine("* 2 - Nome                                                      *");
            Console.WriteLine("* 0 - Sair.                                                     *");
            Console.WriteLine("*****************************************************************");
            Console.WriteLine();

            try
            {
                Console.Write("Digite a operação: ");
                operacao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (operacao < 0 || operacao > 2)
                {
                    throw new ArgumentException();
                }        
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine();
                Console.WriteLine("ERRO! OPÇÃO INVÁLIDA.");
                Console.WriteLine("Tente novamente.");
                Console.ReadLine();
                this.ImprimirInformações();
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine("ERRO! INFORMACAO DIGITADA NÃO PREVISTA NO MENU.");
                Console.WriteLine("Tente novamente.");
                Console.ReadLine();
                this.Menu();
            }

            try
            {

                Console.WriteLine("DIGITE");
                Console.WriteLine();

                switch (operacao)
                {
                    case 1:
                        Console.Write("Código Jogo: ");
                        codigoPesquisa = double.Parse(Console.ReadLine());
                        indicePesquisa = Array.IndexOf(this.codigo, codigoPesquisa);
                        break;
                    case 2:
                        Console.Write("Nome do Jogo: ");
                        nomePesquisa = Console.ReadLine();
                        indicePesquisa = Array.IndexOf(this.nome, nomePesquisa);
                        break;
                }

                if(indicePesquisa >= 0)
                {
                    emprestadoSN = emprestado[indicePesquisa] ? "Emprestado" : "Disponível";

                    Console.WriteLine();
                    Console.WriteLine($"Código:         {this.codigo[indicePesquisa]}");
                    Console.WriteLine($"Nome do Jogo:   {this.nome[indicePesquisa]}");
                    Console.WriteLine($"Genero:         {this.genero[indicePesquisa]}");
                    Console.WriteLine($"Class. Etária:  {this.classEtaria[indicePesquisa]}");
                    Console.WriteLine($"Lançamento:     {this.anoLancam[indicePesquisa]}");
                    Console.WriteLine($"Situacao:       {emprestadoSN}");
                    Console.WriteLine();
                }
                else
                {
                    throw new KeyNotFoundException();
                }

            }
            catch (KeyNotFoundException e)
            {
                Console.WriteLine();
                Console.WriteLine("Não foi possível encontrar esse jogo no cadastro. Tente novamente.");
                Console.WriteLine($"{e}");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Não foi possível mostrar os dados do jogo. Tente novamente.");
                Console.WriteLine();
            }
            Console.ReadLine();


        }

        public void ListarJogos()
        {

            Console.WriteLine("Código - Nome");
            
            for(int i = 0; i < this.codigo.Length; i++)
            {
                if (this.codigo[i] != 0)
                {
                    Console.WriteLine($"{this.codigo[i]} - {this.nome[i]}");
                }
            }
            Console.ReadLine();
        }

        public void Locar(double Codigo)
        {
            int indicePesquisa = Array.IndexOf(this.codigo, Codigo);
            this.emprestado[indicePesquisa] = true;
        }

        public void Devolver(double Codigo)
        {
            int indicePesquisa = Array.IndexOf(this.codigo, Codigo);
            this.emprestado[indicePesquisa] = false;
        }
    }
}
