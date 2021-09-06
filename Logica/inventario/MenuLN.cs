using Datos.inventario;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.inventario
{
    public class MenuLN
    {
        public bool CreateMenu(Menu op)
        {
            try
            {
                MenuCD.InsertarMenu(op);
                return true;

            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error al insertar Menu"+ex);
            }

        }
        public bool UpdateMenu(Menu op)
        {
            try
            {
                MenuCD.ActualizarMenu(op);
                return true;

            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error en el update del Menu"+ex);
            }

        }
        public bool DeleteMenu(Menu op)
        {
            try
            {
                MenuCD.EliminarMenu(op);
                return true;

            }
            catch (Exception ex)
            {
                throw new LogicaExcepciones("Error en el delete del Menu"+ex);
            }

        }

    }
}
