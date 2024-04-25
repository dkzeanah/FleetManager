using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class EntityAttributeValue
    {
        [Key]
        public int Id { get; set; }
        public int EntityId { get; set; }

        public Entity Entity { get; set; }

        public int AttributeId { get; set; }

        public Attribute Attribute { get; set; }

        public string Value { get; set; }
    }
}
