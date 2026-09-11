using FinTrackAPI.Domain.Entities;
using FluentNHibernate.Conventions.Helpers;
using FluentNHibernate.Mapping;
using NHibernate.Mapping;

namespace FinTrackAPI.Mappings
{
    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Schema("fintrack");
            Table("users");

            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Email);
            Map(x => x.PasswordHash);
        }
    }
}
