using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace AppCmdHash_SHA256.AlgoritmoSHA256
{
    public class Cryptography_SHA256
    {

        public static string GeradorHashCode(string mensagem)
        {
            // 1- Pega os bytes da mesagem 
            byte[] bitsMensagem = System.Text.Encoding.UTF8.GetBytes(mensagem);
            
            // 2- Cria o objeto SHA256 que irá calcular o hash da mesagem 
            SHA256 CalculaHash = SHA256.Create();

            // 3- Executa o método [ComputeHash] para calcular o Hash e retornar os bytes 
            byte[] BytesHash = CalculaHash.ComputeHash(bitsMensagem);

            // 4- Converte os bytes para hexadecimal e retorna um string
            //Obs.: BitConvert retorna a string em caixa alta e com traços, para remover os traços 
            //      utilizei o método Replace e ToLwer para colocar a string em caixa baixa  
            string HashCoding = BitConverter.ToString(BytesHash).Replace("-","").ToLower();

            return HashCoding;

        }

    }
}
