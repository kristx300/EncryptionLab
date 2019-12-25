using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RsaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //p and q for RSA-100
            //string p = "37975227936943673922808872755445627854565536638199";
            //string q = "40094690950920881030683735292761468389214899724061";

            string p = "61";
            string q = "53";

            //Convert string to BigInteger
            BigInteger rsa_p = BigInteger.Parse(p);
            BigInteger rsa_q = BigInteger.Parse(q);

            //n = p * q
            BigInteger rsa_n = BigInteger.Multiply(rsa_p, rsa_q);

            //phi(n) = (p-1)*(q-1)
            BigInteger rsa_fn = BigInteger.Multiply((rsa_p - 1), (rsa_q - 1));

            BigInteger rsa_e = 17;

            //Compute d
            BigInteger rsa_d = BigInteger.ModPow(rsa_e, (rsa_fn - 1), rsa_fn);

            //Encrypt the message, in this case 3007
            //C = (3007^rsa_e) mod rsa_n
            BigInteger C = BigInteger.ModPow(3007, rsa_e, rsa_n);

            //Decrypt the message, M should equal 3007
            //M = (3007^rsa_d) mod rsa_n
            BigInteger M = BigInteger.ModPow(C, rsa_d, rsa_n);
            Console.WriteLine(C);
            Console.WriteLine(M);
            Console.ReadKey();
        }
    }
}
