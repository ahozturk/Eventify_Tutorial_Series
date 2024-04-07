using Eventify_Tutorial_Series.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventify_Tutorial_Series.Application.Abstractions.Services.Concrete
{
    public class ExportService
    {
        private readonly ITextService _textService;
        private readonly IFileService _fileService;

        public ExportService(ITextService textService, IFileService fileService)
        {
            _textService = textService;
            _fileService = fileService;
        }

        public async Task ExportEventsAsync(IEnumerable<EventDTO> eventItems, string path)
        {
            var formattedText = _textService.FormatTextForEvent(eventItems);
            await _fileService.SaveTextAsync(formattedText, path);
        }
    }
}
