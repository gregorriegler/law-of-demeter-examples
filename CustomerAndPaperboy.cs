namespace CustomerAndPaperBoy;

public class Paperboy
{
    public void HandlePayment(Customer customer)
    {
        var wallet = customer.Wallet;
        var money = wallet.TakeOutMoney(2);
        AddToPocket(money);
    }

    private void AddToPocket(decimal money)
    {
        // logic to add money to own pocket
    }
}

public class Customer
{
    public Wallet Wallet { get; } = new();
}

public class Wallet
{
    public decimal TakeOutMoney(decimal amount)
    {
        // logic to take out money
        return 0;
    }
}