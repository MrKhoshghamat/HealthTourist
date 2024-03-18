using AutoMapper;
using HealthTourist.Application.Contracts.Identities;
using HealthTourist.Application.Contracts.Patients;
using HealthTourist.Common.Constants.Departments;
using HealthTourist.Common.Exceptions;
using HealthTourist.Domain.Account;
using HealthTourist.Domain.Department;
using MediatR;

namespace HealthTourist.Application.Features.Triage.Commands.CreatePatient;

public class CreatePatientCommandHandler(
    IPatientRepository patientRepository,
    IPersonRepository personRepository,
    IMapper mapper)
    : IRequestHandler<CreatePatientCommand, long>
{
    public async Task<long> Handle(CreatePatientCommand request, CancellationToken cancellationToken)
    {
        // Validate incoming request
        var validator = new CreatePatientCommandValidator();
        var validationResult = await validator.ValidateAsync(request, cancellationToken);
        if (validationResult.Errors.Count != 0)
            throw new BadRequestException(PatientExceptionConstants.BadRequestExceptionMessage, validationResult);

        // Map incoming request to domain model
        var person = mapper.Map<Person>(request);

        // Insert Person and get Id
        var personId = await personRepository.CreatePersonAndGetId(person);

        // Map incoming request to domain model and assign PersonId
        var patient = mapper.Map<Patient>(request);
        patient.PersonId = personId;

        // Insert record to database and return Id
        var result = await patientRepository.CreatePatientAndGetId(patient);

        // Return result
        return result;
    }
}