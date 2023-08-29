using SCGPServiceGetDeliveryList.Models;
using System;

namespace SCGPServiceGetDeliveryList.Services.Delivery
{
    public interface IDeliveryService
    {
        Exception ReceiveDelivery(DeliveryList deliveryList);
        DeliveryList GetDelivery(string deliveryKey);
    }
}
