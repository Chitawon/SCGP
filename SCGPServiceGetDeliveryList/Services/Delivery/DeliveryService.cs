using SCGPServiceGetDeliveryList.Models;
using System;

namespace SCGPServiceGetDeliveryList.Services.Delivery
{
    public class DeliveryService : IDeliveryService
    {
        private static readonly Dictionary<string, DeliveryList> _deliveryDB = new();

        public Exception ReceiveDelivery(DeliveryList deliveryList)
        {
            try
            {
                _deliveryDB.Add(deliveryList.ZKEY, deliveryList);
                return null;
            }
            catch (Exception ex)
            {
                return ex;
            }
        }

        public DeliveryList? GetDelivery(string deliveryKey)
        {
            DeliveryList? value = null;
            try
            {
                value = _deliveryDB[deliveryKey];
            }
            catch
            {
                value = null;
            }

            return value;
        }
    }
}