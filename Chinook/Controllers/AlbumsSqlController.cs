﻿using Chinook.WebApi.Models;
using Chinook.WebApi.Repository;
using Chinook.WebApi.Strategy;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Chinook.Controllers
{
    [Route("api/albums/sql")]
    [ApiController]
    public class AlbumsSqlController : ControllerBase
    {
        IUnitOfWork _unitOfWork;
        public AlbumsSqlController(IUnitOfWorkEngine unitOfWorkEngine)
        {
            _unitOfWork = unitOfWorkEngine.GetUnitOfWork(DataBaseSelector.SqlServer);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Album>>> GetCustomersUpdatedName3()
        {
            var album = await _unitOfWork.Album.Read();
            return Ok(album);
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<Customer>> GetCustomerByIdChange(int id)
        {
            var album = await _unitOfWork.Album.ReadById(id);
            return Ok(album);
        }

        [HttpPut]
        public async Task<ActionResult<bool>> UpdateCustomer([FromBody] Album album)
        {
            var albumResult = await _unitOfWork.Album.Update(album);
            return Ok(albumResult);
        }

        [HttpPost]
        public async Task<ActionResult<int>> CreateCustomer([FromBody] Album album)
        {
            var albumResult = await _unitOfWork.Album.Create(album);
            return Ok(album.AlbumId);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<bool>> DeleteCustomer(int id)
        {
            var album = await _unitOfWork.Album.ReadById(id);
            var albumResult = await _unitOfWork.Album.Delete(album);
            return Ok(albumResult);
        }
    }
}
