﻿using Microsoft.AspNetCore.Mvc;
using WebApi8_Scheduling.Models;
using WebApi8_Scheduling.Services.Client;
using WebApi8_Scheduling.Services.Scheduling;

namespace WebApi8_Scheduling.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceController : Controller
    {
        private readonly IServiceInterface _serviceInterface;

        public ServiceController(IServiceInterface serviceInterface)
        {
            _serviceInterface = serviceInterface;
        }

        [HttpGet("GetAllServices")]
        public async Task<ActionResult<ResponseModel<List<ServiceModel>>>> GetAllServices()
        {
            var services = await _serviceInterface.GetAllServices();
            return Ok(services);
        }
    }
}
