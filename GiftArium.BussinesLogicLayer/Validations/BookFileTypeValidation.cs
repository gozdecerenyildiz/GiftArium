using FluentValidation;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Validations
{
    internal class BookFileTypeValidation:AbstractValidator<BookFileType>
    {
        public BookFileTypeValidation()
        {
            RuleFor(x => x.BookId).NotNull().WithMessage("Kitap ID alanı boş geçilemez");
            RuleFor(x => x.FileTypeId).NotNull().WithMessage("Dosya tip ID  alanı boş geçilemez");
        }
    }
}
