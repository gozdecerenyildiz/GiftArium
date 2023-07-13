using FluentValidation;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Validations
{
    internal class CartValidation:AbstractValidator<Cart>
    {
        public CartValidation() 
        {
            RuleFor(x => x.AppUserId).NotNull().WithMessage(" Kullanıcı ID alanı boş geçilemez");
            RuleFor(x => x.BookId).NotNull().WithMessage(" Kitap ID alanı boş geçilemez");
            RuleFor(x => x.Quantity).NotNull().WithMessage("Miktar ID alanı boş geçilemez");

        }
    }
}
