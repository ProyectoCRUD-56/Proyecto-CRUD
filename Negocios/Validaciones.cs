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
        /// <returns>falso cuando hay campos que contienen caracteres no numéricos, verdadero en caso contrario</returns>
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
                        foreach (string nombre in nombresArray){
                            mensaje += $"{nombre}\n";
                        }
                    }
                    MessageBox.Show(mensaje+"solo pueden ser numéricos  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// Verifica que en los campos dados solo haya caracteres de lenguaje
        /// </summary>
        /// <param name="campos">un string que contiene los valores de todos los campos a validar separados por comas (sintaxis $"{variable},{variable}"</param>
        /// <returns>falso cuando hay campos que contienen caracteres distintos a caracteres de lenguaje, verdadero en caso contrario</returns>
        public bool Validar_solo_letras(string campos, string nombresCampos)
        {
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
                        foreach (string nombre in nombresArray)
                        {
                            mensaje += $"{nombre}\n";
                        }
                    }
                    MessageBox.Show(mensaje+"solo pueden contener caracteres de lenguaje  ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public bool Validar_solo_letras_()
        {
            return true;
        }
    }
}
