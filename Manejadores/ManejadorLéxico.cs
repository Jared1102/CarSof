using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Entidades;

namespace Manejadores
{
    public class ManejadorLéxico
    {
        private List<Tokens> listTokens = new List<Tokens>();
        public List<Tokens> HacerLexico(string texto, DataGridView tabla)
        {
            int contador = 1;
            listTokens.Clear();
            string[] linea = texto.Split('\n');
            for (int i = 0; i < linea.Length; i++)
            {
                if (linea[i].StartsWith("#")){
                    listTokens.Add(generarToken((i + 1), linea[i], contador));
                    contador++;
                }
                else
                {
                    string[] token = linea[i].Split(' ', '\r', '(', ')');
                    for (int j = 0; j < token.Length; j++)
                    {
                        if (!string.IsNullOrEmpty(token[j]) || !string.IsNullOrWhiteSpace(token[j]))
                        {
                            listTokens.Add(generarToken((i + 1), token[j], contador));
                            contador++;
                        }
                    }
                }
                
                
            }
            tabla.DataSource = listTokens.ToList();
            return listTokens;
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
            string[] reservadas = {"Traer"};
            string[] instrucciones = { "Run.Up", "Run.Stop", "Run.Turn", "On", "Off" ,"wait"};
            string[] tipoDato = { "*int", "*decimal", "*string", "*bool" };

            if (valor == "$$")
            {
                return "Cierre de bloque";
            }
            if (reservadas.Contains(valor))
            {
                return "Palabra Reservada";
            }

            if (instrucciones.Contains(valor))
            {
                return "Instrucción";
            }
            if (listTokens.Count!=0)
            {
                if (listTokens[listTokens.Count-1].Tipo=="Instrucción")
                {
                    return "Expresión de instrucción";
                }
            }

            
            
            if (valor=="$")
            {
                return "Apertura de bloque";
            }
            if (listTokens.Count != 0)
            {
                if (listTokens[listTokens.Count - 1].Tipo == "Condicional")
                {
                    return "Expresión de condicional";
                }
            }
            if (valor=="if")
            {
                return "Condicional";
            }
            if (ERComentario(valor))
            {
                return "Comentario";
            }
            if (tipoDato.Contains(valor))
            {
                return "Tipo de dato";
            }
            if (asignacion(valor))
            {
                return "Expresión de asignación";
            }
            if (listTokens.Count != 0)
            {
                if (listTokens[listTokens.Count - 1].Tipo == "Tipo de dato")
                {
                    return "Identificador";
                }
            }

            return "No identificable";
        }

        private bool asignacion(string valor)
        {
            string ER = @"\A[A-Za-z]\w*?=[0-9]+?\Z";
            if (Regex.IsMatch(valor, ER))
            {
                return true;
            }
            return false;
        }

        private bool ERComentario(string valor)
        {
            string ER = @"#\w*?";
            if (Regex.IsMatch(valor, ER))
            {
                return true;
            }
            return false;
        }
    }
}
