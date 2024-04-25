using System.ComponentModel.DataAnnotations;

namespace BlazorApp1.CarModels
{
    public class RoleEventMapping
    {
        [Key]
        public int Id { get; set; }
        public string RoleId { get; set; }
        public int DefaultEventTypeId { get; set; }

        public static implicit operator RoleEventMapping(int v)
        {
            throw new NotImplementedException();
        }
    }

}
