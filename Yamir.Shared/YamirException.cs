namespace Yamir.Shared
{
    public class YamirException : Exception
    {
        public static readonly YamirException TreeNotFound = new YamirException("Tree not found", nameof(TreeNotFound));
        
        public static readonly YamirException TreeAlreadyExists = new YamirException("Tree already exists", nameof(TreeAlreadyExists));


        protected YamirException(string message) : base(message)
        {
        }

        protected YamirException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected YamirException(string message, string code) : base(message)
        {
            Code = code;
        }

        protected YamirException(string message, string code, Exception innerException) : base(message, innerException)
        {
            Code = code;
        }

        public string Code { get; set; }
    }
}
