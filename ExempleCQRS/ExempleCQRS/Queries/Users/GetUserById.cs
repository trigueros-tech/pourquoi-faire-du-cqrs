using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ExempleCQRS.Queries.Users
{
    public class GetUserById : IRequest<UserDto>
    {
        public int Id { get; }

        public GetUserById(int id)
        {
            Id = id;
        }
    }
    
    public class UserDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    
    public class GetUserByIdHandler : IRequestHandler<GetUserById, UserDto>
    {
        public Task<UserDto> Handle(GetUserById request, CancellationToken cancellationToken)
        {
            // TODO : Traitement métier ici
            return Task.FromResult(new UserDto
            {
                Id = request.Id,
                FirstName = "Alain",
                LastName = "Deloin"
            });
        }
    }
}