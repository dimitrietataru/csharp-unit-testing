using CSharp.UnitTesting.Api.Data.Entities;
using CSharp.UnitTesting.Api.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CSharp.UnitTesting.Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    public sealed class PlaylistController : ControllerBase
    {
        private readonly IPlaylistService playlistService;

        public PlaylistController(IPlaylistService playlistService)
        {
            this.playlistService = playlistService;
        }

        [HttpGet]
        [Route("api/v1/playlists")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var playlists = await playlistService.GetAllAsync();

                return Ok(playlists);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/v1/playlists/{id:guid}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
        {
            try
            {
                var playlist = await playlistService.GetByIdAsync(id);

                return Ok(playlist);
            }
            catch (ApplicationException)
            {
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/v1/playlists/ids")]
        public async Task<IActionResult> GetByIdsAsync([FromQuery] ICollection<Guid> ids)
        {
            try
            {
                var playlists = await playlistService.GetByIdsAsync(ids);

                return Ok(playlists);
            }
            catch (ApplicationException)
            {
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("api/v1/playlists")]
        public async Task<IActionResult> CreateAsync([FromBody] Playlist playlist)
        {
            try
            {
                await playlistService.CreateAsync(playlist);

                return Created($"api/v1/playlists/{ playlist.Id }", playlist);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("api/v1/playlists/import")]
        public async Task<IActionResult> CreateBulkAsync([FromBody] ICollection<Playlist> playlists)
        {
            try
            {
                await playlistService.CreateBulkAsync(playlists);

                return Created("api/v1/playlists", playlists);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("api/v1/playlists/{id:guid}")]
        public async Task<IActionResult> UpdateAsync([FromBody] Playlist playlist, [FromRoute] Guid id)
        {
            try
            {
                await playlistService.UpdateAsync(playlist, id);

                return Ok(playlist);
            }
            catch (ApplicationException)
            {
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("api/v1/playlists")]
        public async Task<IActionResult> UpdateBulkAsync([FromBody] ICollection<Playlist> playlists)
        {
            try
            {
                await playlistService.UpdateBulkAsync(playlists);

                return Ok(playlists);
            }
            catch (ApplicationException)
            {
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("api/v1/playlists/{id:guid}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
        {
            try
            {
                await playlistService.DeleteAsync(id);

                return NoContent();
            }
            catch (ApplicationException)
            {
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpDelete]
        [Route("api/v1/playlists")]
        public async Task<IActionResult> DeleteBulkAsync([FromQuery] ICollection<Guid> ids)
        {
            try
            {
                await playlistService.DeleteBulkAsync(ids);

                return NoContent();
            }
            catch (ApplicationException)
            {
                return NotFound();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
