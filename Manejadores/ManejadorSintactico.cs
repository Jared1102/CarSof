using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud;
using System.Windows.Forms;

namespace Manejadores
{
    public class ManejadorSintactico
    {
        private Grafico grafico = new Grafico();
        private string[] parametros;
        private int numericValue;
        private int contadorErrores=0;
        private List<ErroresSintacticos> erroresSintacticos= new List<ErroresSintacticos>();
        public void HacerSintactico(List<Tokens> tokens, DataGridView tablaErrores)
        {
            for (int i = 0; i < tokens.Count-1; i++)
            {
                switch (tokens[i].Tipo)
                {
                    case "Instrucción": obtenerSintacticoInstruccion(tokens[i], tokens[i+1], tokens); break;
                    case "Condicional": obtenerSintacticoCondicional(tokens[i], tokens[i + 1], tokens); break;
                }
            }

            tablaErrores.DataSource = erroresSintacticos.ToList();
        }

        private void obtenerSintacticoCondicional(Tokens token1, Tokens token2, List<Tokens> tokens)
        {
            if (!string.Equals("Expresión de condicional", token2.Tipo))
            {
                contadorErrores++;
                erroresSintacticos.Add(new ErroresSintacticos
                {
                    Id = contadorErrores,
                    Error= "if requiere al menos una expresión.",
                    Recomendacion = "Agregar una expresión.",
                    Token = token2.Valor,
                    Linea = token2.Linea.ToString()
                });
            }
            else
            {
                if (buscarIdentificador(token2.Valor,tokens))
                {
                    contadorErrores++;
                    erroresSintacticos.Add(new ErroresSintacticos
                    {
                        Id = contadorErrores,
                        Error = string.Format("El identificador {0} no existe en el contexto actual.", token2.Valor),
                        Recomendacion = "Agregar una expresión o declarar un identificador.",
                        Token = token1.Valor,
                        Linea = token1.Linea.ToString()
                    });
                }
            }
        }

