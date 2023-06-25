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
    internal class clsLocalidad
    {
        private OleDbConnection Conector;//elementos que utilizo 
        private OleDbCommand Comando;
        private OleDbDataAdapter Adaptador;
        private DataTable Tabla;

        private string NombreDeLocalidad;//variables
        private int Localidad;

        public string IdLocalidad
        {
            get { return NombreDeLocalidad; }
            set { NombreDeLocalidad = value; }
        }

        public Int32 Local
        {
            get { return Localidad; }
            set { Localidad = value; }
        }

        public clsLocalidad()
        {
            string cadena = "provider=microsoft.jet.oledb.4.0;data source=TP.mdb";
            Conector = new OleDbConnection(cadena);
            Comando = new OleDbCommand();

            Comando.Connection = Conector;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Localidades";

            Adaptador = new OleDbDataAdapter(Comando);
            Tabla = new DataTable();
            Adaptador.Fill(Tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = Tabla.Columns["localidad"];
            Tabla.PrimaryKey = dc;
        }

        public string BuscarLocalidad(int Localidad)//procedimiento de busqueda 
        {
            DataRow Buscador = Tabla.Rows.Find(Localidad);

            if (Buscador != null)
            {
                NombreDeLocalidad = Buscador[1].ToString();
            }
            else
            {
                NombreDeLocalidad = "";
            }

            return NombreDeLocalidad;
        }

        


        public void ListarLocalidades(System.Windows.Forms.ComboBox Combo)// envio la informacion a la tabla 
        {
            Combo.DisplayMember = "nombre";
            Combo.ValueMember = "localidad";
            Combo.DataSource = Tabla;
        }



        public void RegistroDeLocalidad()//Procedimiento registro 
        {
            DataRow BuscarFila = Tabla.Rows.Find(Localidad);

            if (BuscarFila == null)
            {
                DataRow Fila = Tabla.NewRow();
                Fila["localidad"] = Localidad;
                Fila["nombre"] = NombreDeLocalidad;
                Tabla.Rows.Add(Fila);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(Adaptador);
                Adaptador.Update(Tabla);
            }
            else
            {
                Localidad = 0;
                NombreDeLocalidad = "";
            }
        }



        public void Buscar(Int32 LocalidadBuscar) //procedimieto buscar 
        {
            try
            {
                Conector.Open();
                OleDbDataReader Lector = Comando.ExecuteReader();

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == LocalidadBuscar)
                        {
                            Localidad = Lector.GetInt32(0);
                        }
                    }
                }
                Conector.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public DataTable getAll()//para que volvemos a la tabla 
        {
            return Tabla;
        }



    }
}
