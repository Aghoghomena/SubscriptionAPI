using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entity;

namespace WebApplication1.Domain
{
    public class SubscriptionImplementation : ISubscription
    {

        private SubContext _subContext;
        public SubscriptionImplementation(SubContext subContext )
        {

            _subContext = subContext;
        }
        public Subscription AddSubscription(Subscription sub)
        {
            //validate the email
            sub.dateAdded = DateTime.Now;
            _subContext.Subscriptions.Add(sub);
            _subContext.SaveChanges();
            return sub;
        }

        public void DeleteSubscription(Subscription sub)
        {
            //throw new NotImplementedException();
            var existing = _subContext.Subscriptions.Find(sub.email);
            if (existing != null)
            {
                _subContext.Subscriptions.Remove(existing);
                _subContext.SaveChanges();
            }
        }

        public Employee EditSubscription(Subscription sub)
        {
            throw new NotImplementedException();
        }

        public Subscription GetSingleSubscription(string email)
        {
            var existing = _subContext.Subscriptions.Where(c => c.email == email).FirstOrDefault();
            return existing;
            
        }

        public List<Subscription> GetSubscriptions()
        {
            return _subContext.Subscriptions.ToList();
        }
    }
}
