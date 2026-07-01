// C# Exercise 7
Console.WriteLine("Billing Calculator — Method Overloading Demo\n");

Console.WriteLine($"Two line items:       ${BillingCalculator.CalculateTotal(499.99m, 149.99m):F2}");
Console.WriteLine($"Three line items:     ${BillingCalculator.CalculateTotal(120.00m, 80.00m, 50.00m):F2}");
Console.WriteLine($"Subtotal with 10% off:${BillingCalculator.CalculateTotal(1000.00m, 10):F2}");

static class BillingCalculator
{
    public static decimal CalculateTotal(decimal itemPrice, decimal serviceFee) =>
        itemPrice + serviceFee;

    public static decimal CalculateTotal(decimal priceA, decimal priceB, decimal priceC) =>
        priceA + priceB + priceC;

    public static decimal CalculateTotal(decimal subtotal, int discountPercent) =>
        subtotal - (subtotal * discountPercent / 100m);
}
