using System.Linq.Expressions;

namespace OneProjectWebAPI.BL.Services;

public static class ExpressionHelper
{
    public static Expression<Func<T, bool>>? BuildEquals<T>(string propertyName, object value)
    {
        if (value == null ||
            string.IsNullOrWhiteSpace(propertyName) ||
            string.IsNullOrWhiteSpace(value.ToString()))
        {
            return null;
        }

        var parameter = Expression.Parameter(typeof(T), "x");
        var property = Expression.Property(parameter, propertyName);
        var constant = Expression.Constant(value);

        var equals = Expression.Equal(property, Expression.Convert(constant, property.Type));
        return Expression.Lambda<Func<T, bool>>(equals, parameter);
    }
}
