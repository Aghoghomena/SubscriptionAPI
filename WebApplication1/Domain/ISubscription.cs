using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Domain
{
    public interface ISubscription
    {

        //get all subscription
        List<Subscription> GetSubscriptions();

        //get single employee
        Subscription GetSingleSubscription(string email);

        //create employee
        Subscription AddSubscription(Subscription sub);

        //delete employee
        void DeleteSubscription(Subscription sub);

        //edit employee data
        Employee EditSubscription(Subscription sub);
    }
}
