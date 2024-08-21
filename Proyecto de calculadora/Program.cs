using System;
using System.ComponentModel.Design;
class Mercado
{
    static void Main()
    {
        Console.WriteLine("Bienvenidos a nuestro Mercado El Corral");
        Console.WriteLine("Pon Tu Nombre Por Favor");
        string Nombre = Console.ReadLine();
        Console.WriteLine("Favor ingrese su Edad");
        int edad = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Elija el Producto que desee");
        Console.WriteLine("1.Carnes");
        Console.WriteLine("2.Lacteos");
        Console.WriteLine("3.Granos Basicos");
        string categoria = Console.ReadLine();

        if (categoria == "1")
        {
            Console.WriteLine("Estos son Todas las Carnes que tenemos Elija el Tipo de Carne que va comprar ");
            Console.WriteLine("1.Tajo Premiun");
            Console.WriteLine("2.Tajo de Cerdo");
            Console.WriteLine("3.Costilla");
            Console.WriteLine("4.Carne Molida");
            Console.WriteLine("5.Pechuga deshuesada");
            string Carnes = Console.ReadLine();

            if (Carnes == "1")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Tajo Premiun a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 55;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Tajo Premiun a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 68;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Tajo Premiun a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 88;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }

            if (Carnes == "2")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Tajo de Cerdo a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 35;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Tajo de Cerdo a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 43;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Tajo de Cerdo a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 55;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Carnes == "3")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Costilla a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 34;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Costilla a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 42;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Costilla a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 54;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Carnes == "4")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Carne Molida a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 30;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Carne Molida a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 37;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Carne Molida a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 48;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Carnes == "5")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Pechuga deshuesada a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Pechuga deshuesada a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 50;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Pechuga deshuesada a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal1 = Cantidad * 65;
                    Console.WriteLine($"Subtotal:  {subtotal1:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal1 * 0.30;
                        double Total_D = subtotal1 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }

                
            }
        }
        else if (categoria == "2")
        {
            Console.WriteLine("Estos son Todos los Lacteos que tenemos Elija el Tipo de Lacteos que va comprar ");
            Console.WriteLine("1.Mantequilla Rala");
            Console.WriteLine("2.Queso Frijolero");
            Console.WriteLine("3.Queso con chile");
            Console.WriteLine("4.Cuajada");
            Console.WriteLine("5.Requeson");
            string Lacteos = Console.ReadLine();

            if (Lacteos == "1")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Mantequilla a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 25;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Mantequilla a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 31;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Tajo Mantequilla a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }

            if (Lacteos == "2")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Queso Frijolero a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 32;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Queso Frijolero a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 40;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Queso Frijolero a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 52;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Lacteos == "3")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Queso con chile a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 36;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Queso con chile a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 45;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Queso con chile a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 58;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Lacteos == "4")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Cuajada a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 35;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Cuajada a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 43;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Cuajada a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 55;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (Lacteos == "5")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Requeson a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 41;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Requeson a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 50;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Requeson a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal2 = Cantidad * 65;
                    Console.WriteLine($"Subtotal:  {subtotal2:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal2 * 0.30;
                        double Total_D = subtotal2 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }


            }
        }
        else if (categoria == "3")
        {
            Console.WriteLine("Estos son Todos los Granos Basicos que tenemos Elija el Tipo de Granos Basicos que va comprar ");
            Console.WriteLine("1.Frijoles");
            Console.WriteLine("2.Maiz Blanco");
            Console.WriteLine("3.Maiz Amarillo");
            Console.WriteLine("4.Arroz");
            Console.WriteLine("5.Trigo");
            string GranosBasicos = Console.ReadLine();

            if (GranosBasicos == "1")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Frijoles a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 65;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Frijoles a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 81;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Frijoles a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 105;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }

            if (GranosBasicos  == "2")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Maiz Blanco a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 13;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Maiz Blanco a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 16;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Maiz Blaco a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 20;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (GranosBasicos == "3")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Maiz Amarillo a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 15;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Maiz Amarillo a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 18;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Maiz Amarillo a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 23;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (GranosBasicos == "4")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Arroz a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 12;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Arroz a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 15;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Arroz a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 19;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }




            }
            if (GranosBasicos == "5")
            {
                Console.WriteLine("1.Media");
                Console.WriteLine("2.Libra");
                Console.WriteLine("3.2 Libras");
                string Tamaño = Console.ReadLine();
                if (Tamaño == "1")
                {
                    Console.WriteLine("Ingrese la Cantidad de Trigo a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 45;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "2")
                {
                    Console.WriteLine("Ingrese la Cantidad de Trigo a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 56;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }
                else if (Tamaño == "3")
                {
                    Console.WriteLine("Ingrese la Cantidad de Trigo a Comprar");
                    int Cantidad = Convert.ToInt32(Console.ReadLine());
                    int subtotal3 = Cantidad * 72;
                    Console.WriteLine($"Subtotal:  {subtotal3:F2}");
                    if (edad > 59)
                    {
                        Double Descuento = subtotal3 * 0.30;
                        double Total_D = subtotal3 - Descuento;
                        Console.WriteLine($"Subtotal + descuento de tercera edad: {Total_D:f2}");
                    }
                    Console.ReadKey();
                }


            }
        }


    }
}