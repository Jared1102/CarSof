using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Entidades;

namespace Manejadores
{
    public class ManejadorLéxico
    {
        private List<Tokens> listTokens = new List<Tokens>();
        public void HacerLexico(string texto, DataGridView tabla)
        {
            listTokens.Clear();
            int contador = 1;
            string[] lineas = texto.Split('\n');
            for (int i = 0; i < lineas.Length; i++)
            {

            }
            tabla.DataSource = listTokens.ToList();
        }

        private Tokens generarToken(int linea, string valor, int No)
        {
            return new Tokens
            {
                No = No,
                Valor = valor,
                Linea = linea,
                Tipo = obtenerTipo(valor)
            };
        }

        private string obtenerTipo(string valor)
        {
            string[] reservadas = { "Get" ,"*int","*string","*double","if","for","while","*arm","else"};
            string[] instrucciones = { "Run.Up", "Run.Stop", "Run.Turn", "On", "Off" };

            if (reservadas.Contains(valor))
            {
                return "Palabra Reservada";
            }

            if (instrucciones.Contains(valor))
            {
                return "Instrucción";
            }
            return "No identificable";
        }
    }
}
