using Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Infrastructure.Services
{
    public  class DateTimeService : IDateTimeService 
    {
      
        public DateTime NowUtc() => DateTime.UtcNow; 
    }
}
