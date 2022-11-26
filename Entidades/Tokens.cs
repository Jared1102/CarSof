namespace Entidades
{
    public class Tokens
    {
        private int _No;
        private string _Valor;
        private string _Tipo;
        private int _Linea;

        public int No { get => _No; set => _No = value; }
        public string Valor { get => _Valor; set => _Valor = value; }
        public string Tipo { get => _Tipo; set => _Tipo = value; }
        public int Linea { get => _Linea; set => _Linea = value; }
    }
}
