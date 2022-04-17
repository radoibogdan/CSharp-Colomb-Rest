using AutoMapper;
using Colomb.Data;
using Colomb.IRepository;
using Colomb.Models;
using Microsoft.AspNetCore.Authorization;
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

        /* ------------------ GET ALL ------------------ */
        // https://localhost:44311/api/Evenement
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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

        /* ------------------ GET by Id ------------------ */
        // https://localhost:44311/api/Evenement/1 
        [HttpGet("{id:int}", Name = "GetEvenement")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetEvenement(int id)
        {
            try
            {
                var evenement = await _unitOfWork.Evenements.Get(q => q.EvenementId == id, new List<string> { "Reviews" });
                var result = _mapper.Map<EvenementDTO>(evenement);
                return Ok(result);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Erreur. {nameof(GetEvenements)}");
                return StatusCode(500, "Internal server error. Please try again later");
            }
        }

        /* ------------------ POST CREATE ------------------ */
        /*[Authorize(Roles = "Administrator")]*/ /* Protect EndPoint with JWT Token Authentication*/
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateEvenement([FromBody] CreateEvenementDTO evenementDTO)
        {
            if (!ModelState.IsValid)
            {
                _logger.LogError($"Invalid POST attempt in {nameof(CreateEvenement)}");
                return BadRequest(ModelState);
            }
            try
            {
                // Mapping the content of evenementDTO into an object of type "Evenement" which is a data object
                var evenement = _mapper.Map<Evenement>(evenementDTO);
                await _unitOfWork.Evenements.Insert(evenement);
                await _unitOfWork.Save();
                // Created = returns Code 201
                // CreatedAtRoute = return Code 201 + the created object by executing GetEvenement
                return CreatedAtRoute("GetEvenement", new { id = evenement.EvenementId }, evenement);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(CreateEvenement)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }

        /* PUT - EDIT */
        /*[Authorize(Roles = "Administrator")]*/
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateEvenement(int id, [FromBody] UpdateEvenementDTO evenementDTO)
        {
            if (!ModelState.IsValid || id < 1)
            {
                _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateEvenement)}");
                return BadRequest(ModelState);
            }

            try
            {
                // get original record
                var evenement = await _unitOfWork.Evenements.Get(q => q.EvenementId == id);
                if (evenement == null)
                {
                    _logger.LogError($"Invalid UPDATE attempt in {nameof(UpdateEvenement)}");
                    return BadRequest("Submitted data in invalid.");
                }

                // Map () => update/insert in "hotel" what is in "hotelDTO"
                _mapper.Map(evenementDTO, evenement);
                _unitOfWork.Evenements.Update(evenement);
                await _unitOfWork.Save();
                return NoContent(); // Code 204, no data is returned
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(UpdateEvenement)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }

        /*[Authorize(Roles = "Administrator")]*/
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteEvenement(int id)
        {
            if (id < 1)
            {
                _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteEvenement)}");
                return BadRequest();
            }

            try
            {
                var evenement = await _unitOfWork.Evenements.Get(q => q.EvenementId == id);
                if (evenement == null)
                {
                    _logger.LogError($"Invalid DELETE attempt in {nameof(DeleteEvenement)}");
                    return BadRequest("Submitted data in invalid.");

                }
                await _unitOfWork.Evenements.Delete(id);
                await _unitOfWork.Save();

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Something went wrong in the {nameof(DeleteEvenement)}");
                return StatusCode(500, "Internal server error. Please try again later.");
            }
        }

        // ------------------ GET Simple Example ------------------ // 
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

        // ------------------ GET Complex Example------------------ // 
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

    }
}
