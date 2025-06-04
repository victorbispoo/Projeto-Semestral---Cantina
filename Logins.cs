using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Runtime.Intrinsics.Arm;

namespace Projeto_Semestral___Cantina
{
    internal class Logins
    {
        public string Usuario { get; set; }
        public string SenhaHash { get; set; }
        public string Tipo { get; set; }

        public Logins(string usuario, string senha, string tipo)
        {
            Usuario = usuario;
            SenhaHash = GerarHash(senha);
            Tipo = tipo;
        }
        public static string GerarHash(string senha)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(senha);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }
        public bool ValidarSenha(string senha)
        {
            return SenhaHash == GerarHash(senha);
        }
        public override string ToString()
        {
            return $"Usuário: {Usuario} | Tipo: {Tipo}";
        }
    }
}
