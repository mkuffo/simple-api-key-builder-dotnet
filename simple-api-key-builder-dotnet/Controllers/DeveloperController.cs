using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using simple_api_key_builder_dotnet.Models;

namespace simple_api_key_builder_dotnet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DeveloperController : ControllerBase
    {
        private static Dictionary<string, string> companies = new Dictionary<string, string>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok($"Simple Api Key Builder Generator Server is running. Started time: {DateTime.Now}");
        }

        [HttpPost("/api/developer/request-api-key")]
        public IActionResult GetRequestApiKey(string companyName)
        {
            if (companyName == null)
                return StatusCode(StatusCodes.Status400BadRequest, "companyName field is required.");

            if (companies.ContainsKey(companyName))
                return StatusCode(StatusCodes.Status500InternalServerError, $"{companyName} already has a public API Key.");

            var UUIDV4 = Guid.NewGuid().ToString();

            var company = new DeveloperModel
            {
                CompanyName = companyName,
                ApiKey = UUIDV4
            };

            companies.Add(companyName, company.ApiKey);

            return Ok(company);

        }
    }
}
