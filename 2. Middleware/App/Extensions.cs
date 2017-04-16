using Microsoft.AspNetCore.Builder;

namespace App
{
    public static class Extensions
    {
        public static IApplicationBuilder UseCustomMiddleware(this IApplicationBuilder builder)
            => builder.UseMiddleware<CustomMiddleware>();
        
    }
}