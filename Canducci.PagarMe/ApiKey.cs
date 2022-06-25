using Refit;

namespace Canducci.PagarMe
{
    public class ApiKey
    {
        public ApiKey(string value)
        {
            Value = value;
        }
        
        public static ApiKey Create(string value)
        {
            return new ApiKey(value);
        }

        [AliasAs("api_key")]
        public string Value { get; private set; }
    }
}
