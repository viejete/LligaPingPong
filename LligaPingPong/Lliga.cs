using System;
using System.Collections.Generic;

public class Lliga
{
    private String nomLliga;
    private List<Jugador> jugadors;
    private List<Partit> partits;

    public int getNom { get; }
    public List<Jugador> getListaJugadors { get; }
    public List<Partit> getListaPartits { get; }

    public Lliga()
    {

    }

    public Lliga(String nomLliga)
	{
        this.nomLliga = nomLliga;
        jugadors = new List<Jugador>();
        partits = new List<Partit>();
    }

    public void nouJugador(Jugador jugador)
    {
        jugadors.Add(jugador);
    }

    public void nouPartit(Partit partit)
    {
        partits.Add(partit);
    }

    public Partit getPartit(int i)
    {
        if (i < partits.Count)
            return partits[i];
        else
            return null;
    }

    public Jugador getJugador(int i)
    {
        if (i < jugadors.Count)
            return jugadors[i];
        else
            return null;
    }

    public void deleteJugador(int i)
    {
        if (i < jugadors.Count)
            jugadors.RemoveAt(i);
    }

    public List<Jugador> getJugadors()
    {
        return this.jugadors;
    }

    public List<Partit> getPartits()
    {
        return this.partits;
    }
}
