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
    public sealed class ChannelController : ControllerBase
    {
        private readonly IChannelService channelService;

        public ChannelController(IChannelService channelService)
        {
            this.channelService = channelService;
        }

        [HttpGet]
        [Route("api/v1/channels")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var channels = await channelService.GetAllAsync();

                return Ok(channels);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/v1/channels/{id:int}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            try
            {
                var channel = await channelService.GetByIdAsync(id);

                return Ok(channel);
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
        [Route("api/v1/channels/ids")]
        public async Task<IActionResult> GetByIdsAsync([FromQuery] ICollection<int> ids)
        {
            try
            {
                var channels = await channelService.GetByIdsAsync(ids);

                return Ok(channels);
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
        [Route("api/v1/channels/top/{count:int}")]
        public async Task<IActionResult> GetTopAsync([FromRoute] int count)
        {
            try
            {
                var channels = await channelService.GetTopAsync(count);

                return Ok(channels);
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
        [Route("api/v1/channels")]
        public async Task<IActionResult> CreateAsync([FromBody] Channel channel)
        {
            try
            {
                await channelService.CreateAsync(channel);

                return Created($"api/v1/channels/{ channel?.Id }", channel);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("api/v1/channels/import")]
        public async Task<IActionResult> CreateBulkAsync([FromBody] ICollection<Channel> channels)
        {
            try
            {
                await channelService.CreateBulkAsync(channels);

                return Created("api/v1/channels", channels);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("api/v1/channels/{id:int}")]
        public async Task<IActionResult> UpdateAsync([FromBody] Channel channel, [FromRoute] int id)
        {
            try
            {
                await channelService.UpdateAsync(channel, id);

                return Ok(channel);
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
        [Route("api/v1/channels")]
        public async Task<IActionResult> UpdateBulkAsync([FromBody] ICollection<Channel> channels)
        {
            try
            {
                await channelService.UpdateBulkAsync(channels);

                return Ok(channels);
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
        [Route("api/v1/channels/{id:int}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] int id)
        {
            try
            {
                await channelService.DeleteAsync(id);

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
        [Route("api/v1/channels")]
        public async Task<IActionResult> DeleteBulkAsync([FromQuery] ICollection<int> ids)
        {
            try
            {
                await channelService.DeleteBulkAsync(ids);

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
