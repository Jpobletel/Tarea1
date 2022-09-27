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
            //j.AgregarMazoPredeterminado(cartas.cartaList);
            //j.repartirMano();
            //j.MostrarMano();
        }
        
    }

    public Jugador ObtenerJugador(int idJugador) => jugadores[idJugador];
}