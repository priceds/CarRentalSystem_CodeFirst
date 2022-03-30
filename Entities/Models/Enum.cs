using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{

    public class Enum
    {
        enum JourneyStatus
        {
            APPROVED,
            PENDING,
            ONGOING,
            COMPLETED,
            CANCELLED
        }

        enum Roles
        {
            Admin,
            Customer,
            Driver

        }

        enum CarType
        {
            SUV,
            MPV,
            HatchBack,
            Sedan,
            Limousine
        }




    }
}
