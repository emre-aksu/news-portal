using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseLib.Model
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public string? Name { get; set; }    
        public string? Description { get; set; }
        public byte[]? Picture { get; set; }
        public string? PhotoPath { get; set; }
    }
}
