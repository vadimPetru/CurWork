using CurWork.DAL.Entities;
using FluentValidation;


namespace CurWork.TypeOFValidations
{
    public class ValidatorCustomer : AbstractValidator<Customer>
    {
        public ValidatorCustomer()
        {
            RuleForEach(item => item.Name).Must(Char.IsLetter).NotNull().NotEmpty();
            RuleForEach(item => item.Surname).Where(item => item != '-').Must(Char.IsLetter).NotNull().NotEmpty();
            RuleFor(item => item.Age).InclusiveBetween(13,120);
        }
    }

    public class ValidatorMovie : AbstractValidator<Movie>
    {
        public ValidatorMovie()
        {
            RuleForEach(item => item.Moviename).Where(item => item != '-').NotNull().NotEmpty();
            RuleForEach(item => item.Genre).Must(Char.IsLetter).NotNull().Empty();
            RuleFor(item => item.DateOfRelease).NotNull().NotEmpty();
        }
    }

    

}
