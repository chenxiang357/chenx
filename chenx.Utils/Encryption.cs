using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace chenx.Utils
{
    /// <summary>
    /// 密码加密
    /// </summary>
    public class Encryption
    {
        /// <summary>
        /// MD5加密
        /// </summary>
        /// <param name="encryptionString">需要加密的字符串</param>
        /// <returns>返回小写的加密字符串</returns>
        public static string Md5_Encryption(string encryptionString)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] output = md5.ComputeHash(Encoding.Default.GetBytes(encryptionString));
                return BitConverter.ToString(output).Replace("-", "").ToLower();
            }
        }

        /// <summary>
        /// 对字符串进行SHA1加密，不可逆转
        /// </summary>
        /// <param name="encryptionString">需要加密的字符串</param>
        /// <returns></returns>
        public static string SHA1_Encryption(string encryptionString)
        {
            using (HashAlgorithm iSHA = new SHA1CryptoServiceProvider())
            {
                byte[] StrRes = Encoding.Default.GetBytes(encryptionString);
                StrRes = iSHA.ComputeHash(StrRes);
                StringBuilder EnText = new StringBuilder();
                foreach (byte iByte in StrRes)
                {
                    EnText.AppendFormat("{0:x2}", iByte);
                }
                return EnText.ToString();
            }
        }

        /// <summary>
        /// SHA256加密，不可逆转
        /// </summary>
        /// <param name="encryptionString">被加密的字符串</param>
        /// <returns></returns>
        public static string SHA256_Encryption(string encryptionString)
        {
            using (SHA256 s256 = new SHA256Managed())
            {
                byte[] byte1 = s256.ComputeHash(Encoding.Default.GetBytes(encryptionString));
                s256.Clear();
                return Convert.ToBase64String(byte1);
            }
        }

        /// <summary>
        /// SHA384加密，不可逆转
        /// </summary>
        /// <param name="encryptionString">被加密的字符串</param>
        /// <returns></returns>
        public static string SHA384_Encryption(string encryptionString)
        {
            using (SHA384 s384 = new SHA384Managed())
            {
                byte[] byte1 = s384.ComputeHash(Encoding.Default.GetBytes(encryptionString));
                s384.Clear();
                return Convert.ToBase64String(byte1);
            }
        }

        /// <summary>
        /// SHA512加密，不可逆转
        /// </summary>
        /// <param name="encryptionString">被加密的字符串</param>
        /// <returns></returns>
        public static string SHA512_Encryption(string encryptionString)
        {
            using (SHA512 s512 = new SHA512Managed())
            {
                byte[] byte1 = s512.ComputeHash(Encoding.Default.GetBytes(encryptionString));
                s512.Clear();
                return Convert.ToBase64String(byte1);
            }
        }

        //默认密钥向量
        private static byte[] Keys = { 0xEF, 0xAB, 0x56, 0x78, 0x90, 0x34, 0xCD, 0x12 };

        /// <summary>
        /// DES加密字符串
        /// </summary>
        /// <param name="encryptString">待加密的字符串</param>
        /// <param name="encryptKey">加密密钥,要求为8位</param>
        /// <returns>加密成功返回加密后的字符串，失败返回源串</returns>
        public static string EncryptDES(string encryptString, string encryptKey)
        {
            try
            {
                byte[] rgbKey = Encoding.UTF8.GetBytes(encryptKey.Substring(0, 8));
                byte[] rgbIV = Keys;
                byte[] inputByteArray = Encoding.UTF8.GetBytes(encryptString);
                DESCryptoServiceProvider dCSP = new DESCryptoServiceProvider();
                MemoryStream mStream = new MemoryStream();
                CryptoStream cStream = new CryptoStream(mStream, dCSP.CreateEncryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                cStream.Write(inputByteArray, 0, inputByteArray.Length);
                cStream.FlushFinalBlock();
                return Convert.ToBase64String(mStream.ToArray());
            }
            catch
            {
                return encryptString;
            }
        }

        /// <summary>
        /// DES解密字符串
        /// </summary>
        /// <param name="decryptString">待解密的字符串</param>
        /// <param name="decryptKey">解密密钥,要求为8位,和加密密钥相同</param>
        /// <returns>解密成功返回解密后的字符串，失败返源串</returns>
        public static string DecryptDES(string decryptString, string decryptKey)
        {
            try
            {
                if (decryptString != null && decryptString.Length > 0)
                {
                    byte[] rgbKey = Encoding.UTF8.GetBytes(decryptKey.Substring(0, 8));
                    byte[] rgbIV = Keys;
                    byte[] inputByteArray = Convert.FromBase64String(decryptString);
                    DESCryptoServiceProvider DCSP = new DESCryptoServiceProvider();
                    MemoryStream mStream = new MemoryStream();
                    CryptoStream cStream = new CryptoStream(mStream, DCSP.CreateDecryptor(rgbKey, rgbIV), CryptoStreamMode.Write);
                    cStream.Write(inputByteArray, 0, inputByteArray.Length);
                    cStream.FlushFinalBlock();
                    return Encoding.UTF8.GetString(mStream.ToArray());
                }
                else
                {
                    return "";
                }
               
            }
            catch
            {
                return decryptString;
            }
        }
    }

}
