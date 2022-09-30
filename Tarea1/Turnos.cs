using System.Security.Cryptography;

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
        int que = 0;
        while (!gano)
        {
            if (partidor)
            {
                if (parte == "j1" || parte == "empate, parte j1")
                {
                    partidor = false;
                    foreach (var x in jugadorLista.jugadores)

                    {
                        Console.WriteLine("partio el j1");
                        mostrarArea(jugadorLista.jugadores);
                        x.MostrarMano();
                    }
                }
                else
                {
                    Console.WriteLine("partio el j2");
                    partidor = false;
                    mostrarArea(jugadorLista.jugadores);
                    jugadorLista.jugadores[1].MostrarMano();
                }
            }
            foreach (var player in jugadorLista.jugadores)
            {
                mostrarArea(jugadorLista.jugadores);
            }

            if (que == 10)
            {
                Console.WriteLine("termino");
                gano = true;
            }

            que++;
        }
    }

    public void mostrarArea(List<Jugador> jugadores)
    {
        foreach (var player in jugadores)
        {
            if (player.ringArea.Count)
            {
                
            }
            Console.WriteLine("hola");
            foreach (var s in player.ringArea)
            {
            }
        }
    }
}