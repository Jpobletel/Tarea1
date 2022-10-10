namespace Tarea1;

public class Turnos
{
    public bool gano;

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
                    Console.WriteLine("partio el j1");
                    foreach (var x in jugadorLista.jugadores)

                    {
                        bool ssaUsada = false;
                        if (x.miSuperstar.superStarAbility.Contains("before your draw segment"))
                        {
                            Console.WriteLine("Quiere usar la habilidad: " + x.miSuperstar.superStarAbility);
                        }
                        mostrarArea(jugadorLista.jugadores);
                        x.robarCarta();
                        x.MostrarMano();
                        accionCarta(x, ssaUsada);
                    }
                }
                else
                {
                    Console.WriteLine("partio el j2");
                    partidor = false;
                    bool ssaUsada = false;
                    if (jugadorLista.jugadores[1].miSuperstar.superStarAbility.Contains("before your draw segment"))
                    {
                        Console.WriteLine("Quiere usar la habilidad: " + jugadorLista.jugadores[1].miSuperstar.superStarAbility);
                    }
                    mostrarArea(jugadorLista.jugadores);
                    jugadorLista.jugadores[1].robarCarta();
                    jugadorLista.jugadores[1].MostrarMano();
                    accionCarta(jugadorLista.jugadores[1], ssaUsada);
                }
            }
            foreach (var player in jugadorLista.jugadores)
            {
                bool ssaUsada = false;
                if (player.miSuperstar.superStarAbility.Contains("before your draw segment"))
                {
                    Console.WriteLine("Quiere usar la habilidad: " + player.miSuperstar.superStarAbility);
                }
                mostrarArea(jugadorLista.jugadores);
                player.robarCarta();
                player.MostrarMano();
                accionCarta(player, ssaUsada);
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
        Console.WriteLine("###############################################################");
        int contador = 1;
        foreach (var player in jugadores)
        {
            if (player.ringArea.Count==0)
            {
                Console.WriteLine("# Jugador J" + contador + " No tiene cartas en el ring                       #");
                
            }
            Console.WriteLine("# Area jugador J"+contador+ "                                              #");
            Console.WriteLine("###############################################################");
            Console.WriteLine("Fortitude: " + player.fortitude);
            foreach (var x in player.ringArea)
            {
                Console.WriteLine("Title: "+x.Title);
                Console.WriteLine("Types: ");
                foreach (var tipo in x.Types)
                {
                    Console.WriteLine("     "+ tipo);
                }
                Console.WriteLine("Subtypes: ");
                foreach (var subtipo in x.Subtypes)
                {
                    Console.WriteLine("     "+ subtipo);
                }
                Console.WriteLine("Fortitude: "+ x.Fortitude);
                Console.WriteLine("Damage: " + x.Damage);
                Console.WriteLine("StunValue: "+ x.StunValue);
                Console.WriteLine("CardEffect: "+ x.CardEffect);
                Console.WriteLine("###############################################################");
            }
            contador++;
        }
    }
    
    public void accionCarta(Jugador player, bool ssaUsada)
    {
        if (!ssaUsada)
        {
            Console.WriteLine("Quiere usar la SuperStar Ability [si/no]:");
            string inputssa = Console.ReadLine();
            while (inputssa!="si" && inputssa!="no")
            {
                Console.WriteLine("Bruh elige una opcion valida");
                inputssa = Console.ReadLine();
            }

            if (inputssa == "si")
            {
                Console.WriteLine(player.miSuperstar.superStarAbility);
            }
            else
            {
                Console.WriteLine("Habilidad no usada :v");
            }
        }
        Console.WriteLine("Elige a uno de las cartas:");
        string input = Console.ReadLine();
        bool isNumerical = false;
        int inputInt;
        isNumerical = int.TryParse(input, out inputInt);
        while (inputInt < 0 || inputInt > player.mano.Count || !isNumerical)
        {
            Console.WriteLine("Bruh elige un numero valido");
            input = Console.ReadLine();
            isNumerical = int.TryParse(input, out inputInt);
        }
        player.AgregarCartaArea(player.mano[inputInt]);
        player.calcularFortitude();
    }

}