using DataAccess.DataBase;
using Entities.Books;
using System;
using System.Data;

namespace BusinessLogic.Books
{
    public class ClsBookBl
    {

        #region Variable privadas

        private ClsDataBase ObjDataBase = null;

        #endregion

        #region Metodo index

        public void Index(ref ClsBook objBooks)
        {

            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Libros",
                NombreSP = "[SCH_GENERAL].[SP_Libros_Index]",
                Scalar = false
            };
            Ejecutar(ref objBooks);
        }


        #endregion
        #region CRUD Libros

        public void Read(ref ClsBook objBooks)
        {

            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Libros",
                NombreSP = "[SCH_GENERAL].[SP_Libros_Read]",
                Scalar = false
            };

            ObjDataBase.Dtparametros.Rows.Add(@"@IdLibros", "4", objBooks.IdLibros);
            Ejecutar(ref objBooks);
        }

        public void Create(ref ClsBook objBooks)
        {

            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Libros",
                NombreSP = "[SCH_GENERAL].[SP_Libros_Create]",
                Scalar = true
            };

            ObjDataBase.Dtparametros.Rows.Add(@"@IdAutores", "4", objBooks.IdAutores);
            ObjDataBase.Dtparametros.Rows.Add(@"@Titulo", "16", objBooks.Titulo);
            ObjDataBase.Dtparametros.Rows.Add(@"@Ano", "4", objBooks.Ano);
            ObjDataBase.Dtparametros.Rows.Add(@"@Genero", "16", objBooks.Genero);
            ObjDataBase.Dtparametros.Rows.Add(@"@NumeroPaginas", "4", objBooks.NumeroPaginas);

            Ejecutar(ref objBooks);


        }

        public void Delete(ref ClsBook objBooks)
        {


            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Libros",
                NombreSP = "[SCH_GENERAL].[SP_Libros_Delete]",
                Scalar = true
            };
            ObjDataBase.Dtparametros.Rows.Add(@"@IdLibros", "4", objBooks.IdLibros);
            Ejecutar(ref objBooks);


        }



        #endregion

        #region Metodos privados
        private void Ejecutar(ref ClsBook ObjBook)
        {
            ObjDataBase.CRUD(ref ObjDataBase);
            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjBook.ValorScalar = ObjDataBase.ValorScalar;

                }
                else
                {
                    ObjBook.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjBook.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjBook.DtResultados.Rows)
                        {
                            ObjBook.IdLibros = Convert.ToInt16(item["IdLibros"].ToString());
                            ObjBook.IdAutores = Convert.ToInt16(item["IdAutores"].ToString());
                            ObjBook.Titulo = item["Titulo"].ToString();
                            ObjBook.Ano = Convert.ToInt16(item["Ano"].ToString());
                            ObjBook.Genero = item["Genero"].ToString();
                            ObjBook.NumeroPaginas = Convert.ToInt16(item["NumeroPaginas"].ToString());
                        }
                    }
                }
            }
            else
            {
                ObjBook.MenjaseError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion

    }
}
