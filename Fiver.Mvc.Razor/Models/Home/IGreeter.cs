namespace Fiver.Mvc.Razor.Models.Home
{
    public interface IGreeter
    {
        string Greet(string firstname, string surname);
    }

    public class Greeter : IGreeter
    {
        public string Greet(string firstname, string surname)
        {
            return $"Hello {firstname} {surname}";
        }
    }
}
