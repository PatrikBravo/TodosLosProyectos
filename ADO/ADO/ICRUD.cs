using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO
{
    interface ICRUD
    {
        List<Estatus> Consultar();
        Estatus Consulta(int id);
        int Agregar(Estatus status);
        void Actualizar(Estatus status);

        void Eliminar(int id);
    }
}
