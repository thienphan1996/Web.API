using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAPI.Data
{
    public abstract class EntityBase
    {
        public int Id { get; protected set; }
    }
}