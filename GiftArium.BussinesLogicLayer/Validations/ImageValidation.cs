using FluentValidation;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Validations
{
    internal class ImageValidation : AbstractValidator<Image>
    {
        public ImageValidation() 
        {
            RuleFor(x => x.BookId).NotNull().WithMessage(" Kullanıcı ID alanı boş geçilemez");
            RuleFor(x => x.ImageURL).NotNull().WithMessage(" Fotoğraf URL alanı boş geçilemez");
           


        }
    }
    
}
