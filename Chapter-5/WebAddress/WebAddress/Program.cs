namespace WebAdress
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string userInput = Console.ReadLine() ?? "";
            int prevIndex = -1;

            string webAdress = "www.";
            userInput = userInput.Trim();
            
            
            for (int i = 0; i < userInput.Length; i++)
            {
                
                if (userInput[i] == ' ')
                {
                    webAdress += userInput.Substring(prevIndex + 1, i - prevIndex - 1);
                    prevIndex = i;
                }
                
            }

            webAdress += userInput.Substring(prevIndex + 1, userInput.Length - prevIndex - 1) + ".com";
            Console.WriteLine(webAdress);
            
        }
    }
}
