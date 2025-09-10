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

using System.Security.Cryptography;

namespace Crypto.Rabbit
{
    public class RabbitEncryptor : ICryptoTransform
    {
        private readonly RabbitCipher _rabbit;

        public RabbitCipher Cipher
        {
            get => _rabbit;
        }

        public RabbitEncryptor(RabbitCipher rabbit)
        {
            _rabbit = rabbit;
        }

        public bool CanReuseTransform => true;

        public bool CanTransformMultipleBlocks => true;

        public int InputBlockSize => 16;

        public int OutputBlockSize => 16;

        public void Dispose()
        {
            // No action required
        }

        public int TransformBlock(byte[] inputBuffer, int inputOffset, int inputCount, byte[] outputBuffer, int outputOffset)
        {
            return _rabbit.CipherBlock(inputBuffer, inputOffset, inputCount, outputBuffer, outputOffset);
        }

        public byte[] TransformFinalBlock(byte[] inputBuffer, int inputOffset, int inputCount)
        {
            return _rabbit.CipherBlock(inputBuffer, inputOffset, inputCount);
        }
    }
}
