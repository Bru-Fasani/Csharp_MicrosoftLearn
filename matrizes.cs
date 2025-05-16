/*string[] fraudlentOrdersIDs = new string[3];
fraudlentOrdersIDs[0] = "A123";
fraudlentOrdersIDs[1] = "B456";
fraudlentOrdersIDs[2] = "C789";
fraudlentOrdersIDs[3] = "D000";

string [] fraudlentOrdersIDs = [ "A123", "B456", "C789"];

Console.WriteLine($"First: {fraudlentOrdersIDs[0]}");
Console.WriteLine($"Second: {fraudlentOrdersIDs[1]}");
Console.WriteLine($"Third: {fraudlentOrdersIDs[2]}");

fraudlentOrdersIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudlentOrdersIDs[0]}");

Console.WriteLine($"There are {fraudlentOrdersIDs.Length} fraudulent orders to process.");*/

//exercio 2

int[] inventory = {200, 450,700,175,250};

int sum = 0;
int bin = 0;
foreach (int item in inventory)
{
   sum += item;
   bin++;
   Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
