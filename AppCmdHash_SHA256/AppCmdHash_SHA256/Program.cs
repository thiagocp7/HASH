using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppCmdHash_SHA256.AlgoritmoSHA256;

namespace AppCmdHash_SHA256
{
    public class Program
    {
        static void Main(string[] args)
        {

            string Mensagem = "O SHA-256 é um algoritmo de hash, que tem como objetivo gerar uma impressão digital (Hash Code) de uma mensagem ou arquivo,";
            Mensagem += "para possibilitar a verificação da integridade e autenticidade da mensagem ou do arquivo garantindo a integridade do conteúdo da informação transitada.";


            string HashCode1 = Cryptography_SHA256.GeradorHashCode(Mensagem);

            Console.WriteLine("Cryptography_SHA256: " + HashCode1);

            string HashCode2 = BouncyCastle_SHA256.GeradorHashCode(Mensagem);

            Console.WriteLine("BouncyCastle_SHA256: " + HashCode2);

            Console.Read();

        }
    }
}
