using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace Ejercicios_clase3
{
    internal class Program
    {

        //EJERCICIO 1

        public class Vehiculo
        {
            private string marca;
            private string motor;
            private int año;
            private string origen;

            public void arrancar()
            {
                Console.WriteLine("estoy encendido");
            }

            public void encenderLuces()
            {
                Console.WriteLine("luces encendidas");
            }

            public void apagar()
            {
                Console.WriteLine("lucesApagadas");
            }
        }

        public class Autobus : Vehiculo
        {
            private int capacidadPasajeros;
            private int numeroDePuertas;
            private int numeroDeAsientos;

            public void cargarPasajero()
            {
                Console.WriteLine("suba y no se olvide de pagar");
            }

            public void descargarPasajero()
            {
                Console.WriteLine("adios que tenga buen dia");
            }

        }

        //EJERCICIO 2

        public class Vehiculoo
        {
            private string modelo;
            private string marca;
            private int año;
            private int numeroSerie;

            public void arrancar()
            {
                Console.WriteLine("estoy encendido");
            }

            public void detener()
            {
                Console.WriteLine("estoy detenido");
            }

            public void acelerar()
            {
                Console.WriteLine("rrrrrrrrr");
            }

            public void frenar()
            {
                Console.WriteLine("frenandooo");
            }
        }

        public class Autobuss : Vehiculoo
        {
            private int capacidadPasajeros;
            private int numeroDePuertas;
            private int numeroDeAsientos;

            public void cargarPasajero()
            {
                Console.WriteLine("suba y no se olvide de pagar");
            }

            public void descargarPasajero()
            {
                Console.WriteLine("adios que tenga buen dia");
            }

        }

        public class Taxi : Vehiculoo
        {
            private bool habilitado;
            private int numeroDeRegistro;
            private string municipio;

            public bool Libre()
            {
                if (habilitado == true)
                {
                    Console.WriteLine("Estoy Libre");
                    return true;
                }
                else
                {
                    return false;
                }

            }

            public class Moto : Vehiculoo
            {
                private int cilindrada;
                private string tipo;
                private string patente;

                public void hacerWheelie()
                {
                    Console.WriteLine("me hago el canchero");
                }

                public void tirarCortes()
                {
                    Console.WriteLine("molesto a la gente haciendo ruido con la moto");
                }
            }


        //EJERCICIO 3

            public class Animal
            {
                private string especie;
                private int edad;
                private string genero;

                public void alimentar()
                {
                    Console.WriteLine("comiendo");
                }

                public void reproducir()
                {
                    Console.WriteLine("pasenla lindo");
                }

                public void hacerSonidoCaracteristico()
                {
                    Console.WriteLine("hago mi sonido caracteristico");
                }
            }

            public class Oso : Animal
            {
                private double peso;
                private string salud;

                public void hibernar()
                {
                    Console.WriteLine("a mimir...zzZZ");
                }

                public void teminarHibernacion()
                {
                    Console.WriteLine("pucha otra vez al bosque..");
                }
            }


            public class Tiburón : Animal
            {
                private bool esPeligroso;
                private double largo;

                public void atacar()
                {
                    Console.WriteLine("suena la música de tiburón");
                }

                public void sumergirse()
                {
                    Console.WriteLine("me voy al fondo");
                }

                public void detectarSangre()
                {
                    Console.WriteLine("puedo oler tu sangre!!");
                }
            }


            //EJERCICIO 4  (ACA TUVE QUE CAMBIAR A PUBLICOS LOS ATRIBUTOS PARA PODER ACCEDER DESDE LA BIBLIOTECA A LOS LIBROS)


            public class Libro
            {
                public string titulo { get; set; }
                public string autor { get; set; }
                public int año { get; set; }
                public string genero { get; set; }

                public void abrir()
                {
                    Console.WriteLine("abro el libro");
                }

                public void cerrar()
                {
                    Console.WriteLine("cierro el libro");
                }

                public void leer()
                {
                    Console.WriteLine("leyendo...");
                }

            }


            //EJERCICIO 5  


            public class Biblioteca
            {
                private string nombre;
                private string ubicación;
                private DateTime horarioApertura;
                private DateTime horarioCierre;

                private List<Libro> libros = new List<Libro>(); //aca tuve que crear una lista de libros

                public void agregarLibro(Libro libro)
                {
                    libros.Add(libro);
                    Console.WriteLine("Libro agregado: " + libro.titulo);
                }
                public void prestarLibro(string libro)
                {
                    Console.WriteLine("presto el libro");
                }

                public void devolverLibro(string libro)
                {
                    Console.WriteLine("devolviendo el libro");
                }

                public List<string> buscarPorAutor(string autor)
                {
                    List<string> resultado = new List<string>(); // hago una lista para autores para poder cumplir con el tipo de dato que puse en el diagrama.

                    foreach (var libro in libros)
                    {
                        if (libro.autor == autor)
                        {
                            resultado.Add(libro.titulo);
                        }
                    }

                    return resultado;
                }

                public List<string> buscarPorTitulo(string titulo)
                {
                    List<string> resultado = new List<string>(); // tuve que crear una lista de titulos

                    foreach (var libro in libros)
                    {
                        if (libro.titulo == titulo)
                        {
                            resultado.Add(libro.titulo);
                        }
                    }

                    return resultado;
                }

            }




            //EJERCICIO 6


            public class CajeroAutomatico
            {

                private string ubicacion;
                private int numeroSerie;
                private double saldoDisponible;

                public void retirarDinero(double cantidad)
                {
                    Console.WriteLine("retire su dinero");
                }

                public void depositarDinero(double cantidad)
                {
                    Console.WriteLine("ingrese el dinero");
                }

                public void consultarSaldo()
                {
                    Console.WriteLine("su saldo es: ");
                }
            }


            //EJERCICIO 7


            public class Departamento

            {
                private string area;
                private int cantidadEmpleados;
                private double presupuestoAnual;

                public void agregarEmpleado(int id)
                {
                    Console.WriteLine("ingresando empleado al departamento: ");
                }
                public void quitarEmpleado(int id)
                {
                    Console.WriteLine("quitando el empleado del departamento");
                }

                public double presupuestoRestante()
                {
                    Console.WriteLine("este es el presupuesto restante: ");
                    return 0.0; //simulo un valor para no romperlo pero le falta la logica.
                }
            }

            public class Empleado
            {
                private string nombre;
                private int dni;
                private DateTime fechaDeIngreso;
                private string rol;
                private string rango;
                private int id;

                public void asignarRol(int id)
                {
                    Console.WriteLine("asignar rol: ");
                }

                public void asignarRango(int id)
                {
                    Console.WriteLine("asignar rango: ");
                }

                public void darDeBaja()
                {
                    Console.WriteLine("dando de baja al empleado id: ");
                }
            }

            public class Rol
            {
                private string puestoTipo;
                private List<string> permisos;
                private int nivel;

                public void otorgarPermisos(int nivel)
                {
                    Console.WriteLine("dando permisos al nivel indicado");
                }

                public void quitandoPermisos(int nivel)
                {
                    Console.WriteLine("quitando permisos al nivel indicado");
                }
            }


            static void Main(string[] args)
            {

                Console.WriteLine("\n\n----- CREANDO INSTACIAS Y USANDO ALGUNOS METODOS DE PRUEBA ------");


                Console.WriteLine("\n----- VEHICULO ------");

                Vehiculo focus = new Vehiculo();
                focus.arrancar();
                focus.encenderLuces();
                focus.apagar();

                Console.WriteLine("\n----- AUTOBUS ------");

                Autobus colegial = new Autobus();
                colegial.cargarPasajero();
                colegial.descargarPasajero();

                Console.WriteLine("\n----- VEHICULOO (ejercicio 2, con doble O para usarlo en el mismo codigo) -----");

                Console.WriteLine("\n----- TAXI ------");

                Taxi taxi = new Taxi();
                taxi.arrancar();
                taxi.acelerar();
                taxi.frenar();
                taxi.Libre();

                Console.WriteLine("\n----- MOTO ------");

                Moto ninja = new Moto();
                ninja.hacerWheelie();
                ninja.tirarCortes();

                Console.WriteLine("\n----- ANIMALES -----");

                Console.WriteLine("\n----- OSO ------");

                Oso yogi = new Oso();
                yogi.alimentar();
                yogi.reproducir();
                yogi.hibernar();
                yogi.teminarHibernacion();

                Console.WriteLine("\n----- TIBURON ------");

                Tiburón tiburonPelicula = new Tiburón();
                tiburonPelicula.hacerSonidoCaracteristico();
                tiburonPelicula.atacar();
                tiburonPelicula.sumergirse();
                tiburonPelicula.detectarSangre();

                Console.WriteLine("\n------ BIBLIOTECA ----");

                Biblioteca biblioteca = new Biblioteca();

                Console.WriteLine("\n----- CREANDO LIBROS PARA LA BIBLIOTECA ------");

                Libro libro1 = new Libro { titulo = "Rayuela", autor = "Julio Cortazar", año = 1963, genero = "Novela" };
                Libro libro2 = new Libro { titulo = "El Aleph", autor = "Jorge Luis Borges", año = 1949, genero = "Cuento fantástico" };
                Libro libro3 = new Libro { titulo = "Don Segundo Sombra", autor = "Ricardo Güiraldes", año = 1926, genero = "Novela gauchesca" };

                biblioteca.agregarLibro(libro1);
                biblioteca.agregarLibro(libro2);
                biblioteca.agregarLibro(libro3);

                Console.WriteLine("\n----- BUSCANDO LIBROS POR AUTOR ------");

                var encontrados = biblioteca.buscarPorAutor("Julio Cortazar");
                Console.WriteLine("Libros encontrados de Cortazar:");
                foreach (var titulo in encontrados)
                {
                    Console.WriteLine("... " + titulo);
                }

                biblioteca.prestarLibro("Rayuela");
                biblioteca.devolverLibro("Rayuela");

                Console.WriteLine("\n----- CAJERO -----");

                CajeroAutomatico cajero = new CajeroAutomatico();
                cajero.consultarSaldo();
                cajero.retirarDinero(500);
                cajero.depositarDinero(1000);

                Console.WriteLine("\n----- DEPARTAMENTO -----");
                Departamento Ingeniería = new Departamento();
                Ingeniería.agregarEmpleado(1);
                Ingeniería.quitarEmpleado(1);
                Ingeniería.presupuestoRestante();

                Empleado Carloncho = new Empleado();
                Carloncho.asignarRol(1);
                Carloncho.asignarRango(2);
                Carloncho.darDeBaja(); // ACA CAMBIÉ A VOID EL METODO, PEDÍA UN DATO INT (EN MI DIAGRAMA Y NO TIENE SENTIDO)

                Rol asistente = new Rol();
                asistente.otorgarPermisos(2);
                asistente.quitandoPermisos(2);

            }
        }


    }
}





       
  
 
    


