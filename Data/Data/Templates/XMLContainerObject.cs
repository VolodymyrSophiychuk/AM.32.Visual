using System.Xml.Serialization;

namespace Data.Templates
{
    [Serializable]
    public class XMLContainerObject
    {
        [XmlArrayItem]
        public List<XMLObject>? XMLObjects { get; set; }

        public XMLContainerObject() { }
        public XMLContainerObject(List<XMLObject> @object)
        {
            XMLObjects = @object;
        }
    }
}
