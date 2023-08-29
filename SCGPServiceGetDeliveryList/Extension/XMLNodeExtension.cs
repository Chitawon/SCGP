using System.Xml;

namespace SCGPServiceGetDeliveryList.Extension
{
    public static class XMLNodeExtension
    {
        public static string? CheckNode(this XmlNode xmlNode, string stringNode)
        {
            string? value = (xmlNode[stringNode]?.InnerText != null) ? xmlNode[stringNode]?.InnerText : null;

            return value;
        }
    }
}
