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
    public sealed class VideoController : ControllerBase
    {
        private readonly IVideoService videoService;

        public VideoController(IVideoService videoService)
        {
            this.videoService = videoService;
        }

        [HttpGet]
        [Route("api/v1/videos")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var videos = await videoService.GetAllAsync();

                return Ok(videos);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/v1/videos/{id:guid}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
        {
            try
            {
                var video = await videoService.GetByIdAsync(id);

                return Ok(video);
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
        [Route("api/v1/videos/ids")]
        public async Task<IActionResult> GetByIdsAsync([FromQuery] ICollection<Guid> ids)
        {
            try
            {
                var videos = await videoService.GetByIdsAsync(ids);

                return Ok(videos);
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
        [Route("api/v1/videos/channel/{channelId:int}")]
        public async Task<IActionResult> GetByChannelIdAsync([FromRoute] int channelId)
        {
            try
            {
                var videos = await videoService.GetByChannelIdAsync(channelId);

                return Ok(videos);
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
        [Route("api/v1/videos")]
        public async Task<IActionResult> CreateAsync([FromBody] Video video)
        {
            try
            {
                await videoService.CreateAsync(video);

                return Created($"api/v1/videos/{ video?.Id }", video);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("api/v1/videos/import")]
        public async Task<IActionResult> CreateBulkAsync([FromBody] ICollection<Video> videos)
        {
            try
            {
                await videoService.CreateBulkAsync(videos);

                return Created("api/v1/videos", videos);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("api/v1/videos/{id:guid}")]
        public async Task<IActionResult> UpdateAsync([FromBody] Video video, [FromRoute] Guid id)
        {
            try
            {
                await videoService.UpdateAsync(video, id);

                return Ok(video);
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
        [Route("api/v1/videos")]
        public async Task<IActionResult> UpdateBulkAsync([FromBody] ICollection<Video> videos)
        {
            try
            {
                await videoService.UpdateBulkAsync(videos);

                return Ok(videos);
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
        [Route("api/v1/videos/{id:guid}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
        {
            try
            {
                await videoService.DeleteAsync(id);

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
        [Route("api/v1/videos")]
        public async Task<IActionResult> DeleteBulkAsync([FromQuery] ICollection<Guid> ids)
        {
            try
            {
                await videoService.DeleteBulkAsync(ids);

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
