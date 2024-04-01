using CoreAPIBank3170.Models.ContextClasses;
using CoreAPIBank3170.Models.Entities;
using CoreAPIBank3170.RequestModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreAPIBank3170.Controllers
{
    //Todo: Invariant Globalization xml tag'ini false'a cekmeyi unutmayın...Bunu yapmak icin projenize bir kez tıklamanız ve pencerenin acılmasını saglamanız gerekir...Sonra o tag'i bulabilirsiniz...

    //Cors sistemini unutmayın
    
    [Route("api/[controller]")]
    [ApiController]
    public class TransactionController : ControllerBase
    {
        MyContext _db;

        public TransactionController(MyContext db)
        {
            _db = db;
        }


        [HttpPost]
        public async Task<IActionResult> StartTransaction(PaymentRequestModel item)
        {
            if(_db.CardInfoes.Any(x=>x.CardNumber == item.CardNumber && x.CCV == item.CCV && x.CardUserName == item.CardUserName)) //kart bilgileri tutuyorsa aslında burada daha ayrıntılı bir kontrol yapılır
            {
               
                UserCardInfo uCInfo = await _db.CardInfoes.SingleOrDefaultAsync(x => x.CardNumber == item.CardNumber && x.CCV == item.CCV && x.CardUserName == item.CardUserName);



                if (uCInfo.Balance >= item.ShoppingPrice)
                {
                    uCInfo.Balance -= item.ShoppingPrice; //Fiyat, kartın balance'indan düsüyor
                    await _db.SaveChangesAsync();

                    return Ok("Ödeme basarıyla alındı");
                }
                else return StatusCode(400, "Kart bakiyesi yetersiz bulundu");
            }

            return StatusCode(400, "Kart bilgileri yanlıs");
        }
    }
}
