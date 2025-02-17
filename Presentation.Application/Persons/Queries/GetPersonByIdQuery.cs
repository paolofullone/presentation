﻿using MediatR;
using Presentation.Domain.Entities;

namespace Presentation.Application.Persons.Queries
{
    // fiz somente duas queries de exemplo, esta e a GetPersons
    public class GetPersonByIdQuery : IRequest<Person>
    {
        public int Id { get; set; }

        public GetPersonByIdQuery(int id)
        {
            Id = id;
        }
    }
}
