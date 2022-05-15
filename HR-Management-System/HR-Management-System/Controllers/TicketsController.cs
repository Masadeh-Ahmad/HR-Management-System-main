﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HR_Management_System.Data;
using HR_Management_System.Models;
using HR_Management_System.Models.Interfaces;
using HR_Management_System.Models.DTOs;

namespace HR_Management_System.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketsController : ControllerBase
    {
        private readonly ITicket _ticket;

        public TicketsController(ITicket ticket)
        {
            _ticket = ticket;
        }

        // GET: api/Tickets
        [HttpGet]
        public async Task<ActionResult<List<TicketDTO>>> GetTickets()
        {
            var tickets = await _ticket.GetTickets();
            if (tickets == null) return NoContent();
            return Ok(tickets);
        }

        // GET: api/Tickets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TicketDTO>> GetTicket(int id)
        {
            var ticket = await _ticket.GetTicket(id);

            if (ticket == null)
            {
                return NotFound();
            }

            return ticket;
        }

        // PUT: api/Tickets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("Accept/{id}")]
        public async Task<TicketDTO> Accept(int id)
        {
            return await _ticket.Accept(id);
        }
        [HttpPut("Deny/{id}")]
        public async Task<TicketDTO> Deny(int id)
        {
            return await _ticket.Deny(id);
        }

        [HttpPost]
        public async Task<ActionResult<TicketDTO>> PostTicket(AddTicketDTO ticket)
        {
            TicketDTO newTicket = await _ticket.CreateTicket(ticket);
            return Ok(newTicket);
        }

        // DELETE: api/Tickets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTicket(int id)
        {
            try
            {
                await _ticket.DeleteTicket(id);
                return NoContent();
            }

            catch (Exception) { return NotFound(); }
        }
        // GET: api/Tickets/Employee/8
        [HttpGet("Employee/{id}")]
        public async Task<ActionResult<List<TicketDTO>>> GetEmployeeTickets(int id)
        {
            try
            {
                List <TicketDTO> employeetickets = await _ticket.GetEmployeeTickets(id);
                return Ok(employeetickets);
            }
            catch(Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}
