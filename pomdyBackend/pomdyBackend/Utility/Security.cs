using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace pomdyBackend.Utility
{
    public class Security
    {
        private static string TOKEN_SECRET_KEY =
            "This is the super secret key to crypt end decrypt a token in the server.";

        private static string RGB_KEY = "Here is the secret key used to encrypt the data in database";
        private static string RGB_IV = "The initialization vector copied on encrypted data";

        private static string CLAIM_ID = "Identifier";

        public static string GenerateToken(string idStudent)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(TOKEN_SECRET_KEY);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(CLAIM_ID, idStudent)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

        public static int RetrieveIdFromToken(string jwtToken)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            JwtSecurityToken decoded = tokenHandler.ReadJwtToken(jwtToken);
            var claimReturned = decoded.Claims.First(claim => claim.Type.ToString().Equals(CLAIM_ID));
            return Convert.ToInt32(claimReturned.Value);
        }

        public static string Encrypt(string plainText)
        {
            byte[] encrypted; //Byte vector of encrypted string
            // Create a new AesManaged to encrypt like AES method    
            using (AesManaged aes = new AesManaged())
            {
                // Tailor the key and the initialization vector to the max size of AES method
                Rfc2898DeriveBytes rfc = new Rfc2898DeriveBytes(RGB_KEY, Encoding.ASCII.GetBytes(RGB_IV));
                aes.Key = rfc.GetBytes(aes.KeySize / 8);
                aes.IV = rfc.GetBytes(aes.BlockSize / 8);
                // Create encryptor
                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);
                // Create MemoryStream to write the encrypted data    
                using (MemoryStream ms = new MemoryStream())
                {
                    // Create crypto stream using the CryptoStream class. This class is the key to encryption    
                    // and encrypts and decrypts data from any given stream. In this case, we will pass a memory stream    
                    // to encrypt    
                    using (CryptoStream cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                    {
                        // Create StreamWriter and write data to a stream    
                        using (StreamWriter sw = new StreamWriter(cs))
                            sw.Write(plainText);
                        encrypted = ms.ToArray();
                    }
                }
            }

            // Return encrypted data in string format 
            return Convert.ToBase64String(encrypted);
        }
    }
}