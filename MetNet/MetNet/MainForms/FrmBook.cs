using BusinessLogic.Books;
using Entities.Authors;
using Entities.Books;
using System;
using System.Windows.Forms;

namespace MetNet.MainForms
{
    public partial class FrmBook : Form
    {

        private ClsBook ObjBook = null;
        private readonly ClsBookBl ObjBookBl = new ClsBookBl();


        public FrmBook()
        {
            InitializeComponent();
            CargarListaLibros();
        }

        private void CargarListaLibros()
        {
            

            ObjBook = new ClsBook();
            ObjBookBl.Index(ref ObjBook);
            if (ObjBook.MenjaseError == null)
            {
                DgvLibros.DataSource = ObjBook.DtResultados;
            }
            else
            {
                MessageBox.Show(ObjBook.MenjaseError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void DgvAutores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvLibros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmBook_Load(object sender, System.EventArgs e)
        {

        }

        private void AgregarLibros_Click(object sender, System.EventArgs e)
        {
            ObjBook = new ClsBook()
            {
                IdAutores = Convert.ToInt32(TxtId.Text),
                Titulo = TxtTitulo.Text,
                Ano = Convert.ToInt32(TxtAño.Text),
                Genero = TxtGenero.Text,
                NumeroPaginas = Convert.ToInt32(TxtNumeroP.Text),


            };
            ObjBookBl.Create(ref ObjBook);

            if (ObjBook.MenjaseError == null)
            {
                MessageBox.Show("El ID: " + ObjBook.ValorScalar + ", Fue Agregado Correctamente");
                CargarListaLibros();
            }
            else
            {
                MessageBox.Show(ObjBook.MenjaseError, "Mensaje de error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                   
                  
                

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            foreach (DataGridViewRow fila in DgvLibros.Rows)
            {
                if (Convert.ToBoolean(fila.Cells["Eliminar"].Value))
                {

                    ObjBook = new ClsBook()
                    {
                        IdLibros = Convert.ToByte(fila.Cells["IdLibros"].Value)
                    };


                    ObjBookBl.Delete(ref ObjBook);
                    CargarListaLibros();


                }
            }

        }

        private void BtSelectall_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < DgvLibros.Rows.Count; i++)
            {
                DgvLibros.Rows[i].Cells[0].Value = true;
             }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            for (int i = 0; i < DgvLibros.Rows.Count; i++)
            {
                if (Convert.ToBoolean(DgvLibros.Rows[i].Cells[0].Value))
                    DgvLibros.Rows[i].Cells[0].Value = false;
                {

                }
            }
        }
    }
}
