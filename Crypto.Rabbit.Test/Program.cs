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

using System;

namespace Crypto.Rabbit.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            RabbitTest test = new RabbitTest();
            test.Test_A1_1();
            test.Test_A1_2();
            test.Test_A1_3();
            test.Test_A2_1();
            test.Test_A2_2();
            test.Test_A2_3();
        }
    }
}
