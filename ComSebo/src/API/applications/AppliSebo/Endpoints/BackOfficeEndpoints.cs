using AppliSebo.Dtos;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace AppliSebo.Endpoints
{
    public static class BackOfficeEndpoints
    {
        /// <summary>
        /// elle regroupe toutes 
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSeboBackService( this IServiceCollection services)
        {
            return services;
        }

        public static RouteGroupBuilder MapBackSeboEndpoint(this RouteGroupBuilder builder)
        {
            builder.MapPost("",AddCategory);
            return builder;
        }

        private static async Task<IResult> AddCategory(
            [FromBody] CategoryInput categoryInput,
            [FromServices] IValidator<CategoryInput> validator
            )
        {
            var result = validator.Validate( categoryInput );
            if (!result.IsValid) return Results.BadRequest(result.Errors.Select(e => new
            {
                e.ErrorMessage,
                e.PropertyName,
            }));
            // appel  service
            return Results.Ok();
        }

    }
}
