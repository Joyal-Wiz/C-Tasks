using System;


interface IPayment {
    void Pay(double amount);
}

abstract class Payment {
    protected string PaymentName;

    public abstract void ProcessPayment(double amount);

    public void ShowPaymentType() {
        Console.WriteLine("Payment Type: " + PaymentName);
    }
}

class CardPayment : Payment, IPayment
{
    public CardPayment()
    {
        PaymentName = "Card Payment";
    }
    public void Pay(double amount)
    {
        Console.WriteLine($"Paying {amount} using card...");
        ProcessPayment(amount);
    }

    public override void ProcessPayment(double amount)
    {
        Console.WriteLine($"Processing card payment of {amount}");
    }
}


class Program
{
    static void Main(string[] args)
    {
        CardPayment payment = new CardPayment();

        payment.ShowPaymentType();
        payment.Pay(500);
    }
}