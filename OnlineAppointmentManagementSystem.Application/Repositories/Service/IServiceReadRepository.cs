﻿using OnlineAppointmentManagementSystem.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineAppointmentManagementSystem.Application.Repositories
{
    public interface IServiceReadRepository: IReadRepository<Service>
    {
    }
}
