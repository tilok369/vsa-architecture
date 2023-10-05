using MediatR;
using System.Reflection;
using VsaArchitecture.Application.Common.Security;
using VsaArchitecture.Application.Contracts.Authentication;

namespace VsaArchitecture.Application.Common.Behaviours;

public class AuthorizationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
{
    private readonly ICurrentUserService _currentUserService;

    public AuthorizationBehaviour(ICurrentUserService currentUserService)
    {
        _currentUserService = currentUserService;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        var authorizeAttributes = request?.GetType().GetCustomAttributes<AuthorizeAttribute>();

        if (authorizeAttributes?.Any() ?? false)
        {
            // Must be authenticated user
            if (_currentUserService.UserId == null)
            {
                throw new UnauthorizedAccessException();
            }

            //TODO: check roles and policies in authorizeAttributes and do the necessary authorization
        }

        // User is authorized / authorization not required
        return await next();
    }
}
