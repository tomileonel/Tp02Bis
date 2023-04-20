Boxeador Box1= new Boxeador();
Boxeador Box2= new Boxeador();
    bool salir = false;
do{
    leerMenu();
    double doubleMenu = Ingresardouble("");


    switch(doubleMenu)
    {
        case 1:
        {
            Box1 = IngresarBoxeador();
            break;
        }
        case 2:
        {
            Box2 = IngresarBoxeador();
            break;
        }
        case 3:
        {Pelear();
            break;
        }
        case 4:
        {
            Console.WriteLine("Hasta luego");
            salir = true;
            break;
        }
        default:
        {
            Console.WriteLine("Error");
            break;
        }
    }
} while(!salir);

void Pelear(){
    if(Box1.Nombre == ""||Box2.Nombre ==""){
        Console.WriteLine("ERROR");

    }else{
    string ventaja = "por fallo dividido";
    double skill1 = Box1.ObtenerSkill();
    double skill2 = Box2.ObtenerSkill();
    double aux = skill1 - skill2;
Console.WriteLine(skill1);
Console.WriteLine(skill2);
Console.WriteLine(aux);
    if(aux > 30 || aux < -30){
        ventaja = "por puntos en fallo unanime";
}
    if(aux >= 30 || aux <= -30){
        ventaja = "por KO";
}    
if (aux > 0){
    Console.WriteLine("Box1 gano " + ventaja);
}
if (aux < 0){
    Console.WriteLine("Box2 gano " + ventaja);
}
if (aux == 0){
    Console.WriteLine("Empate");
}
}}
Boxeador IngresarBoxeador()
{ 
    string nombre;
    string pais;
    double peso;
    double vp;
    double pg;
    
    
        
        nombre = IngresarString("Nombre");
        pais = IngresarString("Pais");
    do{
        peso = Ingresardouble("Peso");
        vp = Ingresardouble("Velocidad Piernas");
        pg = Ingresardouble("Potencia Golpes");
        if(peso <= 0 || pg <=0 || pg >100 || vp <=0 || vp >100){
            Console.WriteLine("El peso, la velocidad de patada o la potencia de golpe esta mal");
        }
    }while(peso <= 0 || pg <=0 || pg >100 || vp <=0 || vp >100);

    Boxeador box =  new Boxeador(nombre,pais,peso,pg,vp);
    return box;
    
}
void leerMenu()
{
    Console.WriteLine("1.Cargar Box1");
    Console.WriteLine("2.Cargar Box2");
    Console.WriteLine("3.Pelea");
    Console.WriteLine("4.Salir");

}

string IngresarString(string txt)
{
    Console.WriteLine(txt);
    string str = Console.ReadLine();
    return str;
}

double Ingresardouble(string txt)
{
    Console.WriteLine(txt);
    double num = -1;
    do
    {
        bool valido = double.TryParse(Console.ReadLine(),out num);
    }while(num <= -1);
    return num;
}


double ObtenerRandom(int min, int max){
double random;
Random rnd = new Random();
random = rnd.Next(min, max + 1);
return random;
}
