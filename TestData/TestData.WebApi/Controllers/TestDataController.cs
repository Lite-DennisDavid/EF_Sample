using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestData.Entities;
using TestData.WebApi.Models;

namespace TestData.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class TestDataController : Controller
    {
        private readonly ITestDataRepository _repo;
        private IMapper _mapper;

        public TestDataController(ITestDataRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }


        [HttpGet("")]
        public async Task<ActionResult<TestDataL1[]>> Get()
        {
            try
            {
                var testDatas = await _repo.GetAllTestDataAsync();
                return Ok(_mapper.Map<IEnumerable<TestDataL1Model>>(testDatas));
            }
            catch(Exception ex)
            {
                return BadRequest("Not Found, " + ex.Message);
            }
        }

        [HttpGet("{id}", Name = "GetTestById")]
        public async Task<ActionResult<TestDataL1>> GetTestDataById(int id)
        {
            try
            {
                var testData = await _repo.GetTestDataById(id);

                return Ok(_mapper.Map<TestDataL1>(testData));
            }
            catch(Exception ex)
            {
                return BadRequest("Not Found, " + ex.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody]TestDataL1Model model)
        {
            try
            {
                var testData = _mapper.Map<TestDataL1>(model);
                _repo.Add(testData);

                if (await _repo.SaveChangesAsync())
                {
                    var newUri = Url.Link("GetTestById", new { id = model.TestDataId });
                    return Created(newUri, _mapper.Map<TestDataL1>(testData));
                }
                
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest("Not Found, " + ex.Message);
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TestDataL1Model sInfo)
        {
            try
            {
                var oldTestDataInfo = await _repo.GetTestDataById(id);
                if (oldTestDataInfo == null)
                    return NotFound($"Could not find a Test Data Info with an ID of {id}");

                //Map Model to the old station info
                oldTestDataInfo.SerialNumber = sInfo.SerialNumber ?? oldTestDataInfo.SerialNumber;
                oldTestDataInfo.CustomerSerialNumber = sInfo.CustomerSerialNumber ?? oldTestDataInfo.CustomerSerialNumber;
                oldTestDataInfo.PartNumber = sInfo.PartNumber ?? oldTestDataInfo.PartNumber;

                if (await _repo.SaveChangesAsync())
                    return Ok(oldTestDataInfo);

                return BadRequest("Couldn't update StationInfo");
            }
            catch (Exception ex)
            {
                return BadRequest("Couldn't update StationInfo");
            }

            
        }
    }
}
