﻿using AutoMapper;
using Colomb.IRepository;
using Colomb.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic; 
using System.Linq;
using System.Threading.Tasks;

namespace Colomb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EvenementController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<EvenementController> _logger;
        private readonly IMapper _mapper;

        public EvenementController(IUnitOfWork unitOfWork, ILogger<EvenementController> logger, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
            _mapper = mapper;
        }

        // ------------------ GET ------------------ // 
        /*        // Override Global Caching Options
                [HttpGet]
                //[HttpCacheExpiration(CacheLocation = CacheLocation.Public, MaxAge = 60)]
                //[HttpCacheValidation(MustRevalidate = false)] // if data changes dont invalidate cache (to be used carefully)
                [ResponseCache(CacheProfileName = "120SecondsDuration")]
                [ProducesResponseType(StatusCodes.Status200OK)]
                [ProducesResponseType(StatusCodes.Status500InternalServerError)]
                public async Task<IActionResult> GetEvenements([FromQuery] RequestParams requestParams)
                {
                    var evenements = await _unitOfWork.Evenements.GetAll(requestParams);
                    // return a list of CountryDTOs
                    var results = _mapper.Map<IList<EvenementDTO>>(evenements);
                    return Ok(results);
                }*/

        // GET - Evenements
        [HttpGet]
        public async Task<IActionResult> GetEvenements()
        {
            try
            {
                var evenements = await _unitOfWork.Evenements.GetAll();
                var results = _mapper.Map<IList<EvenementDTO>>(evenements);
                return Ok(results);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erreur. {nameof(GetEvenements)}");
                return StatusCode(500, "Internal server error. Please try again later");
            }
        }

        // GET - Simple example
        /* [HttpGet]
        public async Task<IActionResult> GetEvenements()
        {
            try
            {
                var evenements = await _unitOfWork.Evenements.GetAll();
                return Ok(evenements);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erreur. {nameof(GetEvenements)}");
                return StatusCode(500, "Internal server error. Please try again later");
            }
        }*/
    }
}