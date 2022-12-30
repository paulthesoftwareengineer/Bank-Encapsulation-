public class BankAccount
{
    // Private field to store the balance
    private double balance = 0;

    // Method to accept a double and store it in the balance field
    public void Deposit(double amount)
    {
        balance += amount;
    }

    // Method to return the amount stored in the balance field
    public double GetBalance()
    {
        return balance;
    }
}

// In the main method of your application
static void Main(string[] args)
{
    // Create a new instance of the BankAccount class
    BankAccount account = new BankAccount();

    // Allow the user to deposit money
    Console.WriteLine("Enter the amount to deposit:");
    double amount = double.Parse(Console.ReadLine());
    account.Deposit(amount);

    // Retrieve the balance
    double balance = account.GetBalance();
    Console.WriteLine($"Your balance is: {balance}");
}
