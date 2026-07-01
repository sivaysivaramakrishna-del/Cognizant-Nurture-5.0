// C# Exercise 15
PaymentProcessor[] payments =
[
    new CreditCardPayment("TXN-1001", 2500m),
    new UpiPayment("TXN-1002", 899m)
];

Console.WriteLine("Abstract Classes and Interfaces — Payment System\n");

foreach (var payment in payments)
{
    payment.ProcessPayment();
    payment.PrintReceipt();

    if (payment is IRefundSupported refundable)
        refundable.IssueRefund(100m);

    Console.WriteLine();
}

abstract class PaymentProcessor(string transactionId, decimal amount)
{
    public string TransactionId { get; } = transactionId;
    public decimal Amount { get; } = amount;

    public abstract void ProcessPayment();

    public void PrintReceipt() =>
        Console.WriteLine($"Receipt -> {TransactionId} | Amount Paid: ${Amount:F2}");
}

interface IRefundSupported
{
    void IssueRefund(decimal refundAmount);
}

class CreditCardPayment(string transactionId, decimal amount)
    : PaymentProcessor(transactionId, amount), IRefundSupported
{
    public override void ProcessPayment() =>
        Console.WriteLine($"Credit card charged ${Amount:F2} for {TransactionId}");

    public void IssueRefund(decimal refundAmount) =>
        Console.WriteLine($"Refund of ${refundAmount:F2} initiated to credit card.");
}

class UpiPayment(string transactionId, decimal amount) : PaymentProcessor(transactionId, amount)
{
    public override void ProcessPayment() =>
        Console.WriteLine($"UPI payment of ${Amount:F2} completed for {TransactionId}");
}
