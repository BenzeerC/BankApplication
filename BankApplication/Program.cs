using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Program
    {
        static void Main(string[] args)
        {
            int currentId = 0;
            UserCRUD userCRUD = new UserCRUD();
            int option = 0;
            int option1 = 0;
            // userCRUD.AddUser(new User { UserId=101,UserName="admin",Password="admin101",ContactNo="2536495",RoleId=1});

           
                User user = new User();
                // Role role = new Role();
                Console.WriteLine("Login.... ");
                Console.Write("Enter user Id:");
                user.UserId = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nEnter Password:");
                user.Password = Console.ReadLine();
                int input = userCRUD.Login(user.UserId, user.Password);
                currentId = user.UserId;
            do
            {
                if (input == 0)
                {
                    Console.WriteLine("Invalid Entry");
                }
                else if (input == 1)
                {
                    Console.Write("Welcome Admin\n");
                    Console.Write("\n1: Add User");
                    Console.Write("\n2: LogOut");
                    int op = Convert.ToInt32(Console.ReadLine());


                    switch (op)
                    {
                        /********* Add User *******/
                        case 1:
                            User u1 = new User();
                            Bank bank = new Bank();
                            Console.Write("Enter your user id:\n");
                            u1.UserId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Passward:\n");
                            u1.Password = Console.ReadLine();
                            Console.Write("Enter User Name:\n");
                            u1.UserName = Console.ReadLine();
                            Console.Write("User Account No:\n");
                            bank.AccountNo = Convert.ToInt32(Console.ReadLine());
                            userCRUD.AddUser(u1);
                            
                            

                            break;
                        case 2:
                            User u2 = new User();
                            userCRUD.Logout();
                            break;
                    }
                }
                Console.WriteLine("Press 1 to continue......");
                option = Convert.ToInt32(Console.ReadLine());

            }
            while (option == 1);


            do
            {
                
            
            
              if (input == 2)
                {
                    Console.WriteLine("Welcome User");
                    Console.WriteLine("1: Credit");
                    Console.WriteLine("2: Debit");
                    Console.WriteLine("3: View Balance");
                    Console.WriteLine("4: Account Details");
                    Console.WriteLine("5: Add Payee");
                    Console.WriteLine("6: Fund Transfer");
                    Console.WriteLine("7: Remove Payee");
                    Console.WriteLine("8: Log Out");
                    int op1 = Convert.ToInt32(Console.ReadLine());
                    switch (op1)
                    {
                        /***************** Credit *********************/
                        case 1:
                            BankCRUD crd = new BankCRUD();
                            crd.Credit(currentId, 1000, 500);
                            break;

                        /************* Debit **************************/
                        case 2:
                            BankCRUD crd1 = new BankCRUD();
                            crd1.Debit(currentId, 1500, 200);
                            break;

                        /******************** View Balance ******************/
                        case 3:
                            BankCRUD crd2 = new BankCRUD();
                            crd2.ViewBalance(currentId, 1300);
                            break;

                        /************************ Account Details ********************/
                        case 4:
                            BankCRUD crd3 = new BankCRUD();
                            crd3.AccountDetails(currentId);
                            break;
                        /************************** Add Payee ************************/
                        case 5:
                            BankCRUD crd4 = new BankCRUD();
                            crd4.AddPayee(currentId, "Sonal", 4563295);
                            break;

                        /************************ Transfer fund **************************/
                        case 6:
                            BankCRUD crd5 = new BankCRUD();
                            crd5.FundTransfer(currentId, 500, 4563295);
                            break;

                        /*********************** Remove Payee ***************************/
                        case 7:
                            BankCRUD crd6 = new BankCRUD();
                            crd6.RemovePayee(currentId,4563265);
                            break;

                        /********************** Log Out ***********************************/
                        case 8:
                            //BankCRUD crd7 = new BankCRUD();
                            //User user1 = new User();
                            //crd7.LogOut(currentId);
                            User u2 = new User();
                            userCRUD.Logout();

                            break;
                            
                    }




                }
                Console.WriteLine("Press 1 to continue......");
                option1 = Convert.ToInt32(Console.ReadLine());

            }
            while (option1 == 1);






        }
    }
}
