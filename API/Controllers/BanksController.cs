using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[Route("api/[controller]")]
[ApiController]
public class BanksController : ControllerBase
{
    private IBankService _bankService;
    public BanksController()
    {
        _bankService = new BankManager();
    }

    [HttpGet]
    public List<Bank> Get()
    {
        return _bankService.GetBank();
    }
    [HttpGet("{id}")]
    public Bank Get(int id)
    {
        return _bankService.GetBank(id);
    }
    [HttpPost]
    public Bank Post([FromBody]Bank bank)
    {
        return _bankService.CreateBank(bank);
    }
    [HttpPut("{id}")]
    public Bank Put([FromBody] Bank bank)
    {
        return _bankService.UpdateBank(bank);
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
        _bankService.DeleteBank(id);
    }
}