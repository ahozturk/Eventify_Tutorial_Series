using Eventify_Tutorial_Series.Application.Abstractions.Services;
using Eventify_Tutorial_Series.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify_Tutorial_Series.Infrastructure.Services
{
    public class TextService : ITextService
    {
        public string FormatTextForEvent(IEnumerable<EventDTO> eventItems)
        {
            if (eventItems is null)
                throw new ArgumentNullException(nameof(eventItems));

            StringBuilder stringBuilder = new();

            foreach (var eventItem in eventItems)
            {
                if (eventItem is not null)
                    stringBuilder.AppendLine($"Event: {eventItem.Title} - Location: {eventItem.Location.City} - Date: {eventItem.Date.ToString("HH:mm - dd/MM/yyyy")}");
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
