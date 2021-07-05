using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TextProcessing.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TextProcessingController : ControllerBase
    {
        private readonly ILogger<TextProcessingController> _logger;

        public TextProcessingController(ILogger<TextProcessingController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get(int inputNumber)
        {
            // TODO: Need to make NumbersDisplayingAPI class implementation, change signature of DisplayFullSquenceWithPaging(int inputNumber, int pageSize)
            // to have return tuple of sequnce number, value and color and return these values as ProcessedText model as a result of TextProcessingController Get execution

            return null;
        }
    }
}
