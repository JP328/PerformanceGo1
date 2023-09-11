using ConsoleApp1.Controller;
using ConsoleApp1.Model;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? name, brand, description, gender, rules, acessories, typeOfGame;
            decimal price;
            int option = 0, type, id;

            BrinquedoController toys = new();


            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine(
                    "\n\n=============================== BEM VINDOS(AS) A FUNNYTOYS! ===========================================" +
                    "\n\n================== Digite uma opção dentre as apresentadas abaixo: ==================================" +
                    "\n1 - Cadastrar brinquedo" +
                    "\n2 - Listar brinquedos" +
                    "\n3 - Atualizar brinquedo inteiro" +
                    "\n4 - Apagar brinquedo" +
                    "\n5 - Sair" +
                    "\n====================================================================================================");

                try 
                {
                    do
                    {
                        option = Convert.ToInt32(Console.ReadLine());
                    } while (option < 1 && option > 6);

                    if (option == 5)
                    {
                        Console.WriteLine("\n\nObrigado pela visita, volte Sempre!\n");
                        System.Environment.Exit(0);
                        Console.ResetColor();
                    }

                    Console.Clear();
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("=============================== CADASTRO DE BRINQUEDO  =========================================");
                            Console.WriteLine("Digite o nome do brinquedo:");
                            name = Console.ReadLine();
                            name ??= string.Empty;

                            do
                            {
                                Console.WriteLine("Digite o tipo do brinquedo (1 - Bonecos(as) ou 2 - Jogos De Mesa):");
                                type = Convert.ToInt32(Console.ReadLine());
                            } while (type != 1 && type != 2);

                            Console.WriteLine("Digite o preço do brinquedo:");
                            price = Convert.ToDecimal(Console.ReadLine());

                            Console.WriteLine("Digite a marca do brinquedo:");
                            brand = Console.ReadLine();
                            brand ??= string.Empty;

                            Console.WriteLine("Digite a descrição do brinquedo:");
                            description = Console.ReadLine();
                            description ??= string.Empty;

                            if (type == 1)
                            {
                                Console.WriteLine("Digite o gênero do público alvo do boneco(a) (Masculino, Feminino ou Unisex): ");
                                gender = Console.ReadLine();
                                gender ??= string.Empty;

                                Console.WriteLine("Digite quais são os acessórios do boneco(a): ");
                                acessories = Console.ReadLine();
                                acessories ??= string.Empty;

                                toys.Register(new Boneco(toys.GenerateNumber(), type, name, brand, description, price, gender, acessories ));
                            }
                            else
                            {
                                Console.WriteLine("Digite o tipo do jogo de Mesa (tabuleiro ou Cartas): ");
                                typeOfGame = Console.ReadLine();
                                typeOfGame ??= string.Empty; 
                                
                                Console.WriteLine("Digite as regras do jogo de Mesa:");
                                rules = Console.ReadLine();
                                rules ??= string.Empty;

                                toys.Register(new JogoDeMesa(toys.GenerateNumber(), type, name, brand, description, price, typeOfGame, rules ));
                            }

                            break;
                        case 2:
                            //Chamar método listAll()
                            toys.ListAll();
                            break;
                        case 3:
                            Console.WriteLine("Digite o Id do brinquedo que deseja atualizar:");
                            id = Convert.ToInt32(Console.ReadLine());

                            var toy = toys.SearchInCollection(id);
           
                            if (toy == null)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"A brinquedo com id {id} não foi encontrada");
                                Console.ResetColor();
                            }
                            else
                            {
                                Console.WriteLine("Digite o nome do brinquedo:");
                                name = Console.ReadLine();
                                name ??= string.Empty;

                                Console.WriteLine("Digite o preço do brinquedo:");
                                price = Convert.ToDecimal(Console.ReadLine());

                                Console.WriteLine("Digite a marca do brinquedo:");
                                brand = Console.ReadLine();
                                brand ??= string.Empty;

                                Console.WriteLine("Digite a descrição do brinquedo:");
                                description = Console.ReadLine();
                                description ??= string.Empty;

                                if (toy.GetTypeOfToy() == 1)
                                    {
                                    Console.WriteLine("Digite o gênero do público alvo do boneco(a) (Masculino, Feminino ou Unisex): ");
                                    gender = Console.ReadLine();
                                    gender ??= string.Empty;

                                    Console.WriteLine("Digite quais são os acessórios do boneco(a): ");
                                    acessories = Console.ReadLine();
                                    acessories ??= string.Empty;

                                    //Atualizar objeto:
                                    toys.Update(new Boneco(toy.GetId(), toy.GetTypeOfToy(), name, brand, description, price, gender, acessories));
                                }
                                else
                                {
                                    Console.WriteLine("Digite o tipo do jogo de Mesa (tabuleiro ou Cartas:");
                                    typeOfGame = Console.ReadLine();
                                    typeOfGame ??= string.Empty;

                                    Console.WriteLine("Digite as regras do jogo de Mesa:");
                                    rules = Console.ReadLine();
                                    rules ??= string.Empty;

                                    toys.Update(new JogoDeMesa(toy.GetId(), toy.GetTypeOfToy(), name, brand, description, price, typeOfGame, rules));
                                }
                            }

                            break;
                        case 4:
                            Console.WriteLine("Digite o ID do brinquedo");
                            id = Convert.ToInt32(Console.ReadLine());

                            toys.Delete(id);
                            break;
                        //case 5:
                        //    break;
                    }
                } 
                catch(FormatException) 
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Escreva os dados dos brinquedos e demais entradas corretamente, conforme descrito no enunciado. Tente novamente.");
                    Console.ResetColor();
                }
            }
        }
    }
}