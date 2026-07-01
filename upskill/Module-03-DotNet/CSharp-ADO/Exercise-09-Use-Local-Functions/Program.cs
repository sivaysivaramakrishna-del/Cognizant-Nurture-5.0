// C# Exercise 9
decimal[] orderItems = [250.00m, 120.50m, 89.99m];

Console.WriteLine("Order Processing with Local Functions\n");
Console.WriteLine($"Items: {string.Join(", ", orderItems.Select(price => $"${price:F2}"))}");
Console.WriteLine($"Subtotal:        ${orderItems.Sum():F2}");
Console.WriteLine($"Final payable:   ${CalculateOrderTotal(orderItems):F2}");

static decimal CalculateOrderTotal(decimal[] items)
{
    decimal ApplyBulkDiscount(decimal amount) =>
        amount >= 300m ? amount * 0.95m : amount;

    decimal AddServiceCharge(decimal amount) =>
        amount + 25m;

    decimal subtotal = items.Sum();
    decimal discountedAmount = ApplyBulkDiscount(subtotal);
    return AddServiceCharge(discountedAmount);
}
