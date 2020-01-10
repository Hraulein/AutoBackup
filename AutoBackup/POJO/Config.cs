using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AutoBackup.POJO
{
    class Config
    {
        [JsonPropertyName("GlobalPath")]
        public string GlobalPath { get; set; }

    }
}

