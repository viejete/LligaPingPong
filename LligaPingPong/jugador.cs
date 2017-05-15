using System;

public class Jugador
{

    public String nom { get; set; }
    public String idJugador { get; set; }
    public int punts { get; set; }
    public int nombrePartits {get;set;}


    public Jugador(String nom,int punts,int nombrePartits)
    {
        this.nom = nom;
        this.punts = punts;
        this.nombrePartits = nombrePartits;
    }

    public Jugador()
    {
    }
    
}
