namespace Tarea1;
using System;
using System.Collections.Generic;

public class Jugador
{
    public List<Carta> baraja = new List<Carta>();
    public List<Carta> mano = new List<Carta>();
    public List<Carta> ringSide = new List<Carta>();
    public List<Carta> ringArea = new List<Carta>();
    public int fortitude = 0;
    public Superstar miSuperstar;
    static Random rnd = new Random();
    public void AgregarSuperstar(List<Superstar> x)
    {
        Console.WriteLine("---------------------------");
        foreach (var opcion in x)
        {
            Console.WriteLine("Nombre: " + opcion.name);
            Console.WriteLine("Tamano de la mano: " + opcion.handSize);
            Console.WriteLine("Star Value: " + opcion.starValue);
            Console.WriteLine("SuperStar Ability: " + opcion.superStarAbility);
            Console.WriteLine("---------------------------");
        }

        Console.WriteLine("Elige a uno de los siguientes jugadores:");
        Console.WriteLine("[0] = STONECOLD || [1] = THEUNDERTAKER || [2] = MANKING || [3] = HHH || [4] = THEROCK || [5] = KANE || [6] = CHRISJERICHO");
        string input = Console.ReadLine();
        bool isNumerical = false;
        int inputInt;
        isNumerical = int.TryParse(input, out inputInt);
        while (inputInt < 0 || inputInt > 6 || !isNumerical)
        {
            Console.WriteLine("Bruh elige un numero valido");
            input = Console.ReadLine();
            isNumerical = int.TryParse(input, out inputInt);
        }

        miSuperstar = x[inputInt];
        
        Console.WriteLine("Mi SuperStar es: " + miSuperstar.name);


    }

    public void AgregarMazoPredeterminado(List<Carta> x)
    {
        Console.WriteLine("Mazo de " + miSuperstar.name);
        string[] lines = File.ReadLines(miSuperstar.name+".txt").ToArray();
        foreach (var r in lines)
        {
            int cantidad = r[0] - '0';
            string nombreCarta = r.Substring(2);
            foreach (var cosa in x)
            {
                if (cosa.Title == nombreCarta)
                {
                    Carta cartaAgregada = cosa;
                    for (int i = 0; i < cantidad; i++)
                    {
                        baraja.Add(cartaAgregada);
                    }

                    break;
                }
            }
            
        }

    }

    public void repartirMano()
    {
        for (int i = 0; i < miSuperstar.handSize; i++)
        {
            int r = rnd.Next(baraja.Count);
            AgregarCartaAMano(baraja[r]);
            baraja.RemoveAt(r);
        }

    }
    
    public void AgregarCartaAMano(Carta x)
    {
        mano.Add(x);
    }

    public void AgregarCartaArea(Carta x)
    {
        ringArea.Add(x);
        mano.Remove(x);
    }

    public void MostrarMano()
    {
        Console.WriteLine("Esta es su mano:");
        int i = 0;
        foreach (var x in mano)
        {
            Console.WriteLine("[" + i + "]"+"Title: " + x.Title);
            Console.WriteLine("Types: ");
            foreach (var tipo in x.Types)
            {
                Console.WriteLine("     " + tipo);
            }

            Console.WriteLine("Subtypes: ");
            foreach (var subtipo in x.Subtypes)
            {
                Console.WriteLine("     " + subtipo);
            }

            Console.WriteLine("Fortitude: " + x.Fortitude);
            Console.WriteLine("Damage: " + x.Damage);
            Console.WriteLine("StunValue: " + x.StunValue);
            Console.WriteLine("CardEffect:" + x.CardEffect);
            Console.WriteLine("----------------------------------");
            i++;
        }
    }

    public void calcularFortitude()
    {
        fortitude = 0;
        foreach (var carta in ringArea)
        {
            fortitude =+ Convert.ToInt32(carta.Damage);
        }
    }

    public void robarCarta()
    {
        int r = rnd.Next(baraja.Count);
        AgregarCartaAMano(baraja[r]);
        baraja.RemoveAt(r);
    }
}