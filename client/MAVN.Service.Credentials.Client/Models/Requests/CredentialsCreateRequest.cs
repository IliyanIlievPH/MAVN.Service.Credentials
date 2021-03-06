using JetBrains.Annotations;

namespace MAVN.Service.Credentials.Client.Models.Requests
{
    /// <summary>
    /// Represents customer credentials create request.
    /// </summary>
    [PublicAPI]
    public class CredentialsCreateRequest : Credentials
    {
        /// <summary>
        /// The customer identifier.
        /// </summary>
        public string CustomerId { get; set; }
    }
}
