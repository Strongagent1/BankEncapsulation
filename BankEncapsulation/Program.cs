using System.Security.Cryptography.X509Certificates;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var custAccount = new BankAccount();
          
            Console.WriteLine("Please type the amount of your deposit and press enter to recieve your balance");

            var depAmnt = (Console.ReadLine());
            var depAmnt2 = Convert.ToDouble(depAmnt);

            custAccount.Deposit(depAmnt2);

            Console.WriteLine($"Your deposit is {depAmnt2} dollars and that " +
                $"brings the total balance to ${custAccount.GetBalance()} ");
           

        }
    }
}
