using ticketsMvcg.Data.Base;
using ticketsMvcg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ticketsMvcg.Data.Services
{
    public interface IProducersService:IEntityBaseRepository<Producer>
    {
    }
}
