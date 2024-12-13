using static System.Console;

Write("Purchase Price: ");
string purchasePriceStr = ReadLine();
int  purchasePrice = Convert.ToInt32(purchasePriceStr);
if (purchasePrice > 8000)
{
    WriteLine("Denied");
} else
{
    WriteLine("Approved");
}