﻿using MediatR;
using Presentation.Application.Persons.Commands;
using Presentation.Domain.Entities;
using Presentation.Domain.Interfaces;

namespace Presentation.Application.Persons.Handlers
{
    public class PersonUpdateCommandHandler : IRequestHandler<PersonUpdateCommand, Person>
    {
        private readonly IPersonRepository _personRepository;

        public PersonUpdateCommandHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository ?? throw new ArgumentNullException(nameof(personRepository));
        }

        public async Task<Person> Handle(PersonUpdateCommand request, CancellationToken cancellationToken)
        {
            var person = await _personRepository.GetPersonByIdAsync(request.Id);
            if (person == null)
            {
                throw new ApplicationException($"Entity could not be found.");
            }
            else
            {
                person.Update(request.Email, request.Password);
                return await _personRepository.UpdatePersonAsync(person);
            }
        }
    }
}

