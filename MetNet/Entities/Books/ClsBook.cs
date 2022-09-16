using System;
using System.Data;

namespace Entities.Books
{
    public class ClsBook
    {

        #region Atributos Privados

        private int _idAutores, _idLibros, _NumeroPaginas, _ano;
        private string _titulo, _genero;

        //Atributos de manejo de la base de datos

        private String _menjaseError, _valorScalar;
        private DataTable _dtResultados;






        #endregion

        #region Atributos Publicos
        public int IdAutores { get => _idAutores; set => _idAutores = value; }
        public int IdLibros { get => _idLibros; set => _idLibros = value; }
        public int NumeroPaginas { get => _NumeroPaginas; set => _NumeroPaginas = value; }
        public int Ano { get => _ano; set => _ano = value; }
        public string Titulo { get => _titulo; set => _titulo = value; }
        public string Genero { get => _genero; set => _genero = value; }
        public string MenjaseError { get => _menjaseError; set => _menjaseError = value; }
        public string ValorScalar { get => _valorScalar; set => _valorScalar = value; }
        public DataTable DtResultados { get => _dtResultados; set => _dtResultados = value; }
        #endregion
    }
}
