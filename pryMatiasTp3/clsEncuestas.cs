using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMatiasTp3
{
    internal class clsEncuestas
    {
        private OleDbConnection Conector;//Elementos que voy utilizar 
        private OleDbCommand Comando;
        private OleDbDataAdapter Adaptador;
        private DataTable Tabla;

        public clsEncuestas()
        {
            string cadena = "provider=microsoft.jet.oledb.4.0;data source=TP.mdb";
            Conector = new OleDbConnection(cadena);
            Comando = new OleDbCommand();

            Comando.Connection = Conector;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Encuestas";

            Adaptador = new OleDbDataAdapter(Comando);
            Tabla = new DataTable();
            Adaptador.Fill(Tabla);

            DataColumn[] dc = new DataColumn[2];
            dc[0] = Tabla.Columns["localidad"];
            dc[1] = Tabla.Columns["profesion"];
            Tabla.PrimaryKey = dc;
        }

        public DataTable getAll()// para que volvamos a la tabla 
        {
            return Tabla;
        }

        
        public bool Registrar(Int32 localidad, Int32 profesion, Int32 cantidad)//aca registra todo localidad empleo y cantidad
        {
            bool valor = true;

            Object[] clave = new Object[2];
            clave[0] = localidad;
            clave[1] = profesion;

            DataRow filabuscada = Tabla.Rows.Find(clave);

            if (filabuscada == null)
            {
                DataRow fila = Tabla.NewRow();
                fila["localidad"] = localidad;
                fila["profesion"] = profesion;
                fila["cantidad"] = cantidad;
                Tabla.Rows.Add(fila);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(Adaptador);
                Adaptador.Update(Tabla);
            }
            else
            {
                valor = false;
            }
            return valor;
        }

    }
}
