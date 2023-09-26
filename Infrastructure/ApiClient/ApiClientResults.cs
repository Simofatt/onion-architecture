using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;

using Synaplic.UniRH.Shared.Wrapper;


namespace Synaplic.UniRH.Client.Infrastructure.ApiClients
{
    public class BooleanIResult : Result<bool> { }
    public class StringResult : Result<string> { }
    public class StringIResult : Result<string> { }
    public class DecimalResult : Result<decimal> { }
    public class StreamResult : Result<Stream> { }
    public class BooleanResult : Result<bool> { }
    public class IntResult : Result<int> { }
    public class Int32Result : Result<int> { }
    public class StringListResult : Result<List<string>> { }

    


    public class File
    {
        public byte[] ByteArray { get; }
        public string ContentType { get; }
        public string FileName { get; }

        public File(byte[] byteArray, string contentType, string fileName)
        {
            ByteArray = byteArray;
            ContentType = contentType;
            FileName = fileName;
        }
    }
}