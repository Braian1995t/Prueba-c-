using DataAccess.DataBase;
using Entities.Authors;
using System;
using System.Data;

namespace BusinessLogic.Authors
{
    public class ClsAuthorBl
    {
        #region Variable privadas

        private ClsDataBase ObjDataBase = null;

        #endregion

        #region Metodo index

        public void Index(ref ClsAuthor objAuthors)
        {

            ObjDataBase = new ClsDataBase()
            {
                NombreTabla="Autores",
                NombreSP = "[SCH_GENERAL].[SP_Autores_Index]",
                Scalar= false
            };
            Ejecutar(ref objAuthors);
            }
        #endregion

        #region CRUD Autores


        public void  Create(ref ClsAuthor objAuthors)
        {

            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Autores",
                NombreSP = "[SCH_GENERAL].[SP_Autores_Create]",
                Scalar = true
            };

            ObjDataBase.Dtparametros.Rows.Add(@"@Nombre", "16", objAuthors.Nombre);
            ObjDataBase.Dtparametros.Rows.Add(@"@Apellido", "16", objAuthors.Apellido);
            ObjDataBase.Dtparametros.Rows.Add(@"@FechaNacimiento", "13", objAuthors.FechaNacimiento);
            ObjDataBase.Dtparametros.Rows.Add(@"@Ciudad", "16", objAuthors.Ciudad);
            ObjDataBase.Dtparametros.Rows.Add(@"@CorreoElectronico", "16", objAuthors.CorreoElectronico);

            Ejecutar(ref objAuthors);


        }

        public void Read(ref ClsAuthor objAuthors)
        {

            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Autores",
                NombreSP = "[SCH_GENERAL].[SP_Autores_Read]",
                Scalar = false
            };

            ObjDataBase.Dtparametros.Rows.Add(@"@IdAutores", "4", objAuthors.IdAutores);
            Ejecutar(ref objAuthors);
        }

        public void Update(ref ClsAuthor objAuthors)
        {

            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Autores",
                NombreSP = "[SCH_GENERAL].[SP_Autores_Update]",
                Scalar = true
            };
            ObjDataBase.Dtparametros.Rows.Add(@"@IdAutores", "4", objAuthors.IdAutores);
            ObjDataBase.Dtparametros.Rows.Add(@"@Nombre", "16", objAuthors.Nombre);
            ObjDataBase.Dtparametros.Rows.Add(@"@Apellido", "16", objAuthors.Apellido);
            ObjDataBase.Dtparametros.Rows.Add(@"@FechaNacimiento", "13", objAuthors.FechaNacimiento);
            ObjDataBase.Dtparametros.Rows.Add(@"@Ciudad", "16", objAuthors.Ciudad);
            ObjDataBase.Dtparametros.Rows.Add(@"@CorreoElectronico", "16", objAuthors.CorreoElectronico);

            Ejecutar(ref objAuthors);
        }

        public void Delete(ref ClsAuthor objAuthors)
        {

            ObjDataBase = new ClsDataBase()
            {
                NombreTabla = "Autores",
                NombreSP = "[SCH_GENERAL].[SP_Autores_Delete]",
                Scalar = true
            };


            ObjDataBase.Dtparametros.Rows.Add(@"@IdAutores", "4", objAuthors.IdAutores);
            Ejecutar(ref objAuthors);
        }
        #endregion

        #region Metodos privados
        private void Ejecutar(ref ClsAuthor ObjAuthor)
        {
            ObjDataBase.CRUD(ref ObjDataBase);
            if (ObjDataBase.MensajeErrorDB == null)
            {
                if (ObjDataBase.Scalar)
                {
                    ObjAuthor.ValorScalar = ObjDataBase.ValorScalar;

                }
                else
                {
                    ObjAuthor.DtResultados = ObjDataBase.DsResultados.Tables[0];
                    if (ObjAuthor.DtResultados.Rows.Count == 1)
                    {
                        foreach (DataRow item in ObjAuthor.DtResultados.Rows)
                        {
                            ObjAuthor.IdAutores = Convert.ToInt16(item["IdAutores"].ToString());
                            ObjAuthor.Nombre = item["Nombre"].ToString();
                            ObjAuthor.Apellido = item["Apellido"].ToString();
                            ObjAuthor.FechaNacimiento = Convert.ToDateTime(item["FechaNacimiento"].ToString());
                            ObjAuthor.Ciudad = item["Ciudad"].ToString();
                            ObjAuthor.CorreoElectronico = item["CorreoElectronico"].ToString();
                        }
                    }
                }
            }
            else
            {
                ObjAuthor.MenjaseError = ObjDataBase.MensajeErrorDB;
            }
        }
        #endregion

    }
}
