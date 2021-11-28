using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Entities;
using Microsoft.AspNetCore.Mvc;
using Server.Persistence;

namespace Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AdultController : ControllerBase
    {
        private IFileService _fileService;

        public AdultController(IFileService fileService)
        {
            _fileService = fileService;
        }
        
        [HttpGet]
        public ActionResult<IList<Adult>> GetAdultList()
        {
            try
            {
                Console.WriteLine("ER vi her?");
                IList<Adult> adultList = _fileService.ReadData<Adult>("");
                Console.WriteLine(adultList.Count);
                return Ok(adultList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        [HttpPost]
        public async Task<ActionResult<IList<Adult>>> AddAdultList([FromBody] IList<Adult> adultList)
        {
            try
            {
                _fileService.SaveChanges(adultList);
                return Created(@"/adult", adultList);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}