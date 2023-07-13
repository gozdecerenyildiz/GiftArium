using FluentValidation;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Validations
{
    internal class BookCategoryValidation:AbstractValidator<BookCategory>
    {
        public BookCategoryValidation() 
        {
            RuleFor(x => x.CategoryId).NotNull().WithMessage("Kategory ID alanı boş geçilemez");
            RuleFor(x => x.BookId).NotNull().WithMessage("Kitap ID alanı boş geçilemez");
        }

    }
}
