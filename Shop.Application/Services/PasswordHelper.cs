using Shop.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Application.Services
{
    public class PasswordHelper : IPasswordHelper
    {
        public string EncodePasswordMd5(string password) //encrypt using
        {
            Byte[] originalBytes;
            Byte[] encodingBytes;
            MD5 md5;

            // instantial MD5Cryptoserviceprovider , get bytes for original password and compute hash (encoded password)
            md5 = new MD5CryptoServiceProvider();
            originalBytes = ASCIIEncoding.Default.GetBytes(password);
            encodingBytes = md5.ComputeHash(originalBytes);
            // convert encode bytes back to a readable string
            return BitConverter.ToString(encodingBytes);
        }
    }
}
