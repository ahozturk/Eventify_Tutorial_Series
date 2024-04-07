using Eventify_Tutorial_Series.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify_Tutorial_Series.Application.Abstractions.Services
{
    public interface ITextService
    {
        string FormatTextForEvent(IEnumerable<EventDTO> eventItems);
    }
}
