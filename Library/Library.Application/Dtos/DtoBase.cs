using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Application.Dtos
{
    public abstract class DtoBase
    {
        [JsonProperty("changeUser")]
        public int ChangeUser { get; set; }

        [JsonProperty("changeDate")]
        public DateTime ChangeDate { get; set; }
    }
}
