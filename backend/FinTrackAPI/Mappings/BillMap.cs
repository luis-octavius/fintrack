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

            Id(x => x.Id);
            Map(x => x.Name).Length(50);
            Map(x => x.Description).Length(50);
            Map(x => x.Status).CustomType<NHibernate.Type.EnumStringType<BillStatus>>();
            Map(x => x.ExpDate);
            References(x => x.User);
        }
    }
}
