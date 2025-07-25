int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($" Shares: {productShares:N3} Product");
Console.WriteLine($"  Sub Total: {subtotal:C}");
Console.WriteLine($"   Tax: {taxPercentage:P2}");
Console.WriteLine($"    Total Billed: {total:C}");

//console:
//Invoice Number: 1201
// Shares: 25,457 Product
//  Sub Total: R$ 2.750,00
//   Tax: 15,83%
//    Total Billed: R$ 3.185,19
