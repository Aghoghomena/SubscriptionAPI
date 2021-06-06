using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using WebApplication1.Domain;
using WebApplication1.Entity;

namespace WebApplication1.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*", exposedHeaders: "X-My-Header")]
    [ApiController]
    public class SubscriptionController : ControllerBase
    {
        private ISubscription _subscription;
        public SubscriptionController(ISubscription subscriprion)
        {
            //this is dependency injection
            _subscription = subscriprion;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult getEmployees()
        {
            return Ok(_subscription.GetSubscriptions());
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult CreateSubscription(Subscription sub)
        {

            try
            {
                //validate email
                var existing = _subscription.GetSingleSubscription(sub.email);
                if(existing == null)
                {
                    _subscription.AddSubscription(sub);

                    var status = true;
                    return Ok(status);
                }
                else
                {
                    return BadRequest($"Email {sub.email} exists");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            

        }
    }
}
