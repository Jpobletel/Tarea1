using System.Text.Json;
using Newtonsoft.Json;


namespace Tarea1;


public class PilaCartas
{
    private List<Superstar> _superstars;

    public PilaCartas()
    {
        GenerarSuperstars();
    }

    private void GenerarSuperstars()
    {
        string fileName = "superstars.json";
        
        
        string jsonString = File.ReadAllText(fileName);
        Console.WriteLine(jsonString);
        Superstar pain = JsonConvert.DeserializeObject<Superstar>(jsonString);
        Console.WriteLine(pain);


    }

}