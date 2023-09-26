using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{

    public interface IEntity
    {

    }
    public interface IEntity<TId> : IEntity
    {
        public TId Id { get; set; }
    }

  
}
