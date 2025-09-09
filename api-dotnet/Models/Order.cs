using System;

namespace api_dotnet.Models
{
    public class Order
    {
        public long Id { get; set; }
        public DataTime OrderDate { get; set; }
        public OrderStatus Staus { get; set; }

        public override string ToString() =>
            $"Id={Id}, OrderDate={OrderDate}, Status={Status}";
    }
}