using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace MD5Help
{
    public class MD5Helper
    {
        /// <summary>
        /// 获取32位MD5字符串
        /// </summary>
        /// <param name="str">需要转换的字符串</param>
        /// <returns>MD5字符串</returns>
        public static string Get32Md5String(string str)
        {
            string md5string = string.Empty;
            MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            byte[] md5Bytes = md5.ComputeHash(buffer);
            for (int i = 0; i < md5Bytes.Length; i++)
            {
                md5string += md5Bytes[i].ToString("x2");
            }
            return md5string;
        }
        /// <summary>
        /// 获取16位MD5字符串
        /// </summary>
        /// <param name="str">需要转换的字符串</param>
        /// <returns>MD5字符串</returns>
        public static string Get16Md5String(string str)
        {
            string md5string = string.Empty;
            MD5 md5 = MD5.Create();
            byte[] buffer = Encoding.UTF8.GetBytes(str);
            byte[] md5Bytes = md5.ComputeHash(buffer);
            for (int i = 4; i < 12; i++)
            {
                md5string += md5Bytes[i].ToString("x2");
            }
            return md5string;
        }
        /// <summary>
        /// 获取文件的MD5值
        /// </summary>
        /// <param name="path">文件的路径</param>
        /// <returns>MD5字符串</returns>
        public static string Get32Md5FileString(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            string md5string = string.Empty;
            MD5 md5 = MD5.Create();
            byte[] md5Bytes = null;
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                md5Bytes = md5.ComputeHash(fsRead);
            }

            for (int i = 0; i < md5Bytes.Length; i++)
            {
                md5string += md5Bytes[i].ToString("x2");
            }
            return md5string;
        }

        /// <summary>
        /// 获取文件的MD5值
        /// </summary>
        /// <param name="path">文件的路径</param>
        /// <returns>MD5字符串</returns>
        public static string Get16Md5FileString(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException();
            }

            string md5string = string.Empty;
            MD5 md5 = MD5.Create();
            byte[] md5Bytes = null;
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                md5Bytes = md5.ComputeHash(fsRead);
            }

            for (int i = 4; i < 12; i++)
            {
                md5string += md5Bytes[i].ToString("x2");
            }
            return md5string;
        }
    }
}
