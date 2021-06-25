using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.FluentValidation
{
   public class CategoryValidator:AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Kategori adını boş geçemezsiniz!");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Açıklamayı boş geçemezsiniz!");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter girişi yapın!");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Lütfen 20 karakteri aşmayın");
        }
    }
}
