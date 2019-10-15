
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Utilities.Encoders;
using System.Text;

namespace AppCmdHash_SHA256.AlgoritmoSHA256
{
    public class BouncyCastle_SHA256
    {

        public static string GeradorHashCode(string mensagem)
        {
            // 1- Pega os bytes da mesagem 
            byte[] bitsMensagem = Encoding.UTF8.GetBytes(mensagem);

            // 2- Cria o objeto SHA256 que irá calcular o hash da mesagem 
            Sha256Digest CalculaHash = new Sha256Digest();
            CalculaHash.BlockUpdate(bitsMensagem, 0, bitsMensagem.Length);

            // 3- Executa o método [ComputeHash] para calcular o Hash e retornar os bytes 
            byte[] BytesHash = new byte[CalculaHash.GetDigestSize()];
            CalculaHash.DoFinal(BytesHash, 0);

            // 4- Converte os bytes para hexadecimal e retorna um array de bytes
            byte[] sha256hex2 = Hex.Encode(BytesHash);
            // 4.1- Convert em uma string o array de bytes 
            string sha256hex = Encoding.UTF8.GetString(sha256hex2).ToLower();

            return sha256hex;
        }

    }
}
