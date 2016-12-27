using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            var originalStringA = "Angas";

            //Console.WriteLine(EncryptToSHA1(originalStringA));
            //Console.WriteLine(EncryptToMD5(originalStringA));

            //Person person = new Student();
            //Console.WriteLine(person.GetType());

            //Student student = new Student();
            //Console.WriteLine(student.GetType());

            //var person2 = (Person)student;
            //Console.WriteLine(person2.GetType());

            string a = null;
            string b = null;
            string c = "abc";
            string d = "efg";

            Console.WriteLine(a ?? null ?? null ?? "abc");
        }

        private static string EncryptToSHA1(string original)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            var bytes = Encoding.UTF8.GetBytes(original);
            var hash = sha1.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }

        private static string EncryptToMD5(string original)
        {
            var md5 = new MD5CryptoServiceProvider();
            var bytes = Encoding.UTF8.GetBytes(original);
            var hash = md5.ComputeHash(bytes);

            return Convert.ToBase64String(hash);
        }

        private static string DecryptSHA1(string encryptedString)
        {
            var sha1 = new SHA1CryptoServiceProvider();
            return string.Empty;
        }
    }

    public abstract class Person
    { }

    public class Student : Person
    { }
}
