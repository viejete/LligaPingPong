using Newtonsoft.Json;
using System;


public class Partit
{
    [JsonIgnore]
    public String idPartit { get; set; }
    public String idJugador1 { get; set; }
    public String nJugador1 { get; set; }
    public String idJugador2 { get; set; }
    public String nJugador2 { get; set; }
    public int punts1 { get; set; }
    public int punts2 { get; set; }
    public String guanyador;


    public Partit()
    {

    }

    public Partit(String nJugador1,String nJugador2,String idJugador1,String idJugador2,int punts1,int punts2)
	{
        this.idJugador1 = idJugador1;
        this.idJugador2 = idJugador2;
        this.punts1 = punts1;
        this.punts2 = punts2;
        this.nJugador1 = nJugador1;
        this.nJugador2 = nJugador2;
    }

    public String getGuanyador()
    {
        if (punts1 > punts2)
        {
            return idJugador1;
        }
        else
        {
            return idJugador2;
        }
    }

    public String setGuanyador(String guanyador)
    {
        return this.guanyador = guanyador;
    }
}
