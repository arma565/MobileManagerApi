using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using MobileManager.Model;
using MobileManager.Service;

namespace MobileManager.Controllers
{
    [ApiController]
    [Route("controller")]
    public class MobileManagerController(MobileManagerService service) : ControllerBase
    {
        private readonly MobileManagerService _service = service;

        #region Mobile
        [HttpGet("mobile/{id}")]
        public async Task<ActionResult<Mobile>> GetMobile(Guid id)
        {
            var mobile = await _service.GetMobile(id);
            if (mobile == null)
            {
                return NotFound("Mobile not found!");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return mobile;
        }

        [HttpGet("mobile")]
        public async Task<ActionResult<IEnumerable<Mobile>>> GetMobiles()
        {
            return Ok(await _service.GetMobiles());
        }

        [HttpPost("mobile/add")]
        public async Task<IActionResult> AddMobile([FromBody] Mobile mobile)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var addedMobile = await _service.AddMobile(mobile);
            return CreatedAtAction(nameof(GetMobile), new { id = addedMobile.Id }, addedMobile);
        }

        [HttpPut("mobile/update")]
        public async Task<IActionResult> UpdateMobile([FromBody] Mobile mobile)
        {
            if (string.IsNullOrEmpty(mobile.Id.ToString()))
            {
                return BadRequest("Updating mobile is not possible without id!");
            }
            Mobile? updateMobile = await _service.GetMobile(mobile!.Id);
            if (updateMobile is null)
            {
                return NotFound("Mobile not found!");
            }
            await _service.UpdateMobile(mobile);
            return NoContent();
        }

        [HttpDelete("mobile/delete/{id}")]
        public async Task<IActionResult> DeleteMobile(Guid id)
        {
            Mobile? mobile = await _service.GetMobile(id);
            if (mobile is null)
            {
                return NotFound("Mobile not found!");
            }
            else
            {
                await _service.DeleteMobile(mobile);
                return NoContent();
            }
        }

        [HttpDelete("mobile/delete/all")]
        public async Task<IActionResult> DeleteAllMobiles()
        {
            await _service.DeleteAllMobiles();
            return NoContent();
        }
        #endregion

        #region Accessory
        [HttpGet("accessory/{id}")]
        public async Task<ActionResult<Accessory>> GetAccessory(Guid id)
        {
            var accessory = await _service.GetAccessory(id);
            if (accessory == null)
            {
                return NotFound("Accessory not found!");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return accessory;
        }

        [HttpGet("accessory")]
        public async Task<ActionResult<IEnumerable<Accessory>>> GetAccessories()
        {
            return Ok(await _service.GetAccessories());
        }

        [HttpPost("accessory/add")]
        public async Task<IActionResult> AddAccessory([FromBody] Accessory accessory)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var addedAccessory = await _service.AddAccessory(accessory);
            return CreatedAtAction(nameof(GetAccessory), new { id = addedAccessory.Id }, addedAccessory);
        }

        [HttpPut("accessory/update")]
        public async Task<IActionResult> UpdateAccessory([FromBody] Accessory accessory)
        {
            if (string.IsNullOrEmpty(accessory.Id.ToString()))
            {
                return BadRequest("Updating accessory is not possible without id!");
            }
            Accessory? updateAccessory = await _service.GetAccessory(accessory!.Id);
            if (updateAccessory is null)
            {
                return NotFound("Accessory not found!");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _service.UpdateAccessory(accessory);
            return NoContent();
        }

        [HttpDelete("accessory/delete/{id}")]
        public async Task<IActionResult> DeleteAccessory(Guid id)
        {
            Accessory? accessory = await _service.GetAccessory(id);
            if (accessory is null)
            {
                return NotFound("Accessory not found!");
            }
            else
            {
                await _service.DeleteAccessory(accessory);
                return NoContent();
            }
        }

        [HttpDelete("accessory/delete/all")]
        public async Task<IActionResult> DeleteAllAccessories()
        {
            await _service.DeleteAllAccessories();
            return NoContent();
        }
        #endregion

        #region Debtor
        [HttpGet("debtor/{id}")]
        public async Task<ActionResult<Debtor>> GetDebtor(Guid id)
        {
            var debtor = await _service.GetDebtor(id);
            if (debtor == null)
            {
                return NotFound("Debtor not found!");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return debtor;
        }

        [HttpGet("debtor")]
        public async Task<ActionResult<IEnumerable<Debtor>>> GetDebtors()
        {
            return Ok(await _service.GetDebtors());
        }

        [HttpPost("debtor/add")]
        public async Task<IActionResult> AddDebtor([FromBody] Debtor debtor)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var addedDebtor = await _service.AddDebtor(debtor);
            return CreatedAtAction(nameof(GetDebtor), new { id = addedDebtor.Id }, addedDebtor);
        }

        [HttpPut("debtor/update")]
        public async Task<IActionResult> UpdateDebtor([FromBody] Debtor debtor)
        {
            if (string.IsNullOrEmpty(debtor.Id.ToString()))
            {
                return BadRequest("Updating debtor is not possible without id!");
            }
            Debtor? updateDebtor = await _service.GetDebtor(debtor!.Id);
            if (updateDebtor is null)
            {
                return NotFound("Debtor not found!");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _service.UpdateDebtor(debtor);
            return NoContent();
        }

        [HttpDelete("debtor/delete/{id}")]
        public async Task<IActionResult> DeleteDebtor(Guid id)
        {
            Debtor? debtor = await _service.GetDebtor(id);
            if (debtor is null)
            {
                return NotFound("Debtor not found!");
            }
            else
            {
                await _service.DeleteDebtor(debtor);
                return NoContent();
            }
        }

        [HttpDelete("debtor/delete/all")]
        public async Task<IActionResult> DeleteAllDebtors()
        {
            await _service.DeleteAllDebtors();
            return NoContent();
        }
        #endregion
    }
}
