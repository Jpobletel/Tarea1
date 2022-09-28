namespace Tarea1;

public class Turnos
{
    private bool gano = false;

    public void iniciarJuego()
    {
        Jugadores jugadorLista = new Jugadores();
        string parte = jugadorLista.QuienParte();
        Console.WriteLine("Partira el jugador:" + parte);
        bool partidor = true;
        while (!gano)
        {
            if (partidor)
            {
                if (parte == "j1" || parte == "empate, parte j1")
                {
                    partidor = false;
                    foreach (var x in jugadorLista.jugadores)

                    {
                        Console.WriteLine("turnos");
                    }
                }
                else
                {
                    partidor = false;
                    Console.WriteLine("Aqui juega el jugadorLista.jugadores[1]");
                }
            }

            foreach (var x in jugadorLista.jugadores)
            {
                Console.WriteLine("turnos");
            }
        }
    }

    public void mostrarArea(List<Jugador> jugadores)
    {
        foreach (var player in jugadores)
        {
            foreach (var VARIABLE in player.ringArea)
            {
                
            }
        }
    }
}