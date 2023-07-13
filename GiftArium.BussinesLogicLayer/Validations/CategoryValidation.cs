using FluentValidation;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Validations
{
    internal class CategoryValidation:AbstractValidator<Category>
    {
        public CategoryValidation() 
        {
            RuleFor(x => x.CategoryName).NotNull().WithMessage("Kategory ismi alanı boş geçilemez");
            RuleFor(x => x.CategoryName).MaximumLength(50).WithMessage("Açıklama alanı 50 karakterden az olamaz.");
            

        }

    }
}
