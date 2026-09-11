using FluentNHibernate.Conventions;
using FluentNHibernate.Conventions.Instances;
using System.Text.RegularExpressions;

namespace FinTrackAPI.Config
{
    public class SnakeCaseConvention : IClassConvention, IPropertyConvention, IIdConvention
    {
        public void Apply(IClassInstance instance)
        {
            instance.Table(ToSnakeCase(instance.EntityType.Name));
        }

        public void Apply(IIdentityInstance instance)
        {
            instance.Column(ToSnakeCase(instance.Name));
        }

        public void Apply(IPropertyInstance instance)
        {
            instance.Column(ToSnakeCase(instance.Name));
        }

        private string ToSnakeCase(string input)
        {
            if (string.IsNullOrEmpty(input)) return input;

            return Regex.Replace(input, @"(?<!^)(?=[A-Z])", "_").ToLower();
        }
    }
}
