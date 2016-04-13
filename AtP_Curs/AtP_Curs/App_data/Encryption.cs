using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtP_Curs.App_data
{
    // encryption data
    class Encryption
    {
        public string EncryptString(string start, int key)
        {
            byte[] arr = Encoding.Unicode.GetBytes(start);
            string result = Encrypt(arr, key);
            return result;
        }

        private static string Encrypt(byte[] arr, int key)
        {
            byte[] mass = new byte[arr.Length];

            for (int i = 0; i < mass.Length; ++i)
            {
                mass[i] = (byte)(arr[i] ^ key);
            }
            return Encoding.Unicode.GetString(mass);
        }
    }
}
