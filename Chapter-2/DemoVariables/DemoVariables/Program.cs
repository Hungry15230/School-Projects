using static System.Console;
class DemoVariables
{
    static void Main()
    {
        int anInt = -123;
        uint anUnsignedInt = 567;
        WriteLine("The int is {0} and the unsigned int is {1}.", anInt, anUnsignedInt);

        double someMoney = 123;
        string moneyString;
        moneyString = someMoney.ToString("F");
        WriteLine(moneyString);
        moneyString = someMoney.ToString("F3");
        WriteLine(moneyString);

        double moneyValue = 456789;
        string conversion;
        conversion = moneyValue.ToString("C");
        WriteLine(conversion);

        double payAmount = 12345;
        WriteLine(payAmount.ToString("C"));


    }
}