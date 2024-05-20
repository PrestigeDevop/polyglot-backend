
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System.IO;
using static System.Runtime.InteropServices.JavaScript.JSType;
// just a test 

namespace TodoApi
{
    public class QR
    { 
        FileStream? _file;
        public async void myreturnn(byte[] qrstring)
        {
            FileOptions options = FileOptions.Asynchronous;
            byte[] qrstring1 = qrstring;

            File.Create( "image/png", qrstring1.Length, options);
            
        } 

    }
}
