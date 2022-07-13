namespace WebAPIClient;

public class Weather
{
    public int id { get; set; }
    public string main { get; set; }
    public string description { get; set; }
    public string icon { get; set; }
    
    public int UserChoice()
    {
        int x;
        Console.Write("Rentrez le numéro de la ville: ");
        while (!int.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Incorrect number");
            Console.Write("Rentrez le numéro de la ville:  ");
        }

        return x;
    }
    
    public void DisplayNameCities(Tuple<int, string, double, double>[] map)
    {
        Console.WriteLine("Choisir une ville : écrivez son numéro ! ");
        var i = 0;
        foreach (var ville in map)
        {
            i++;
            Console.WriteLine($"{i} ) {ville.Item2}");
        }
    }
    
    
}