﻿using Application.Features.Invoices.Commands;
using Application.Features.Invoices.Queries;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InvoicesController : BaseController
    {
        [HttpPost("add")]
        public async Task<IActionResult> Add([FromBody] CreateInvoiceCommand createInvoiceCommand)
        {
            var result = await Mediator.Send(createInvoiceCommand);
            return Created("", result);
        }

        [HttpGet("getbydate")]
        public async Task<IActionResult> GetByDate([FromQuery] GetInvoiceListByDateQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpGet("getbycustomer")]
        public async Task<IActionResult> GetByCustomer([FromQuery] GetInvoiceListByCustomerQuery query)
        {
            var result = await Mediator.Send(query);
            return Ok(result);
        }

        [HttpDelete("delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteInvoiceCommand deleteInvoiceCommand)
        {
            var result = await Mediator.Send(deleteInvoiceCommand);
            return Ok(result);
        }

        [HttpPut("update")]
        public async Task<IActionResult> Update([FromBody] UpdateInvoiceCommand updateInvoiceCommand)
        {
            var result = await Mediator.Send(updateInvoiceCommand);
            return Ok(result);
        }
    }
}
