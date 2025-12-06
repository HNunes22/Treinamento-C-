using enumerate.Entities.Enums;

namespace enumerate.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment  { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"Id: {Id}\nMoment: {Moment}\nStatus: {Status}";
        }
    }
}
