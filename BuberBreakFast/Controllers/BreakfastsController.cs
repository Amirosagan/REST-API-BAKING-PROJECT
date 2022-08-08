using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BuberBreakFast.Contracts.BreakFast;
using BuberBreakFast.Models;
using BuberBreakFast.Services.Breakfasts;
using BuberBreakFast.Services;

namespace BuberBreakFast.Controllers
{
    [ApiController]

    public class BreakfastsController : ControllerBase
    {

        private readonly IBreakfastServices _breakfastServices;

        public BreakfastsController(IBreakfastServices breakfastServices)
        {
            _breakfastServices = breakfastServices;
        }

        [HttpPost("/breakfasts")]
        public IActionResult CreatBreakfast(CreateBreakfastRequest request) {
            var breakfast = new Breakfast(
                Guid.NewGuid(),  
                request.StartDateTime,
                DateTime.UtcNow,
                request.Description,
                request.EndDateTime,
                request.Name,
                request.savory,
                request.Sweet
            );

            // *: save breakfast to database

            _breakfastServices.CreateBreakfast(breakfast);
            
            var response = new CreateBreakfastResponse (
                breakfast.Id,
                breakfast.Name,
                breakfast.Description,
                breakfast.StartDateTime,
                breakfast.EndDateTime,
                breakfast.LastModifiedDateTime,
                breakfast.Savory,
                breakfast.Sweet
            );

            return CreatedAtAction(actionName: nameof(GetBreakfast), routeValues: new {id = breakfast.Id}, value: response);
        }

        [HttpGet("/breakfasts/{id:guid}")]
        public IActionResult GetBreakfast(Guid id) {

            Breakfast breakfast = _breakfastServices.GetBreakfast(id);

            var response = new CreateBreakfastResponse (
                breakfast.Id,
                breakfast.Name,
                breakfast.Description,
                breakfast.StartDateTime,
                breakfast.EndDateTime,
                breakfast.LastModifiedDateTime,
                breakfast.Savory,
                breakfast.Sweet
            );

            return Ok(response);
        }
        
        [HttpPut("/breakfasts/{id:guid}")]
        public IActionResult UpsertBreakfast(Guid id, UpsertBreakfastRequest request) {
            var breakfast = new Breakfast(
                id,  
                request.StartDateTime,
                DateTime.UtcNow,
                request.Description,
                request.EndDateTime,
                request.Name,
                request.savory,
                request.Sweet
            );

            // TODO: return 201 if a new breakfast was created

            _breakfastServices.UpsertBreakfast(breakfast);

            return NoContent();
        }

        [HttpDelete("/breakfasts/{id:guid}")]
        public IActionResult DeleteBreakfast(Guid id) {
            _breakfastServices.DeleteBreakfast(id);

            return NoContent();
        }

    }
}