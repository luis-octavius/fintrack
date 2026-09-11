using FinTrackAPI.Domain.Enums;

namespace FinTrackAPI.Domain.Entities
{
    public class Bill
    {
        public virtual Guid Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual BillStatus Status { get; set; }
        public virtual decimal Value { get; set; }
        public virtual DateOnly ExpDate { get; set; }

        public virtual User User { get; set; }

    }
}
