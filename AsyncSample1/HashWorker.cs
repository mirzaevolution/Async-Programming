/*
 * 
 *  Source codes under this project are licensed under MIT Project.
 *  Created by: Mirza Ghulam Rasyid
 * 
 * 
 */


using System;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Configuration;
using System.Threading;

namespace AsyncSample1
{
    public class HashWorker
    {
        /// <summary>
        /// Gets timer configuration from appSettings
        /// </summary>
        /// <returns>Timer in second</returns>
        private int GetSleepTimer()
        {
            string timerStr = ConfigurationManager.AppSettings["timer"];
            int timer = 0;
            return int.TryParse(timerStr, out timer) ? timer * 1000 : 5 * 1000;
        }

        /// <summary>
        /// Hashes provided text using SHA512
        /// </summary>
        /// <param name="text">Plain text</param>
        /// <returns>Hashed data with Base64 Encoded</returns>
        private string GetSHA512(string text)
        {
            using(SHA512Managed sha512 = new SHA512Managed())
            {
                byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                byte[] hash = sha512.ComputeHash(textBytes,0,textBytes.Length);
                return Convert.ToBase64String(hash);
            }
        }
        
        /// <summary>
        /// Main hash method that demonstrates the heavy processing method
        /// </summary>
        /// <param name="text">Plain text</param>
        /// <returns>Hashed data with Base64 Encoded String</returns>
        public string HashData(string text)
        {
            int timer = GetSleepTimer();
            Thread.Sleep(timer);
            return GetSHA512(text);
        }

    }
}
