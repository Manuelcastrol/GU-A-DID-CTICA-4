using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        abstract class Prenda
        {
            protected string diseño;
            protected string[] tallasDisponibles;

            public Prenda(string diseño, string[] tallasDisponibles)
            {
                this.diseño = diseño;
                this.tallasDisponibles = tallasDisponibles;
            }

            public virtual void mostrarDetalles()
            {
                Console.WriteLine("Diseño: " + diseño);
                Console.WriteLine("Tallas disponibles: " + string.Join(", ", tallasDisponibles));
            }

            public abstract string obtenerCategoria();
        }

        class PrendaAltaCalidad : Prenda
        {
            private string material;
            private string marca;

            public PrendaAltaCalidad(string diseño, string[] tallasDisponibles, string material, string marca)
                : base(diseño, tallasDisponibles)
            {
                this.material = material;
                this.marca = marca;
            }

            public override void mostrarDetalles()
            {
                base.mostrarDetalles();
                Console.WriteLine("Material: " + material);
                Console.WriteLine("Marca: " + marca);
            }

            public override string obtenerCategoria()
            {
                return "Alta calidad";
            }
        }

        class PrendaMediaCalidad : Prenda
        {
            private string color;

            public PrendaMediaCalidad(string diseño, string[] tallasDisponibles, string color)
                : base(diseño, tallasDisponibles)
            {
                this.color = color;
            }

            public override void mostrarDetalles()
            {
                base.mostrarDetalles();
                Console.WriteLine("Color: " + color);
            }

            public override string obtenerCategoria()
            {
                return "Media calidad";
            }
        }

        class PrendaBajaCalidad : Prenda
        {
            public PrendaBajaCalidad(string diseño, string[] tallasDisponibles)
                : base(diseño, tallasDisponibles)
            {
            }

            public override string obtenerCategoria()
            {
                return "Baja calidad";
            }
        }

        class Program2
        {
            static void Main(string[] args)
            {
                Prenda[] prendas = new Prenda[]
                {
                new PrendaAltaCalidad("Camisa blanca", new string[] {"S", "M", "L"}, "Algodón", "Hugo Boss"),
                new PrendaMediaCalidad("Pantalón de mezclilla", new string[] {"28", "30", "32"}, "Azul"),
                new PrendaBajaCalidad("Calcetines blancos", new string[] {"35-38", "39-42", "43-46"})
                };

                foreach (Prenda prenda in prendas)
                {
                    Console.WriteLine("Prenda: " + prenda.obtenerCategoria());
                    prenda.mostrarDetalles();
                    Console.WriteLine();
                }

                Console.ReadKey();
            }
        }
    }
}

