using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._10.Moto
{
   public abstract class BaseEntity
    {
        protected internal virtual Guid Id { get; set; }
    }
}