        private void obtenerSintacticoInstruccion(Tokens tokens1, Tokens tokens2, List<Tokens> tokens)
        {
            
            switch (tokens1.Valor)
            {
                case "On":
                case "Off":
                case "Run.Stop":
                    {
                        if (string.Equals("Expresión de instrucción",tokens2.Tipo))
                        {
                            contadorErrores++;
                            erroresSintacticos.Add(new ErroresSintacticos
                            {
                                Id = contadorErrores,
                                Error = string.Format("La instrucción {0} no requiere expresiones.", tokens1.Valor),
                                Recomendacion = "Eliminar los parametros de la instrucción.",
                                Token = tokens1.Valor,
                                Linea = tokens1.Linea.ToString()
                            });
                        }

                    } break;
                case "wait":
                case "Run.Turn":
                    {
                        if (!string.Equals("Expresión de instrucción", tokens2.Tipo))
                        {
                            contadorErrores++;
                            erroresSintacticos.Add(new ErroresSintacticos
                            {
                                Id = contadorErrores,
                                Error = string.Format("La instrucción {0} requiere expresiones.", tokens1.Valor),
                                Recomendacion = "Agregar una expresión o declarar un identificador.",
                                Token = tokens1.Valor,
                                Linea = tokens1.Linea.ToString()
                            });
                        }
                        else
                        {
                            if (!int.TryParse(tokens2.Valor, out numericValue))
                            {
                                if (buscarIdentificador(tokens2.Valor, tokens))
                                {
                                    contadorErrores++;
                                    erroresSintacticos.Add(new ErroresSintacticos
                                    {
                                        Id = contadorErrores,
                                        Error = string.Format("El identificador {0} no existe en el contexto actual", tokens2.Valor),
                                        Recomendacion = "Agregar una expresión o declarar el identificador.",
                                        Token = tokens1.Valor,
                                        Linea = tokens1.Linea.ToString()
                                    });
                                }
                            }
                            else
                            {
                                if (!int.TryParse(tokens2.Valor, out numericValue))
                                {
                                    contadorErrores++;
                                    erroresSintacticos.Add(new ErroresSintacticos
                                    {
                                        Id = contadorErrores,
                                        Error = string.Format("La instrucción {0} requiere una expresión o un identificador.", tokens1.Valor),
                                        Recomendacion = "Agregar una expresión o declarar el identificador.",
                                        Token = tokens1.Valor,
                                        Linea = tokens1.Linea.ToString()
                                    });
                                }
                            }
                            
                        }
                    }
                    break;
                case "Run.Up":
                    {
                        if (!string.Equals("Expresión de instrucción", tokens2.Tipo))
                        {
                            contadorErrores++;
                            erroresSintacticos.Add(new ErroresSintacticos
                            {
                                Id = contadorErrores,
                                Error = string.Format("La instrucción {0} requiere expresiones.", tokens1.Valor),
                                Recomendacion = "Agregar una expresión o declarar el identificador.",
                                Token = tokens1.Valor,
                                Linea = tokens1.Linea.ToString()
                            });
                            //grafico.Mensaje(string.Format("La instrucción {0} requiere expresiones.", tokens1.Valor), "Error al compilar", MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (revisarParametros(tokens2))
                            {
                                contadorErrores++;
                                erroresSintacticos.Add(new ErroresSintacticos
                                {
                                    Id = contadorErrores,
                                    Error = string.Format("La instrucción {0} requiere al menos 2 argumentos.", tokens1.Valor),
                                    Recomendacion = "Agregar dos expresiones o declarar los identificadores.",
                                    Token = tokens1.Valor,
                                    Linea = tokens1.Linea.ToString()
                                });
                                //grafico.Mensaje(string.Format("La instrucción {0} requiere al menos 2 argumentos.", tokens1.Valor), "Error al compilar", MessageBoxIcon.Error);
                            }
                            else
                            {
                                parametros = tokens2.Valor.Split(',');
                                if (parametros.Length != 0)
                                {
                                    if (!string.IsNullOrEmpty(parametros[0]))
                                    {
                                        verficarParametros(parametros[0], tokens1, tokens);
                                    }
                                    if (!string.IsNullOrEmpty(parametros[1]))
                                    {
                                        if (!(parametros[1].Contains("front") || parametros[1].Contains("back")))
                                        {
                                            verficarParametros(parametros[1], tokens1, tokens);
                                        }
                                        
                                    }
                                }
                            }   
                        }
                    }
                    break;
            }
        }

        private void verficarParametros(string v, Tokens token, List<Tokens> tokens)
        {
            if (!int.TryParse(v, out numericValue))
            {
                if (buscarIdentificador(v, tokens))
                {
                    contadorErrores++;
                    erroresSintacticos.Add(new ErroresSintacticos
                    {
                        Id = contadorErrores,
                        Error = string.Format("El identificador {0} no existe en el contexto actual", v),
                        Recomendacion = "Agregar dos expresiones o declarar los identificadores.",
                        Token = token.Valor,
                        Linea = token.Linea.ToString()
                    });
                    //grafico.Mensaje(string.Format("El identificador {0} no existe en el contexto actual", v), "Error al compilar", MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!int.TryParse(v, out numericValue))
                {
                    contadorErrores++;
                    erroresSintacticos.Add(new ErroresSintacticos
                    {
                        Id = contadorErrores,
                        Error = string.Format("La instrucción {0} requiere una expresión o un identificador.", v),
                        Recomendacion = "Agregar dos expresiones o declarar los identificadores.",
                        Token = token.Valor,
                        Linea = token.Linea.ToString()
                    });
                    //grafico.Mensaje(string.Format("La instrucción {0} requiere una expresión aritmetica o un identificador.", v), "Error al compilar", MessageBoxIcon.Error);
                }
            }
        }

        private bool revisarParametros(Tokens tokens2)
        {
            int contador=0;
            for (int i = 0; i < tokens2.Valor.Length; i++)
            {
                if (string.Equals(tokens2.Valor[i].ToString(),","))
                {
                    contador++;
                }
            }
            if (contador==1)
            {
                return false;
            }
            return true;
        }

        private bool buscarIdentificador(string valor, List<Tokens> tokens)
        {
            foreach (var item in tokens)
            {
                if (item.Tipo=="Identificador" || item.Tipo=="Expresión de asignación")
                {
                    if (item.Valor.Contains(valor))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
