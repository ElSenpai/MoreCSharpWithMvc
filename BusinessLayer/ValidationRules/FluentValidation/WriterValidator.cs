using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class WriterValidator :AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(w => w.FirstName).NotEmpty().WithMessage("Yazar adını boş geçemezsiniz");
            RuleFor(w => w.LastName).NotEmpty().WithMessage("Yazar soy adını boş geçemezsiniz");
            RuleFor(w => w.About).NotEmpty().WithMessage("Hakkında kısmını boş geçemezsiniz");
            RuleFor(w => w.About).Must(InsideOfA).WithMessage("İçerisinde a harfi geçmelidir");
            RuleFor(w => w.Title).NotEmpty().WithMessage("Ünvanı boş geçemezsin");
        }

        private bool InsideOfA(string arg)
        {
            return arg.Contains("a");
        }
    }
}
