# RabbitCipher

A .NET Core implementation of the Rabbit stream cipher algorithm

## The Rabbit Cipher Algorithm

Rabbit is a stream cipher algorithm described in [RFC4503][1].

It was published in 2003/2005 by its authors in a [paper][2]. The reference [source code][3] is implemented in C. 
According to [Erik Zenner][4], the algorithm was released into the public domain in 2008, and it can be freely used for any purpose.

## This Rabbit Implementation

This version is a "clean-room" implementation based on the RFC only. It has been tested against the test vectory given in the RFC.

It is intended to be used in the same way that symmetric ciphers provided in the .NET (Core) framework are being used. 
A few examples for this are included.

## Instructions for Use

1. Clone this project via git
2. Build with Visual Studio (Community edition works)
3. Include the Crypto.Rabbit.DLL in your own project
4. Instantiate the RabbitCipher class

## References

[1]: https://tools.ietf.org/html/rfc4503
[2]: https://www.ecrypt.eu.org/stream/p3ciphers/rabbit/rabbit_p3.pdf
[3]: http://en.pudn.com/Download/item/id/600370.html
[4]: https://web.archive.org/web/20090630021733/http://www.ecrypt.eu.org/stream/phorum/read.php?1,1244
