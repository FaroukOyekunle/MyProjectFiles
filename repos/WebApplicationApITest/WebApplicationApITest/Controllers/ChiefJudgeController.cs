using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationApITest.Dtos;
using WebApplicationApITest.Interface.IService;

namespace WebApplicationApITest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ChiefJudgeController : ControllerBase
    {
        private readonly IChiefJudgeService _chiefJudgeService;
        public ChiefJudgeController(IChiefJudgeService chiefJudgeService)
        {
            _chiefJudgeService = chiefJudgeService;
        }

        [HttpPost]
        public IActionResult Create([FromBody] CreateChiefJudgeRequestModel model)
        {
            _chiefJudgeService.AddChiefJudge(model);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Details([FromRoute]int id)
        {
            var chiefJudge = _chiefJudgeService.GetChiefJudge(id);
            return Ok(chiefJudge);
        }
        [HttpPut("{id}")]
        public IActionResult Update([FromRoute]int id, [FromBody]UpdateChiefJudgeRequestModel model)
        {
            _chiefJudgeService.UpdateChiefJudge(id, model);
            return Ok();
        }
       /* public IActionResult Get([FromRoute] int id)
        {
           
        }*/
        [HttpDelete("{id}")]
        public IActionResult Delete([FromRoute]int id)
        {
            var chiefJudge = _chiefJudgeService.GetChiefJudge(id);
            if (chiefJudge == null)
            {
                return NotFound();
            }
            return Ok(chiefJudge);
        }
    }
}
