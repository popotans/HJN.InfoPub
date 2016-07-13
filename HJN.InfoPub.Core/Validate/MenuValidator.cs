using FluentValidation;
using FluentValidation.Results;
using HJN.InfoPub.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJN.InfoPub.Core.Validate
{
    public class MenuValidator : AbstractValidator<infopub_admin_menu>
    {
        public MenuValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("请输入名字！");
            RuleFor(x => x.disorder).LessThanOrEqualTo(0).WithMessage("请输入排序！");
            RuleFor(x => x.parentidx).LessThan(0).WithMessage("邮箱格式不正确");
        }

        public static void DoValidate(infopub_admin_menu ubi)
        {
            MenuValidator validator = new MenuValidator();
            ValidationResult result = validator.Validate(ubi);
            if (!result.IsValid)
            {
                if (result.Errors.Count > 0)
                    throw new ArgumentException(result.Errors[0].ErrorMessage);
                else throw new ArgumentException("validate result is error");
            }
        }

        private bool BeEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            //  return false;
        }
    }
}
