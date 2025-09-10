#region copyright
/**
 * 
 * This software is licensed under the MIT License (SPDX: MIT). See LICENSE file for details. 
 * Copyright (c) 2020 koozala
 * 
 * This is the library implementation of the Rabbit stream cipher. For details see: 
 * https://tools.ietf.org/html/rfc4503 
 * 
 **/
#endregion

using Crypto.Rabbit;
using System;
using System.Text;

namespace EncryptString
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] key = new byte[]
            {
                0x00, 0x01, 0x02, 0x03, 0x04, 0x05, 0x6, 0x7,
                0x08, 0x09, 0x0A, 0x0B, 0x0C, 0x0D, 0xE, 0xF
            };

            string plainText = "The quick brown fox jumps over the lazy dog";
            byte[] plainBytes = Encoding.UTF8.GetBytes(plainText);

            // Encoding 

            RabbitCipher rabbit = new RabbitCipher(key);
            byte[] encoded = new byte[plainBytes.Length];

            for (int j = 0; j < plainBytes.Length; j++)
            {
                encoded[j] = rabbit.CipherByte(plainBytes[j]);
            }

            // Decoding

            RabbitCipher rabbit2 = new RabbitCipher(key);
            byte[] decoded = new byte[encoded.Length];

            for (int j = 0; j < encoded.Length; j++)
            {
                decoded[j] = rabbit2.CipherByte(encoded[j]);
            }

            Console.WriteLine($"Plain  : {plainText}");
            Console.WriteLine($"Encoded: {Encoding.UTF8.GetString(encoded)}");
            Console.WriteLine($"Decoded: {Encoding.UTF8.GetString(decoded)}");
        }
    }
}
