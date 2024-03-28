using Eventify_Tutorial_Series.Application.DTOs;
using Eventify_Tutorial_Series.Application.RequestParameters;
using Eventify_Tutorial_Series.Domain.Entities;
using Eventify_Tutorial_Series.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify_Tutorial_Series.Application.Abstractions.Services
{
    public interface IEventService
    {
        Task CreateEventAsync(CreateEventDTO createEventDTO);
        Task<IEnumerable<EventDTO>> GetAllEventsAsync(Pagination pagination);
    }
}
