using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EquipmentsController : ControllerBase
    {
        IEquipmentService _equipmentService;

        public EquipmentsController(IEquipmentService equipmentService) {

            _equipmentService = equipmentService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _equipmentService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getequipmentdetails")]
        public IActionResult GetEquipmentDetails()
        {
            var result = _equipmentService.GetEquipmentDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _equipmentService.GetById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getequipmentdetailsbyclinic")]
        public IActionResult GetEquipmentDetailsByClinic(int id)
        {
            var result = _equipmentService.GetEquipmentDetailsById(id);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Equipment equipment)
        {
            var result = _equipmentService.Add(equipment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Equipment equipment)
        {
            var result = _equipmentService.Update(equipment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Equipment equipment)
        {
            var result = _equipmentService.Delete(equipment);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

    }
}
