using MerchantApi.Attributes;
using MerchantApi.Controllers;
using MerchantApi.Model;
using MerchantApi.Services;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MerchantApi.Controllers;

[Route("api/merchants")]
[ApiController]
public class MerchantsController : ControllerBase
{
    private readonly IMerchantService _merchantService;

    public MerchantsController(IMerchantService merchantService)
    {
        _merchantService = merchantService;
    }

    [HttpGet]
    [FakeAuthorize]
    public IActionResult GetAll() => Ok(_merchantService.GetAll());

    [HttpGet("{id}")]
    [FakeAuthorize]
    public IActionResult GetById(int id)
    {
        var merchant = _merchantService.GetById(id);
        return merchant == null ? NotFound() : Ok(merchant);
    }

    [HttpPost]
    [FakeAuthorize]
    public IActionResult Create([FromBody] Merchant newMerchant)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var createdMerchant = _merchantService.Create(newMerchant);
        return CreatedAtAction(nameof(GetById), new { id = createdMerchant.Id }, createdMerchant);
    }

    [HttpPut("{id}")]
    [FakeAuthorize]
    public IActionResult Update(int id, [FromBody] Merchant updatedMerchant)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        var updated = _merchantService.Update(id, updatedMerchant);
        return updated == null ? NotFound() : Ok(updated);
    }

    [HttpDelete("{id}")]
    [FakeAuthorize]
    public IActionResult Delete(int id)
    {
        _merchantService.Delete(id);
        return NoContent();
    }
}
 
   
    
