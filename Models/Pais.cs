public class Pais
{
    public string nombre{get;private set;}
    public string imgbandera{get;private set;}
    public int Poblacion {get; private set;}
   public DateTime FechaIndependencia{get; private set;}
   public string AtractivosTuristicos {get; private set;}
   public Pais()
   {
    
   }
   public Pais (string nom, string imgban, int pobla, DateTime FI, string AT)
   {
    nombre = nom;
    imgbandera = imgban;
    Poblacion = pobla;
    FechaIndependencia = FI;
    AtractivosTuristicos = AT;
   }

}