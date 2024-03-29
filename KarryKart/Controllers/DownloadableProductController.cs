﻿using Contracts;
using Entities.Models;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class DownloadController : ControllerBase
{
    private readonly IDownload _iDownloadRepository;
    public DownloadController(IDownload iDownloadRepository)
    {
        _iDownloadRepository = iDownloadRepository;
    }
    [HttpGet(" GetDownloadableProduct")]
    public async Task<IEnumerable<DownloadableProduct>> GetDownloadableProducts()
    {
        var product = await _iDownloadRepository.GetDownloadableProducts();
        return product;
    }
    [HttpGet("GetDownloadableProductbyId")]
    public async Task<ActionResult<DownloadableProduct>> GetDownloadableProductById(int Id)
    {
        var product = await _iDownloadRepository.GetDownloadableProductById(Id);
        return product;
    }
    [HttpGet("GetDownloadByName")]
    public async Task<ActionResult<IQueryable<DownloadableProduct>>> GetDiscountbyName(string name)
    {
        var pro = await _iDownloadRepository.GetDownloadbyName(name);
        return Ok(pro);
    }

    [HttpPost("AddDownloadableProduct")]
    public async Task<ActionResult<DownloadableProduct>> AddDownloadableProduct(DownloadableProduct downloadableProduct)
    {
        DownloadableProduct Response = new DownloadableProduct();
        if (downloadableProduct != null)
        {
            downloadableProduct.Id = 0;
            Response = await _iDownloadRepository.AddDownloadableProduct(downloadableProduct);
        }

        return Response;
    }
    [HttpPut("UpdateDownloadbleProduct/{id}")]
    public async Task<ActionResult<DownloadableProduct>> UpdateDownloadableProduct(DownloadableProduct downloadableProduct)
    {


        var update = await _iDownloadRepository.UpdateDownloadableProduct(downloadableProduct);


        return update;
    }
    [HttpDelete("DeleteCategory/{id}")]
    public async Task<IActionResult> DeleteDownloadableProduct(int Id)
    {


        await _iDownloadRepository.DeleteDownloadableProduct(Id);
        return NoContent();
    }
}