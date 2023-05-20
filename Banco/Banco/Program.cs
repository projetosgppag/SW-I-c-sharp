namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new("", "", "", 0, 0);

            Console.WriteLine("----- Bem-vindo ao Banco ------");
            Console.WriteLine("<<<<< Selecione uma opcao >>>>>");
            Console.WriteLine("- 1   Cadastrar novo user     -");
            Console.WriteLine("- 2   Login                   -");
            Console.WriteLine("- 0   Sair                    -");
            Console.WriteLine("-------------------------------");

            bool exit = false;

            while (!exit)
            {
                Console.Write("> ");
                string option = Console.ReadLine();
                Console.WriteLine();
                switch (option)
                {
                    case "1":
                        user.Register();
                        break;
                    case "2":
                        bool loggedIn = user.Login();
                        if (loggedIn)
                        {
                            Console.WriteLine("<<<<< Selecione uma opcao >>>>>");
                            Console.WriteLine("- 1   Realizar Saque          -");
                            Console.WriteLine("- 2   Realizar Deposito       -");
                            Console.WriteLine("- 3   Solicitar Emprestimo    -");
                            Console.WriteLine("- 0   Sair                    -");
                            Console.WriteLine("-------------------------------");

                            bool loggedOut = false;
                            while (!loggedOut)
                            {
                                Console.Write("> ");
                                string userOption = Console.ReadLine();
                                Console.WriteLine();

                                switch (userOption)
                                {
                                    case "1":
                                        user.Saque();
                                        break;
                                    case "2":
                                        user.Deposito();
                                        break;
                                    case "3":
                                        user.Emprestimo();
                                        break;
                                    case "0":
                                        loggedOut = true;
                                        Console.WriteLine("Logoff");
                                        break;
                                    default:
                                        Console.WriteLine("[ERRO INPUT INVALIDO]");
                                        Console.WriteLine();
                                        break;
                                }
                            }
                        }
                        break;
                    case "0":
                        exit = true;
                        Console.WriteLine("byebye");
                        break;
                    default:
                        Console.WriteLine("[ERRO INPUT INVALIDO]");
                        Console.WriteLine();
                        break;
                }

            }
        }
    }
}