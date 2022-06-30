using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Turboaz code = new Turboaz();
            Console.WriteLine("Set Id for Turbo.az");
            code.Id = Console.ReadLine();
            Console.WriteLine("Set Email but it will remain private...");
            code.Email = Console.ReadLine();
            Console.WriteLine("Set Phone Number for Turbo.az users to reach you");
            code.PhoneNumber = Console.ReadLine();

            string item = string.Empty;
            Console.WriteLine("Do you want to create account by contact number or business, cn-contact number/b-business");
            item = Console.ReadLine();
            if (item=="cn")
            {
                ByContactNumber account = new ByContactNumber();
                Console.WriteLine("set Id for your account:");
                account.Id = Console.ReadLine();
                Console.WriteLine("Write your contact number:");
                account.ContactNumber = Console.ReadLine();
                Console.WriteLine("Set password:");
                account.Password = Console.ReadLine();
                Console.WriteLine("Do you want to change password? y-yes/n-no");
                string item2 = Console.ReadLine();
                if (item2=="y")
                {
                    Console.WriteLine("add new password");
                    string item3 = Console.ReadLine();
                    account.Changepassword(account.Password, item3);
                }
            }
            else if (item=="b")
            {
                ByBusiness Account = new ByBusiness();
                Console.WriteLine("set Id for your account:");
                Account.Id = Console.ReadLine();
                Console.WriteLine("Set email for your account:");
                Account.Email = Console.ReadLine();
            }
            Console.WriteLine("Do you want to sell something? y-yes/n-no");
            string item4 = Console.ReadLine();
            if (item4=="y")
            {
                Console.WriteLine("Are you an individual or company? i for individual/c for company");
                string item5 = Console.ReadLine();
                if (item5=="i")
                {
                    Individual person = new Individual();
                    Console.WriteLine("set Id for your individual account:");
                    person.Id= Console.ReadLine();
                    Console.WriteLine("Set email for your account:");
                    person.Email= Console.ReadLine();
                }
                else if (item5=="c")
                {
                    Company company = new Company();

                    Console.WriteLine("set Id for your company account:");
                    company.Id= Console.ReadLine();
                    Console.WriteLine("What is your location?");
                    company.Location= Console.ReadLine();
                    Console.WriteLine("Write contact info such as phone number, email etc.");
                    company.ContactInfo= Console.ReadLine();
                    Console.WriteLine("Write description for your company:");
                    company.Description= Console.ReadLine();
                    
                }
                Console.WriteLine("So, add your vehicle:");
                Vehicle newad = new Vehicle();
                Console.WriteLine("set Id for your vehicle:");
                newad.Id= Console.ReadLine();
                Console.WriteLine("Write description for your vehicle:");
                newad.Description= Console.ReadLine();
                Console.WriteLine("what is the name of brand");
                newad.BrandName= Console.ReadLine();
                Console.WriteLine("What is the name of Model");
                newad.ModelName = Console.ReadLine();
                Console.WriteLine("where is it originated from?");
                newad.City= Console.ReadLine();
                Console.WriteLine("When the vehicle is legally produced:");
                newad.YearofProduction= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is bantype?");
                newad.Bantype= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the colour of vehicle?");
                newad.Colour= Console.ReadLine();
                Console.WriteLine("Add the volume of the engine:");
                newad.EngineVolume= Console.ReadLine();
                Console.WriteLine("How powerful it is by means of horsepower: ");
                newad.HorsePower= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Add the type of the fuel:");
                newad.TypeofFuel= Console.ReadLine();
                Console.WriteLine("How much was it used?");
                newad.Mileage= Console.ReadLine();
                Console.WriteLine("Gearbox:");
                newad.Gearbox= Console.ReadLine();
                Console.WriteLine("where the transmitter is?");
                newad.Transmitter= Console.ReadLine();
                Console.WriteLine("Is it new or used?");
                newad.NewUsed = Console.ReadLine();
                Console.WriteLine("set the price:");
                newad.Price= Convert.ToInt32(Console.ReadLine());
            }



        }
    }
}
