using SCGPServiceGetDeliveryList.Models;
using System;

namespace SCGPServiceGetDeliveryList.Services.Delivery
{
    public interface IDeliveryService
    {
        Exception ReceiveDelivery(SDI01 deliveryList);
        SDI01 GetDelivery(string deliveryKey);
    }
}
