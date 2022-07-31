using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Producer:IEntity
    {
        public int Id { get; set; }
        public string ProfilePictureUrl { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }


    }
}
