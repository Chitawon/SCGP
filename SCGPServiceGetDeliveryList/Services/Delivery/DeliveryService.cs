using SCGPServiceGetDeliveryList.Models;
using System;

namespace SCGPServiceGetDeliveryList.Services.Delivery
{
    public class DeliveryService : IDeliveryService
    {
        private static readonly Dictionary<string, SDI01> _deliveryDB = new();

        public Exception ReceiveDelivery(SDI01 deliveryList)
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

        public SDI01? GetDelivery(string deliveryKey)
        {
            SDI01? value = null;
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