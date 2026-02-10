namespace Actividad1_UnidadII
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables sin validar y variable nombre
            string edad, cantidadPersonas, nombre;
            //Variables validadas
            int cantper, ed;
            //Booleanos de validación de estructura repetitiva
            bool isValid, edIsValid;
            //Listas específicas
            List<string> Listanommen = [];
            List<string> Listanommay = [];
            List<int> Listaedmen = [];
            List<int> Listaedmay = [];
            //Listas generales
            List<int> Listedgen = [];
            List<string> Listnomgen = [];
            Console.WriteLine("Bienvenido");
            //Do-While para repetir la solicitud de una cantidad de personas a registrar válida
            do
            {
                Console.WriteLine("¿Cuantas personas vas a registrar?");
                cantidadPersonas = Console.ReadLine();
                try
                {
                    cantper = Convert.ToInt16(cantidadPersonas);
                    if (cantper > 0)
                    {
                        if (cantper == 1)
                        {
                            isValid = true;
                            Console.WriteLine("Escribe el nombre de la persona");
                            nombre = Console.ReadLine();
                            do
                            {
                                Console.WriteLine("Escribe la edad de la persona");
                                edad = Console.ReadLine();
                                try
                                {
                                    ed = Convert.ToInt16(edad);
                                    if (ed > 0)
                                    {
                                        if (ed >= 18)
                                        {
                                            Console.WriteLine(nombre + " es mayor de edad con " + edad + " años");
                                        }
                                        else if (ed != 1) 
                                        {
                                            Console.WriteLine(nombre + " es menor de edad con " + edad + " años");
                                        } 
                                        else
                                        {
                                            Console.WriteLine(nombre + " es menor de edad con " + edad + " año");
                                        }
                                        edIsValid = true;
                                    } 
                                    else
                                    {
                                        Console.WriteLine("Valor inválido, por favor seleccione un valor superior a 0");
                                        edIsValid = false;
                                    }
                                }
                                catch
                                {
                                    Console.WriteLine("valor inválido, por favor, escriba un número");
                                    edIsValid = false;
                                }
                            } while (!edIsValid);
                        }
                        else
                        {
                            isValid = true;
                            for (int i = 1; i <= cantper; i++)
                            {
                                Console.WriteLine("Ingrese el nombre de la persona " + i);
                                nombre = Console.ReadLine();
                                do
                                {
                                    Console.WriteLine("Ingrese la edad de la persona " + i);
                                    edad = Console.ReadLine();
                                    try
                                    {
                                        ed = Convert.ToInt16(edad);
                                        if (ed >= 0)
                                        {
                                            if (ed >= 18)
                                            {
                                                //Lista de mayores de edad
                                                Listanommay.Add(nombre);
                                                Listaedmay.Add(ed);
                                                //Lista general
                                                Listedgen.Add(ed);
                                                Listnomgen.Add(nombre);
                                            }
                                            else
                                            {
                                                //Lista de menores de edad
                                                Listanommen.Add(nombre);
                                                Listaedmen.Add(ed);
                                                //Lista general
                                                Listedgen.Add(ed);
                                                Listnomgen.Add(nombre);  
                                            }
                                            edIsValid = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("Edad inválida, no fue registrada, vuelva a intentarlo");
                                            edIsValid = false;
                                        }
                                        
                                    }
                                    catch
                                    {
                                        Console.WriteLine("valor inválido, por favor, escriba un número");
                                        edIsValid = false;
                                    }
                                } while (!edIsValid);

                            }
                            if (Listedgen.Count != 0)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Lista de todas las personas registradas");
                                for (int j = 0; j < Listedgen.Count; j++)
                                {
                                    Console.WriteLine(Listnomgen[j] + " - " + Listedgen[j]);
                                }
                            }
                            if (Listaedmay.Count != 0)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Lista de personas mayores");
                                for (int j = 0; j < Listaedmay.Count; j++)
                                {
                                    Console.WriteLine(Listanommay[j] + " - " + Listaedmay[j]);
                                }
                            }
                            if (Listaedmen.Count != 0)
                            {
                                Console.WriteLine("");
                                Console.WriteLine("Lista de personas menores");
                                for (int j = 0; j < Listaedmen.Count; j++)
                                {
                                    Console.WriteLine(Listanommen[j] + " - " + Listaedmen[j]);
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido");
                        isValid = false;
                    }
                }
                catch
                {
                    Console.WriteLine("valor inválido, por favor, escriba un número");
                    isValid = false;
                }
            } while (!isValid);
        }
    }
}
