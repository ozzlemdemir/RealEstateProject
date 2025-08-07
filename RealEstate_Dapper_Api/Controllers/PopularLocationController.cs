﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealEstate_Dapper_Api.Repositories.PopularLocationRepositories;

namespace RealEstate_Dapper_Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PopularLocationController : ControllerBase
    {
        private readonly IPopularLocationRepository _locationRepository;

        public PopularLocationController(IPopularLocationRepository popularLocationRepository)
        {
            _locationRepository = popularLocationRepository;
        }
        [HttpGet]
        public async Task<IActionResult> PopularLocationList()
        {
            var value= await _locationRepository.GetAllPopularLocationAsync();
            return Ok(value);
        }
    }
}
