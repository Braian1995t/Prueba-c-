using System;
using System.Data;

namespace Entities.Authors
{
    public class ClsAuthor
    {
        #region Atributos Privados

        private int _idAutores;
        private string _nombre, _apellido, _ciudad, _correoElectronico;
        private DateTime _fechaNacimiento;

        //Atributos de manejo de la base de datos
        private String _menjaseError, _valorScalar;
        private  DataTable _dtResultados;



        #endregion

        #region Atributos Publicos

        public int IdAutores { get => _idAutores; set => _idAutores = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public string Ciudad { get => _ciudad; set => _ciudad = value; }
        public string CorreoElectronico { get => _correoElectronico; set => _correoElectronico = value; }
        public DateTime FechaNacimiento { get => _fechaNacimiento; set => _fechaNacimiento = value; }
        public string MenjaseError { get => _menjaseError; set => _menjaseError = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }

     

        #endregion



    }
}
