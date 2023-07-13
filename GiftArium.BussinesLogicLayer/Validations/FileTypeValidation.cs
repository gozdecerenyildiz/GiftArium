using FluentValidation;
using GiftArium.Entity.POCO;
using System;
using System.Collections.Generic;
using System.Text;

namespace GiftArium.BussinesLogicLayer.Validations
{
    internal class FileTypeValidation:AbstractValidator<FileType>
    {
        public FileTypeValidation() 
        {
            RuleFor(x => x.FileTypeName).NotNull().WithMessage(" Dosya tipi adı alanı boş geçilemez");
            RuleFor(x => x.FileTypeName).Length(1,20).WithMessage(" Dosya tipi adı 1-20 arasında olmalıdır");

        }
    }
}
