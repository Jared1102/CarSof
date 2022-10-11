using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Manejadores
{
    public class ManejadorLéxico
    {
        private List<Tokens> listTokens = new List<Tokens>();
        public void HacerLexico(string texto, DataGridView tabla)
        {
            int contador = 1;
            string[] lineas = texto.Split('\n');
            for (int i = 0; i < lineas.Length; i++)
            {
                string[] tokens = lineas[i].Split(' ');
                for (int j = 0; j < tokens.Length; j++)
                {
                    listTokens.Add(generarToken(i, tokens[j],contador));
                    contador++;
                }
            }
            tabla.DataSource = listTokens.ToList();
        }

        private Tokens generarToken(int linea, string valor, int No)
        {
            return new Tokens
            {
                No = No,
                Valor = valor,
                Linea = linea
            };
        }
    }
}
