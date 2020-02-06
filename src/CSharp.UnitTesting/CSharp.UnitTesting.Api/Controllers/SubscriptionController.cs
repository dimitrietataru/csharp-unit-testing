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
    public sealed class SubscriptionController : ControllerBase
    {
        private readonly ISubscriptionService subscriptionService;

        public SubscriptionController(ISubscriptionService subscriptionService)
        {
            this.subscriptionService = subscriptionService;
        }

        [HttpGet]
        [Route("api/v1/subscriptions")]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var subscriptions = await subscriptionService.GetAllAsync();

                return Ok(subscriptions);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("api/v1/subscriptions/{id:guid}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] Guid id)
        {
            try
            {
                var subscription = await subscriptionService.GetByIdAsync(id);

                return Ok(subscription);
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
        [Route("api/v1/subscriptions/ids")]
        public async Task<IActionResult> GetByIdsAsync([FromQuery] ICollection<Guid> ids)
        {
            try
            {
                var subscriptions = await subscriptionService.GetByIdsAsync(ids);

                return Ok(subscriptions);
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
        [Route("api/v1/subscriptions/channel/{channelId:int}")]
        public async Task<IActionResult> GetByChannelIdAsync([FromRoute] int channelId)
        {
            try
            {
                var subscriptions = await subscriptionService.GetByChannelIdAsync(channelId);

                return Ok(subscriptions);
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
        [Route("api/v1/subscriptions")]
        public async Task<IActionResult> CreateAsync([FromBody] Subscription subscription)
        {
            try
            {
                await subscriptionService.CreateAsync(subscription);

                return Created($"api/v1/subscriptions/{ subscription?.Id }", subscription);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPost]
        [Route("api/v1/subscriptions/import")]
        public async Task<IActionResult> CreateBulkAsync([FromBody] ICollection<Subscription> subscriptions)
        {
            try
            {
                await subscriptionService.CreateBulkAsync(subscriptions);

                return Created("api/v1/subscriptions", subscriptions);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut]
        [Route("api/v1/subscriptions/{id:guid}")]
        public async Task<IActionResult> UpdateAsync([FromBody] Subscription subscription, [FromRoute] Guid id)
        {
            try
            {
                await subscriptionService.UpdateAsync(subscription, id);

                return Ok(subscription);
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
        [Route("api/v1/subscriptions")]
        public async Task<IActionResult> UpdateBulkAsync([FromBody] ICollection<Subscription> subscriptions)
        {
            try
            {
                await subscriptionService.UpdateBulkAsync(subscriptions);

                return Ok(subscriptions);
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
        [Route("api/v1/subscriptions/{id:guid}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] Guid id)
        {
            try
            {
                await subscriptionService.DeleteAsync(id);

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
        [Route("api/v1/subscriptions")]
        public async Task<IActionResult> DeleteBulkAsync([FromQuery] ICollection<Guid> ids)
        {
            try
            {
                await subscriptionService.DeleteBulkAsync(ids);

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
