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
    public class GenreController : Controller
    {
        IEFGenreService _efGenreService;

        public GenreController(IEFGenreService efGenreService)
        { _efGenreService = efGenreService; }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try { return Ok(await _efGenreService.GetAllGenres()); }
            catch { return StatusCode(404); }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int Id)
        {
            try { return Ok(await _efGenreService.GetGenreById(Id)); }
            catch { return StatusCode(404); }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                await _efGenreService.DeleteGenre(Id);
                return StatusCode(204);
            }
            catch
            { return StatusCode(404); }
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] GenreDTO val)
        {
            try
            {
                await _efGenreService.UpdateGenre(val);
                return StatusCode(204);
            }
            catch
            { return StatusCode(404); }
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] GenreDTO val)
        {
            try
            {
                await _efGenreService.AddGenre(val);
                return StatusCode(201);
            }
            catch
            { return StatusCode(404); }
        }
    }
}