using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fitness_Application.Models
{
    [Keyless]
    public class ProductImage
    {
        public int ProductId { get; private set; }
        public byte[] Image { get; set; } = new byte[0];
    }
}