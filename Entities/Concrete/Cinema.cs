using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Cinema:IEntity
    {
        public int Id { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

    }
}
