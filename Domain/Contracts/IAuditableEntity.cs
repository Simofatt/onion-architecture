using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Contracts
{
 
    public interface IAuditableEntity : IEntity
    {

    }
    public interface IAuditableEntity<TId> : IAuditableEntity , IEntity<TId>    
    {
        string CreatedBy { get; set; }

        DateTime CreatedOn { get; set; }

        string LastModifiedBy { get; set; }

        DateTime? LastModifiedOn { get; set; }
    }
}
