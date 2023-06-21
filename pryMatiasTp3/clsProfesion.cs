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
    internal class clsProfesion
    {


        private OleDbConnection Conector;
        private OleDbCommand Comando;
        private OleDbDataAdapter Adaptador;
        private DataTable Tabla;


        private string NombreDeLaProfesion;
        private int IDProfesion;

        public string Profesion
        {
            get { return NombreDeLaProfesion; }
            set { NombreDeLaProfesion = value; }
        }

        public Int32 Prof
        {
            get { return IDProfesion; }
            set { IDProfesion = value; }
        }

        public clsProfesion()
        {
            string cadena = "provider=microsoft.jet.oledb.4.0;data source=TP.mdb";
            Conector = new OleDbConnection(cadena);
            Comando = new OleDbCommand();

            Comando.Connection = Conector;
            Comando.CommandType = CommandType.TableDirect;
            Comando.CommandText = "Profesiones";

            Adaptador = new OleDbDataAdapter(Comando);
            Tabla = new DataTable();
            Adaptador.Fill(Tabla);

            DataColumn[] dc = new DataColumn[1];
            dc[0] = Tabla.Columns["profesion"];
            Tabla.PrimaryKey = dc;
        }
        public string BuscarProfesion(int profesion)
        {
            DataRow Buscador = Tabla.Rows.Find(profesion);

            if (Buscador != null)
            {
                NombreDeLaProfesion = Buscador[1].ToString();
            }
            else
            {
                NombreDeLaProfesion = "";
            }
            return NombreDeLaProfesion;
        }
        public DataTable getAll()
        {
            return Tabla;
        }

        

        public void ListarProfesiones(System.Windows.Forms.ComboBox CB)
        {
            CB.DisplayMember = "nombre";
            CB.ValueMember = "profesion";
            CB.DataSource = Tabla;
        }

        public void RegistroProfesion()
        {
            DataRow BuscarFila = Tabla.Rows.Find(IDProfesion);

            if (BuscarFila == null)
            {
                DataRow Fila = Tabla.NewRow();
                Fila["profesion"] = IDProfesion;
                Fila["nombre"] = Profesion;
                Tabla.Rows.Add(Fila);
                OleDbCommandBuilder cb = new OleDbCommandBuilder(Adaptador);
                Adaptador.Update(Tabla);
            }
            else
            {
                IDProfesion = 0;
                Profesion = "";
            }

        }


        public void Buscar(Int32 IDProfesionBuscada)
        {
            try
            {
                Conector.Open();
                OleDbDataReader Lector = Comando.ExecuteReader();

                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetInt32(0) == IDProfesionBuscada)
                        {
                            IDProfesion = Lector.GetInt32(0);
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


    }

}
