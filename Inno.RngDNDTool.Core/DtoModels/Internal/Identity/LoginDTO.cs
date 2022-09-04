using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.Identity
{
    public class LoginDTO
    {
        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    }
}