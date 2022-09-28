namespace Tarea1;

public class Jugadores
{
    public List<Jugador> jugadores;

    public Jugadores()
    {
        listaJugadores();
        ElegirMazo();
    }
    
    public void listaJugadores()
    {
        jugadores = new List<Jugador>();
        for(int i = 0; i < 2; i++)
            jugadores.Add(new Jugador());
    }

    public void ElegirMazo()
    {
        PilaCartas cartas = new PilaCartas();
        foreach (var j in jugadores)
        {
            j.AgregarSuperstar(cartas.superstars);
            j.AgregarMazoPredeterminado(cartas.cartaList);
            j.repartirMano();
        }
        
    }

    public string QuienParte()
    {
        int numBase = 0;
        string parte = "empate, parte j1";
        int i = 1;
        foreach (var j in jugadores)
        {
            if (j.miSuperstar.starValue >= numBase)
            {
                numBase = j.miSuperstar.starValue;
                parte = "j" + i;
            }
            i++;
        }

        return parte;
    }
        
}