namespace CustomerAndPaperBoy2;

public class Paperboy
{
    public void HandlePayment(Customer customer)
    {
        var money = customer.RequestPayment(2);
        AddToPocket(money);
    }

    private void AddToPocket(decimal money)
    {
        // logic to add money to own pocket
    }
}

public class Customer
{
    private readonly Wallet _wallet = new();

    public decimal RequestPayment(int i)
    {
        return _wallet.TakeOutMoney(2);
    }
}

public class Wallet
{
    public decimal TakeOutMoney(decimal amount)
    {
        // logic to take out money
        return 0;
    }
}