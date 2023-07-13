using FluentValidation;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Validations
{
    internal class BookValidation : AbstractValidator<Book>
    {
        public BookValidation() 
        {
            RuleFor(x=>x.BookName).NotNull().WithMessage("Kitap ismi alanı boş geçilemez");
            RuleFor(x => x.Price).NotNull().WithMessage("Fiyat alanı boş geçilemez");
            RuleFor(x => x.Description).NotNull().WithMessage("Açıklama alanı boş geçilemez");
            RuleFor(x => x.PageCount).NotNull().WithMessage("Sayfa sayısı boş geçilemez");
            RuleFor(x => x.Tags).NotNull().WithMessage("Etiket alanı boş geçilemez");
            RuleFor(x => x.BookName).Length(5,45).WithMessage("Kitap ismi 5-45 karakter aralığında olmalıdır.");
            RuleFor(x => x.Description).MinimumLength(50).WithMessage("Açılama 50 karakter az olamaz.");
            RuleFor(x => x.Tags).MaximumLength(75).WithMessage("Etiket alanı 75 fazla olamaz");






        }
    }
}
