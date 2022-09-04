using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Inno.RngDNDTool.Core.DtoModels.Internal.Base
{
    abstract public class BaseDTO
    {
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
    }
}
