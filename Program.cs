public class Account
{
    private decimal balance = 0;
    public decimal Balance
    {
        get { return balance; }
    }
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            balance += amount;
            Console.WriteLine($"Пополнение на {amount} | баланс: {balance}");
        }
        else
        {
            Console.WriteLine("Сумма пополнения меньше нуля.");
        }
    }
    public void Withdraw(decimal amount)
    {
        if (amount > 0)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"Снятие {amount} | баланс: {balance}");
            }
            else
            {
                Console.WriteLine($"Недостаточно средств. (Баланс: {balance} - запрос: {amount})");
            }
        }
        else
        {
            Console.WriteLine("Сумма снятия меньше нуля.");
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        var acc = new Account();
        acc.Deposit(1000);
        acc.Withdraw(300);

        Console.WriteLine(acc.Balance);
    }
}