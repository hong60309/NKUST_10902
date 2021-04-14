using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Models
{
    public partial class Number
    {
        [JsonProperty("school")]
        public string School { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("num")]
        public long Num { get; set; }

    }

}
