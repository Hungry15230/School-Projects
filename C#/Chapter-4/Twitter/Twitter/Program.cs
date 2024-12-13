Console.WriteLine("Write your post:");
string userPost = Console.ReadLine();
bool postIsShortEnough = userPost.Length <= 140;
if (postIsShortEnough)
{
    Console.WriteLine("Approved.");
} else
{
    Console.WriteLine("Denied - Longer than 140 chars.");
}