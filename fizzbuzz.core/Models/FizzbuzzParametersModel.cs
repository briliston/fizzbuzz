using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzbuzz.core.Models
{
    public class FizzbuzzParametersModel
    {
        public int Total { get; set; }
        public WordNumberPairModel[]? Entries { get; set; }
        public string? ConnectionId { get; set; }
    }
}
