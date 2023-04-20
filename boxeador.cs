class Boxeador
{
// Definicion de Propiedades
public string Nombre{get;set;}
public string Pais{get;set;}
public double Peso{get;set;}
public double PotenciaGolpes{get;set;}
private double VelocidadPiernas{get;set;}
// Constructor
public Boxeador()
{

}
public Boxeador(string nom = "", string pais="", double peso=0, double pg = 0, double vp = 0)
{
Nombre = nom;
Pais = pais;
Peso=peso;
PotenciaGolpes = pg;
VelocidadPiernas = vp;
}

// Métodos

public double ObtenerSkill()
{
double skill;
int random;
Random rnd = new Random();
random = rnd.Next(1, 10 + 1);
skill = PotenciaGolpes *0.6 + VelocidadPiernas *0.8 + random;
return skill;
}
}