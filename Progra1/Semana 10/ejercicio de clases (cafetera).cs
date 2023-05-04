using System;

class Cafetera
{
    int codigo = 200, capacidad, disponibles;
    bool lleno;


    //hacer cafe
    public void hacerCafe()
    {
        disponibles = capacidad;
        lleno = true;
    }

    //servir tazas
    public void servirTaza(int cantTazas)
    {
        if (disponibles >= cantTazas)
        {
            disponibles = disponibles - cantTazas;
        }
        else
        {
            Console.WriteLine("no tenemos suficientes tazas disponibles");
        }
    }

    //obtener porcentaje
    public double obtenerPorcentaje()
    {
        double porcentaje = ((double)disponibles / capacidad) * 100;
        return porcentaje;
    }

    //mostrar estado
    public void mostrarEstado()
    {
        string texto = "código " + codigo + " capacidad: " + capacidad + " tazas servidas: " + (capacidad - disponibles) + " porcentaje: " + obtenerPorcentaje() + "%";
        Console.WriteLine(texto);
    }

    //constructor
    public Cafetera(int elCodigo, int laCapacidad)
    {
        codigo = elCodigo;
        capacidad = laCapacidad;
        lleno = false;
        disponibles = 0;
    }
    public static void Main()
    {
        Console.WriteLine("Ingrese la capacidad de cafetera: ");
        int cap = Convert.ToInt32(Console.ReadLine());
        string opcion = "";

        Cafetera cafe = new Cafetera(1, cap);

        cafe.hacerCafe();
        do
        {
            Console.WriteLine("Cúantas tazas quiere sevir?");
            int tz = Convert.ToInt32(Console.ReadLine());

            cafe.servirTaza(tz);

            cafe.mostrarEstado();
            Console.WriteLine("Desea ingresar más tazas? s/n");
            opcion = Convert.ToString(Console.ReadLine());
        }
        while (opcion == "s");
    }
}