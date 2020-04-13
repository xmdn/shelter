﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.DTO;
using BLL.Interfaces.IEFServices;
using DAL.DbContexts;
using DAL.Entities;
using Microsoft.AspNetCore.Mvc;

namespace VideoGameShop2.Controllers
{
    [Route("api/[controller]")]
    public class PublisherController : Controller
    {
        IEFPublisherService _efPublisherService;

        public PublisherController(IEFPublisherService efPublisherService)
        { _efPublisherService = efPublisherService; }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try { return Ok(await _efPublisherService.GetAllPublishers()); }
            catch { return StatusCode(404); }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int Id)
        {
            try { return Ok(await _efPublisherService.GetPublisherById(Id)); }
            catch { return StatusCode(404); }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                await _efPublisherService.DeletePublisher(Id);
                return StatusCode(204);
            }
            catch
            { return StatusCode(404); }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] PublisherDTO val)
        {
            try
            {
                await _efPublisherService.UpdatePublisher(val);
                return StatusCode(204);
            }
            catch
            { return StatusCode(404); }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] PublisherDTO val)
        {
            try
            {
                await _efPublisherService.AddPublisher(val);
                return StatusCode(201);
            }
            catch
            { return StatusCode(404); }
        }
    }
}