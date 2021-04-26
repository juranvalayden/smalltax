using System;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SmallTax.Data;
using SmallTax.Data.Entities;

namespace SmallTax.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Produces("application/json")]
    public class TaxController : ControllerBase
    {
        private readonly ITaxRepository _repository;
        private readonly IMapper _mapper;

        public TaxController(ITaxRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<TaxBracket> Get()
        {
            try
            {
                return Ok(_repository.GetAllTaxBrackets());
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to return {ex.Message}");
            }
        }
    }
}
