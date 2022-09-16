using BusinessLogic.Authors;
using Entities.Authors;
using System;
using System.Windows.Forms;

namespace MetNet.MainForms
{
    public partial class FrmAuthor : Form
    {

        private ClsAuthor ObjAuthor = null;
        private readonly ClsAuthorBl ObjAuthorBl = new ClsAuthorBl();

        public FrmAuthor()
        {
            InitializeComponent();
            CargarListaAutores();
        }

        private void CargarListaAutores()
        {
            ObjAuthor = new ClsAuthor();
            ObjAuthorBl.Index(ref ObjAuthor);
            if (ObjAuthor.MenjaseError == null)
            {
                DgvAutores.DataSource = ObjAuthor.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjAuthor.MenjaseError,"Mensaje de error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        



        private void FrmAuthor_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            ObjAuthor = new ClsAuthor()
            {
                Nombre = TxtNombre.Text,
                Apellido = TxtApellido.Text,
                Ciudad = TxtCiudad.Text,
                CorreoElectronico = TxtCorreo.Text,
                FechaNacimiento = DtpFechaNacimiento.Value,


            };
            ObjAuthorBl.Create(ref ObjAuthor);

            if (ObjAuthor.MenjaseError == null)
            {
                MessageBox.Show("El ID: " + ObjAuthor.ValorScalar + ", Fue Agregado Correctamente");
                CargarListaAutores();
            }
            else
            {
                MessageBox.Show(ObjAuthor.MenjaseError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void DgvAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                if (DgvAutores.Columns[e.ColumnIndex].Name == "LibrosE")
                {
                    ObjAuthor = new ClsAuthor()
                    {
                        IdAutores = Convert.ToByte(DgvAutores.Rows[e.RowIndex].Cells["IdAutores"].Value.ToString())
                    };
                    LblAutor.Text = ObjAuthor.IdAutores.ToString();
                    ObjAuthorBl.Delete(ref ObjAuthor);
                    CargarListaAutores();
                    }

            }
            catch (Exception)
            {

                throw;
            }


        }

        private void ListaLibros_Click(object sender, EventArgs e)
        {

            this.Hide();
            FrmBook f2 = new FrmBook();
            f2.ShowDialog();
            f2 = null;
            this.Show();   



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

    }
}

