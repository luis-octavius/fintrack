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

            Id(x => x.Id).Column("id");
            Map(x => x.Name).Column("name");
            Map(x => x.Email).Column("email");
            Map(x => x.PasswordHash).Column("password_hash");
        }
    }
}
