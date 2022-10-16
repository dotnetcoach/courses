using System.Runtime.CompilerServices;

namespace DotNetCoach.CSTricks.H;

static class Utility
{
    public static void Validate(
        bool condition,
        [CallerArgumentExpression("condition")] string? message = null)
    {
        if (!condition)
        {
            throw new InvalidOperationException(
                $"Argument failed validation: {message}"
            );
        }
    }
}
