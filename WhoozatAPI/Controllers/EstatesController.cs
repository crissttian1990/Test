using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WhoozatAPI.Dtos;
using WhoozatAPI.Entities;
using WhoozatAPI.Repositories;

namespace WhoozatAPI.Controllers
{
    [Route("api/[controller]")]
    public class EstatesController : Controller
    {
        private IEstateRepository _estateRepository;

        public EstatesController(IEstateRepository estateRepository)
        {
            _estateRepository = estateRepository;
        }

        //// GET api/estates
        [HttpGet]
        public IActionResult GetAllEstates()
        {
            var allEstates = _estateRepository.GetAll().ToList();
            var allEstatesDto = allEstates.Select(x => Mapper.Map<EstateDto>(x));

            return Ok(allEstatesDto);
        }

        //// GET api/estates/id
        [HttpGet]
        [Route("{id}", Name = "GetSingleEstate")]
        public IActionResult GetSingleEstate(int id)
        {
            var estate = _estateRepository.GetSingle(id);

            if (estate == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<EstateDto>(estate));
        }

        //// POST api/estates
        [HttpPost]
        public IActionResult AddEstate([FromBody]EstateDto estate)
        {
            Estate toAdd = Mapper.Map<Estate>(estate);

            _estateRepository.Add(toAdd);

            bool result = _estateRepository.Save();
                
            if (!result)
            {
                return new StatusCodeResult(500);
            }

            //return Ok(Mapper.Map<EstateDto>(toAdd));
            return CreatedAtRoute("GetSingleEstate", new { id = toAdd.Id }, Mapper.Map<EstateDto>(toAdd));
        }

        //// PUT api/estates/id
        [HttpPut("{id}")]
        public IActionResult EditEstate(int id, [FromBody]EstateDto estate)
        {
            Estate toAdd = Mapper.Map<Estate>(estate);

            _estateRepository.Update(toAdd);

            bool result = _estateRepository.Save();

            if (!result)
            {
                return new StatusCodeResult(500);
            }

            //return Ok(Mapper.Map<EstateDto>(toAdd));
            return CreatedAtRoute("GetSingleEstate", new { id = toAdd.Id }, Mapper.Map<EstateDto>(toAdd));
        }

        //// DELETE api/estates/id
        [HttpDelete("{id}")]
        public IActionResult EditEstate(int id)
        {
            var estate = _estateRepository.GetSingle(id);

            if (estate == null)
            {
                return NotFound();
            }

            _estateRepository.Delete(id);

            bool result = _estateRepository.Save();

            if (!result)
            {
                return new StatusCodeResult(500);
            }

            return new StatusCodeResult(200);
        }


        
    }
}