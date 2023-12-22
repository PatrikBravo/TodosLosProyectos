using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    static class Menu
    {

        internal static void Menus()
        {
            ADOEstatus ado = new ADOEstatus();
            Estatus estatus;
            Console.Clear();
            int id;
            string opc,clave,nombre;
            while (true)
            {
                Console.WriteLine(" 1.- Consultar Todos \n 2.- Consultar Solo uno \n 3.- Agregar \n 4.- Actualizar \n 5.-  Eliminar \n F.- Termina");
                opc = Console.ReadLine();

                if (opc.Equals("f"))
                    Environment.Exit(0);

                switch (opc)
                {
                    case "1":
                        Console.WriteLine("Consultar Todos");
                        List<Estatus> listaEstatus = new List<Estatus>();
                        listaEstatus = ado.Consultar();
                        foreach (Estatus status in listaEstatus)
                        {
                            Console.WriteLine($"ID: {status.id} Clave: {status.clave} Nombre: {status.nombre}");
                        }
                        break;
                    case "2":
                        Console.WriteLine("Consultar Solo uno");
                        Console.WriteLine("Ingrese el id a consultar");
                        id = int.Parse(Console.ReadLine());
                        estatus = new Estatus();
                        estatus = ado.Consulta(id);
                        Console.WriteLine($"ID: {estatus.id} Clave: {estatus.clave} Nombre: {estatus.nombre}");
                        break;
                    case "3":
                        Console.WriteLine("Agregar");
                        Console.WriteLine("Ingrese el id");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la clave");
                        clave = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre");
                        nombre = Console.ReadLine();
                        estatus = new Estatus(id,clave,nombre);
                        ado.Agregar(estatus);
                        break;
                    case "4":
                        Console.WriteLine("Actualizar");
                        Console.WriteLine("Ingrese el id a actualizar");
                        id = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la clave a cambiar");
                        clave = Console.ReadLine();
                        Console.WriteLine("Ingrese el nombre a cambiar");
                        nombre = Console.ReadLine();
                        estatus = new Estatus(id, clave, nombre);
                        ado.Actualizar(estatus);
                        break;
                    case "5":
                        Console.WriteLine(" Eliminar");
                        Console.WriteLine("Ingrese el id a eliminar");
                        id = int.Parse(Console.ReadLine());
                        ado.Eliminar(id);
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
    
}
