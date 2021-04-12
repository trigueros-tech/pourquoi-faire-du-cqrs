using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace ExempleCQRS.Queries.Users
{
    public class GetUserById : IRequest<GetUserById.Dto>
    {
        public int Id { get; }

        public GetUserById(int id)
        {
            Id = id;
        }
        
        public class Dto
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }
    }
    
    public class GetUserByIdHandler : IRequestHandler<GetUserById, GetUserById.Dto>
    {
        public Task<GetUserById.Dto> Handle(GetUserById request, CancellationToken cancellationToken)
        {
            // TODO : Traitement métier ici
            return Task.FromResult(new GetUserById.Dto
            {
                Id = request.Id,
                FirstName = "Alain",
                LastName = "Deloin"
            });
        }
    }
}