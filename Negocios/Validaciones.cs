using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Negocios
{
    public class Validaciones
    {
        public Validaciones() { }
        string[] camposArray;
        string[] nombresArray;
        string mensaje = string.Empty;
        /// <summary>
        /// Verifica que no haya ningún campo vacío 
        /// </summary>
        /// <param name="campos">un string que contiene los valores de todos los campos a validar separados por comas (sintaxis $"{variable},{variable}"</param>
        /// <returns>falso cuando hay campos sin rellenar, verdadero cuando todos están llenados</returns>

        public bool Validar_campos_vacios(string campos)
        {
            campos = campos.Replace(" ", "");
            string[] camposArray = campos.Split(',');
            foreach (var campo in camposArray)
            {
                if (string.IsNullOrEmpty(campo))
                {
                    MessageBox.Show("Por favor llene todos los campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Verifica que en los campos dados solo haya valores numéricos
        /// </summary>
        /// <param name="campos">un string que contiene los valores de todos los campos a validar separados por comas (sintaxis $"{variable},{variable}"</param>
        /// <param name="nombresCamposNumericos">un string que contiene los nombres de todos los campos a validar separados por comas (sintaxis $"{variable},{variable}"</param>
        /// <returns>falso cuando hay campos que contienen caracteres distintos a caracteres de numericos, verdadero en caso contrario</returns>
        public bool Validar_solo_numero(string campos, string nombresCamposNumericos)
        {
            campos = campos.Replace(" ","");
            nombresCamposNumericos = nombresCamposNumericos.Replace(" ", "");
            camposArray = campos.Split(',');
            nombresArray = nombresCamposNumericos.Split(',');
            mensaje=string.Empty;
            foreach (var campo in camposArray)
            {
                if (!System.Text.RegularExpressions.Regex.IsMatch(campo, @"^\d*$"))
                {
                    if(nombresArray.Length > 1)
                    {
                        mensaje += "Los campos de:\n";
                    }
                    else
                    {
                        mensaje += "El campo de:\n";
                    }
                    foreach (string nombre in nombresArray){
                        mensaje += $"{nombre}\n";
                    }
                    MessageBox.Show(mensaje+"solo pueden ser numéricos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Verifica que en los campos dados solo haya caracteres de lenguaje
        /// </summary>
        /// <param name="campos">un string que contiene los valores de todos los campos a validar separados por comas (sintaxis $"{variable},{variable}"</param>
        /// <param name="nombresCampos">un string que contiene los nombres de todos los campos a validar separados por comas (sintaxis $"{variable},{variable}"</param>
        /// <returns>falso cuando hay campos que contienen caracteres distintos a caracteres de lenguaje, verdadero en caso contrario</returns>
        public bool Validar_solo_letras(string campos, string nombresCampos)
        {
            nombresCampos = nombresCampos.Replace(" ", "");

            camposArray = campos.Split(',');
            nombresArray = nombresCampos.Split(',');
            mensaje = string.Empty;
            foreach (var campo in camposArray)
            {

                if (!System.Text.RegularExpressions.Regex.IsMatch(campo, @"^[a-zA-Z ]*$"))

                {
                    if (nombresArray.Length > 1)
                    {
                        mensaje += "Los campos de:\n";

                    }
                    {
                        mensaje += "El campo de:\n";
                    }
                    foreach (string nombre in nombresArray)
                    {
                        mensaje += $"{nombre}\n";
                    }
                    MessageBox.Show(mensaje + "solo pueden contener caracteres de lenguaje", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Verifica que los campos dados no superen su límite de caracteres
        /// </summary>
        /// <param name="campos">un string que contiene los valores de todos los campos a validar separados por comas (sintaxis $"{variable},{variable}"</param>
        /// <param name="nombresCampos">un string que contiene los nombres de todos los campos a validar separados por comas (sintaxis $"{variable},{variable}"</param>
        /// <param name="limites">un string que contiene los limites de caracteres de todos los campos a validar separados por comas (sintaxis $"{variable},{variable}"</param>
        /// <returns>Verdadero en caso de que todos los datos cumplan con el límite de caracteres establecido, falso en caso contrario  </returns>
        public bool ValidarLargo(string campos, string nombresCampos, string limites)
        {
            camposArray = campos.Split(',');
            nombresArray = nombresCampos.Split(',');
            string[] limitesArray = limites.Split(',');
            mensaje = string.Empty;
            int limiteInt;
            for (int i = 0; i < camposArray.Length;i++) {
                limiteInt = int.Parse(limitesArray[i]);
                if (camposArray[i].Length>limiteInt)
                {
                    MessageBox.Show("El límite de caracteres de: "+nombresArray[i]+" es: "+limiteInt+" asegúrese de no sobrepasarlo");
                    return false;
                }
            }
            return true;
        }
    }
}
