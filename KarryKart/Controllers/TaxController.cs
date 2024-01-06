using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

[Route("api/[controller]")]
[ApiController]
public class TaxController : ControllerBase
{
    private readonly ITaxRepos _iTaxRepository;
    public TaxController(ITaxRepos iTaxRepository)
    {
        _iTaxRepository = iTaxRepository;
    }

    [HttpGet(" GetTax")]
    public async Task<IEnumerable<Tax>> GetTax()
    {
        var Tax = await _iTaxRepository.GetTax();
        return Tax;
    }
    [HttpGet("GetTaxbyId")]
    public async Task<ActionResult<Tax>> GetTaxbyId(int Id)
    {
        var discount = await _iTaxRepository.GetTaxbyId(Id);
        return discount;
    }
    [HttpPost("AddTax")]
    public async Task<ActionResult<Tax>> AddTax(Tax tax)
    {
        Tax Response = new Tax();
        if (tax != null)
        {
            tax.TaxId = 0;
            Response = await _iTaxRepository.AddTax(tax);
        }

        return Response;
    }
    [HttpPut("UpdateTax/{id}")]
    public async Task<ActionResult<Tax>> UpdateTax(Tax tax)
    {


        var update = await _iTaxRepository.UpdateTax(tax);


        return update;
    }
    [HttpDelete("DeleteTax/{id}")]
    public async Task<IActionResult> DeleteTax(int Id)
    {


        await _iTaxRepository.DeleteTax(Id);
        return NoContent();
    }
}
    