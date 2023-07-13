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
            //int option = 0;
           // userCRUD.AddUser(new User { UserId=101,UserName="admin",Password="admin101",ContactNo="2536495",RoleId=1});

          
                User user = new User();
               // Role role = new Role();
                Console.WriteLine("Login.... ");
                Console.Write("Enter user Id");
                user.UserId= Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter Password");
                user.Password= Console.ReadLine();
                int input = userCRUD.Login(user.UserId, user.Password);
               currentId = user.UserId;

            if (input == 0)
            {
                Console.WriteLine("Invalid Entry");
            }
            else if (input == 1)
            {
                Console.WriteLine("Welcome Admin");
                Console.WriteLine("1: Add User");
                Console.WriteLine("2: LogOut");
                int op = Convert.ToInt32(Console.ReadLine());


                switch (op)
                {
                    /********* Add User *******/
                    case 1:
                        User u1 = new User();
                        Bank bank = new Bank();
                        Console.Write("Enter your user id:");
                        u1.UserId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter Passward:");
                        u1.Password = Console.ReadLine();
                        Console.Write("Enter User Name:");
                        u1.UserName = Console.ReadLine();
                        Console.WriteLine("User Account No:");
                        bank.AccountNo=Convert.ToInt32(Console.ReadLine());
                        userCRUD.AddUser(u1);
                        break;
                    case 2:
                        break;
                }
            }
            else if(input == 2)
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
                int op1= Convert.ToInt32(Console.ReadLine());
                switch (op1)
                {
                    /***************** Credit *********************/
                    case 1:
                        BankCRUD crd = new BankCRUD();
                        crd.Credit(currentId, 1000,500);
                        break;

                    /************* Debit **************************/
                        case 2:
                        BankCRUD crd1 =new BankCRUD();
                        crd1.Debit(currentId, 1500,200);
                        break;

                    /******************** View Balance ******************/
                    case 3:
                        BankCRUD crd2 =new BankCRUD();
                        crd2.ViewBalance(currentId, 1300);
                        break;

                    /************************ Account Details ********************/
                    case 4:
                        BankCRUD crd3 =new BankCRUD();
                        crd3.AccountDetails(currentId);
                        break;
                    /************************** Add Payee ************************/
                    case 5:

                        break;
                }
            }
            
                   
                




           


            //BankCRUD bankCRUD = new BankCRUD();
            //int option = 0;
            //do
            //{
            //    Console.Write("1: Login\n");
            //    Console.Write("2: Admin\n");
            //    Console.Write("3: User\n");
            //    Console.Write("4: Credit\n");
            //    Console.Write("5: Debit\n");
            //    Console.Write("6: Check Balance\n");
            //    Console.Write("7: Add Payee\n");
            //    Console.Write("8: Transfer Amount\n");
            //    Console.Write("9: Log Out\n");
            //    Console.WriteLine("***********************************");
            //    Console.WriteLine("Enter your option:");
            //    int op = Convert.ToInt32(Console.ReadLine());

            //    switch (op)
            //    {
            //        case 1:

            //            /************ Login ******************/
            //            User u2 = new User();
            //            int Count = 0;
            //            do
            //            {
            //                Console.Write("\nEnter User Id:");
            //                u2.UserId = Convert.ToInt32(Console.ReadLine());

            //                Console.Write("\nEnter password:");
            //                u2.Password = Console.ReadLine();

            //                if (u2.UserId != 1234 || u2.Password != "abcd")
            //                {
            //                    Count++;
            //                }
            //                else
            //                {
            //                    Count = 1;
            //                }
            //            }
            //            while ((u2.UserId != 1234 || u2.Password != "abcd") && (Count != 3));

            //            if (Count == 3)
            //            {
            //                Console.Write("\nLogin attempt Three or more time try after some time......\n");
            //            }
            //            else
            //            {
            //                Console.Write("\nLogin Successfuly\n");
            //            }
            //            userCRUD.Login(u2 as User);
            //            break;


            //        case 2:
            //            /************* AddAccount*******************/

            //            Bank b1 = new Bank();
            //            User u = new User();
            //            Console.Write("Enter Account No:\n");
            //            b1.AccountNo = Convert.ToInt32(Console.ReadLine());
            //            Console.Write("Enter Account holder name:\n");
            //            u.UserName = Console.ReadLine();
            //            Console.Write("Enter Account holder contact number:\n");
            //            u.ContactNo= Convert.ToInt32(Console.ReadLine());
            //            Console.Write("Enter Account Type:\n");
            //            b1.AccountType=Console.ReadLine();
            //            Console.Write("Enter Account Balance:\n");
            //            b1.AccountBalance=Convert.ToDouble(Console.ReadLine());
            //            userCRUD.AddUser(u);
            //            bankCRUD.AddAccount(b1 as Bank);
            //            break;

            //        case 3:
            //            /*********** AddUser ************/

            //            User u1 = new User();
            //            Console.Write("Enter your user id:");
            //            u1.UserId = Convert.ToInt32(Console.ReadLine());
            //            Console.Write("Enter Passward:");
            //            u1.Password = Console.ReadLine();
            //            Console.Write("Enter User Name:");
            //            u1.UserName = Console.ReadLine();
            //            Console.Write("Enter your contact No:\n");
            //            u1.ContactNo = Convert.ToInt32(Console.ReadLine());
            //           // Console.Write("Enter Role Id:");
            //            //role.Id = Convert.ToInt32(Console.ReadLine());

            //            userCRUD.AddUser(u1);

            //            break;
            //        case 4:
            //            /********************* Credit **************************/
            //            Bank bank = new Bank();
            //            bank.AccountBalance = Convert.ToDouble(Console.ReadLine());
            //            bank.Money = Convert.ToDouble(Console.ReadLine());
            //            bank.AccountBalance += bank.Money;
            //            Console.WriteLine(bank.AccountBalance);
            //            bankCRUD.AddAccount(bank);
            //            break;
                    
                    
            //        case 5:
            //            Bank b = new Bank();
            //            Role role = new Role(1234,"admin");
            //            role = new Role(123, "User");
            //            Console.Write("Enter Role Name:\n");
            //            role.Name = Console.ReadLine();
            //            Console.Write("Enter Role Id:");
            //            role.Id = Convert.ToInt32(Console.ReadLine());
            //            if(role.Name == "admin")
            //            {
                            
            //            }
            //            break;




            //        case 6:
            //            break;
            //        case 7:
            //            break;
            //        case 8:
            //            break;
            //        case 9:
            //            /************** LogOut ********************/
            //            User u3 = new User();
            //            Console.Write("Enter your Id for Logout");
            //            u3.UserId = Convert.ToInt32(Console.ReadLine());
            //            Console.Write("Log Out!!!!!\n"); 
                       
            //               break;
            //    }
            //    Console.WriteLine("Press 0 for continue");
            //    option=Convert.ToInt32(Console.ReadLine());
            //}
            //while (option==0);




        }
    }
}
























            ////Login Process

            //string UserId, Password;
            //int Count = 0;

            //Console.WriteLine("**********************************");
            //Console.WriteLine("Login...........");
            //Console.WriteLine("**********************************");

            //do
            //{
            //    Console.Write("Enter UserId:");

            //    UserId = Console.ReadLine();

            //    Console.Write("Enter Password:");

            //    Password = Console.ReadLine();

            //    if ((UserId != "admin" && Password != "admin")|| (UserId != "customer" && Password != "customer"))
            //    {
            //        Console.WriteLine("Logged in as Admin");
            //        Count++;
            //    }
            //   //else if (UserId != "customer" && Password != "customer")
            //   // {
            //   //     Console.WriteLine("Welcome User");
            //   //     Count++;
            //   // }
            //    else
            //    {
            //        Count = 1;
            //    }

            //}
            //while ((UserId != "admin" && Password != "admin") || ((UserId != "customer" && Password != "customer")) && (Count != 3));

            //if(Count==3)

            //    Console.Write("\nLogin attemp three or more times. Try later!\n\n");
            //    else
            //    Console.Write("\nThe password entered successfully!\n\n");




    //    }
    //}
//}
