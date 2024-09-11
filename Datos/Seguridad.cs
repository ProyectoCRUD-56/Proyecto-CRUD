using System;
using System.Security.Cryptography;
using System.Text;

public class Seguridad
{
    public static string HashPassword(string password)
    {
        using (SHA256 sha256 = SHA256.Create())
        {
            // Convertir la contraseña a NVARCHAR como lo hace SQL Server
            byte[] passwordBytes = Encoding.Unicode.GetBytes(password);

            // Hashear los bytes
            byte[] hashBytes = sha256.ComputeHash(passwordBytes);

            // Convertir los bytes en una cadena hexadecimal en mayúsculas
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("X2"));  // 'X2' produce letras mayúsculas
            }
            return builder.ToString();
        }
    }
}
