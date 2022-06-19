namespace ExerciciosA8
{
    public class Cliente
    {
        string[] nome       = new string[10];
        string[] endereco   = new string[10];
        int[]    idade      = new int[10];
        double[] codigo     = new double[10];
        double[] telefone   = new double[10];

        public void Menu()
        {
            this.Cadastrar();
        }

        public void Cadastrar()
        {
            int proximoCodigo = -1;
            string nome;
            double telefone;
            int idade;
            string endereco;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine($"-----------------------------------------------------------------");
            Console.WriteLine($"                       .L.O.C.A.D.O.R.A.                         ");
            Console.WriteLine($"-----------------------------------------------------------------");
            Console.WriteLine($"*****************************************************************");
            Console.WriteLine($"********              :: C L I E N T E ::                ********");
            Console.WriteLine($"*****************************************************************");
            Console.WriteLine($"********            :: CADASTRAR CLIENTE ::              ********");
            Console.WriteLine($"*****************************************************************");
            Console.WriteLine();

            proximoCodigo = Array.IndexOf(this.codigo, 0);

            try
            {

                if (proximoCodigo >= 10)
                {
                    throw new IndexOutOfRangeException();
                }

                nome = "";
                idade = 0;
                telefone = 0;
                endereco = "";

                Console.WriteLine("PREENCHER");
                Console.WriteLine();

                this.codigo[proximoCodigo] = proximoCodigo + 1;

                Console.Write("Nome do Cliente: ");
                nome = Console.ReadLine();

                Console.Write("Telefone: ");
                telefone = double.Parse(Console.ReadLine());

                Console.Write("Endereço: ");
                endereco = Console.ReadLine();
                
                Console.Write("Idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine();
                if (nome != "" && idade > 0 && telefone != 0)
                {
                    this.idade[proximoCodigo] = idade;
                    this.telefone[proximoCodigo] = telefone;
                    this.nome[proximoCodigo] = nome;
                    this.endereco[proximoCodigo] = endereco;
                }
                else
                {
                    throw new InvalidDataException();
                }

                Console.WriteLine($"Cliente {this.codigo[proximoCodigo]} - {this.nome[proximoCodigo]} cadastrado com sucesso!");

                if (endereco == "")
                {
                    Console.WriteLine($"Cliente {this.codigo[proximoCodigo]} - {this.nome[proximoCodigo]} sem endereço.");
                }

                Console.WriteLine();
            }

            catch (InvalidDataException e)
            {
                Console.WriteLine();
                Console.WriteLine("Cliente não foi cadastrado. É necessário informar ao menos Nome, Idade e Telefone.");
                Console.WriteLine();
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine();
                Console.WriteLine("Não há mais capacidade de armazenamento no cadastro de clientes.");
                Console.WriteLine();
            }
            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine("Não foi possível cadastrar o cliente. Tente novamente.");
                Console.WriteLine($"{e}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }

    }
}
