using System.Text.Json;
using Newtonsoft.Json;


namespace Tarea1;


public class PilaCartas
{
    private List<Superstar> _superstars = new List<Superstar>();

    public PilaCartas()
    {
        GenerarSuperstars();
    }

    private void GenerarSuperstars()
    {
        _superstars.Add( new Superstar("STONECOLD", 7, 5,
            "Once during your turn, you may draw a card, but you must then take a card from your hand and place it on the bottom of your Arsenal."));
        
        _superstars.Add(new Superstar("THEUNDERTAKER", 6, 4,
            "Once during your turn, you may discard 2 cards to the Ringside pile and take 1 card from the Ringside pile and place it into your hand."));
        
        _superstars.Add(new Superstar("MANKING", 2, 4,
            "You must always draw 2 cards, if possible, during your draw segment. All damage from opponent is at -1D."));
        
        _superstars.Add(new Superstar("HHH", 10, 3,
            "None"));
        
        _superstars.Add(new Superstar("THEROCK", 5, 5,
            "At the start of your turn, before your draw segment, you may take 1 card from your Ringside pile and place it on the bottom of your Arsenal."));
        
        _superstars.Add(new Superstar("KANE", 7, 2,
            "At the start of your turn, before your draw segment, opponent must take the top card from his Arsenal and place it into his Ringside pile."));
        
        _superstars.Add(new Superstar("CHRISJERICHO", 7, 3,
            "Once during your turn, you may discard a card from your hand to force your opponent to discard a card from his hand."));

        foreach (var VARIABLE in _superstars)
        {
            Console.WriteLine(VARIABLE.GetName());
        }

    }

}