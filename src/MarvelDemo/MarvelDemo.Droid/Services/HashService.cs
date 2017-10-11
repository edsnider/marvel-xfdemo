using Java.Security;
using MarvelDemo.Droid.Services;
using MarvelDemo.Services;
using Xamarin.Forms;
using StringBuilder = System.Text.StringBuilder;

[assembly:Dependency(typeof(HashService))]
namespace MarvelDemo.Droid.Services
{
    public class HashService : IHashService
    {
        public string CreateMd5Hash(string input)
        {
            var md5 = MessageDigest.GetInstance("MD5");
            var inputBytes = new Java.Lang.String(input).GetBytes();
            md5.Update(inputBytes);
            var hashed = md5.Digest();

            var hex = new StringBuilder(hashed.Length * 2);
            foreach (var b in hashed)
                hex.Append($"{b:x2}");

            var result = hex.ToString();

            return result;
        }
    }
}