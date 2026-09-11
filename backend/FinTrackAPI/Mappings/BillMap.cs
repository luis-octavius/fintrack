using FinTrackAPI.Domain.Entities;
using FinTrackAPI.Domain.Enums;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using NHibernate.Criterion;
using NHibernate.Mapping;

namespace FinTrackAPI.Mappings
{
    public class BillMap : ClassMap<Bill>
    {
        public BillMap() {

            Schema("fintrack");
            Table("bills");

            Id(x => x.Id).Column("id");
            Map(x => x.Name).Length(50).Column("name");
            Map(x => x.Description).Length(50).Column("description");
            Map(x => x.Status).CustomType<NHibernate.Type.EnumStringType<BillStatus>>().Column("bill_status");
            Map(x => x.ExpDate).Column("exp_date");
            References(x => x.User).Column("user_id");
        }
    }
}
