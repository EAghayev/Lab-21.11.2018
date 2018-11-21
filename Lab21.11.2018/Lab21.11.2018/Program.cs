using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21._11._2018
{
    class Program
    {
        static void Main(string[] args)
        {
            User usr = new User("Cavid", "Nebili");
            byte secim;
            do
            {
                Console.WriteLine("1.Qeydiyyatdan kec");
                Console.WriteLine("2.Sisteme daxil ol");
                Console.WriteLine("3.Sifreni yenile");
                Console.WriteLine("4.Sistemden cixis");
                Console.WriteLine("0.Cix");
                string secimStr = Console.ReadLine();
                while (!byte.TryParse(secimStr, out secim))
                {
                    secimStr = Console.ReadLine();
                }
                switch (secim)
                {
                    case 1:
                        Console.Write("Username:");
                        string username = Console.ReadLine();
                        Console.Write("Password:");
                        string password = Console.ReadLine();
                        usr.SignUp(username, password);
                        Console.WriteLine("==========================");
                        break;
                    case 2:
                        Console.Write("Username:");
                         username = Console.ReadLine();
                        Console.Write("Password:");
                         password = Console.ReadLine();
                        if (usr.Username == username && usr.ConfirmPass(password))
                        {
                            usr.Loggined = true;
                            Console.WriteLine("Sisteme daxil oldunuz");
                        }
                        else
                        {
                            Console.WriteLine("Bu ne herektdir!");
                        }
                        Console.WriteLine("==========================");

                        break;
                    case 3:
                        if (usr.Loggined == true)
                        {
                            Console.Write("Last Password:");
                            string lastPass = Console.ReadLine();
                            Console.Write("New Password:");
                            string newPass = Console.ReadLine();
                            if (usr.ResetPass(lastPass, newPass))
                            {
                                Console.WriteLine("Sifreniz yenilendi");
                            }
                            else
                            {
                                Console.WriteLine("Bu ne herektdir!");
                            }
                        }
                        Console.WriteLine("==========================");

                        break;
                    case 4:
                        if (usr.Loggined == true)
                        {
                            usr.Loggined = false;
                            Console.WriteLine("sistemden cixis etdiniz");
                        }
                        Console.WriteLine("==========================");
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("==========================");
                        Console.WriteLine("Seciminiz duz etmediniz");
                        Console.WriteLine("==========================");
                        break;
                }
            }
            while (secim != 0);
            Console.ReadKey();
        }
    }
}
