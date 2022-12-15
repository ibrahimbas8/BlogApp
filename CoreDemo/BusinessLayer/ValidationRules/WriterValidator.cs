using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator: AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adı Soyadı Kısmı Boş geçilemez");
            RuleFor(x => x.WriterName).MinimumLength(2).WithMessage("Minimum 2 karakter girişi yapın");
            RuleFor(x => x.WriterName).MaximumLength(50).WithMessage("En fazla 50 karakter girişi yapın");
           
            RuleFor(x => x.WriterPassword).NotEmpty().WithMessage("Şifre kısmı boş olamaz."); 
            RuleFor(x => x.WriterPassword).MinimumLength(8).WithMessage("Şifre kısmı 8 karekterden kısa olamaz.");
            RuleFor(x => x.WriterPassword).Matches(@"[A-Z]+").WithMessage("Sifre en az bir büyük harf içermelidir.");
            RuleFor(x => x.WriterPassword).Matches(@"[a-z]+").WithMessage("Sifre en az bir küçük harf içermelidir");
            RuleFor(x => x.WriterPassword).Matches(@"[0-9]+").WithMessage("Sifre en az bir rakam içermelidir");

            RuleFor(x => x.WriterMail).NotEmpty().WithMessage("Mail Adresi Kısmı Boş geçilemez");
            RuleFor(x => x.WriterMail).Matches(@"[@,.]+").WithMessage("Mail adresi @ ve . icermelidir");

            RuleFor(x => x.WriterImage).NotEmpty().WithMessage("Resim Kısmı Boş geçilemez");
        }
    }
}
