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
    public class BaseValidator<T> : AbstractValidator<T>
    {
        public void DoValidate(T ubi)
        {
            ValidationResult result = this.Validate<T>(ubi);
            if (!result.IsValid)
            {
                if (result.Errors.Count > 0)
                    throw new ArgumentException(result.Errors[0].ErrorMessage);
                else throw new ArgumentException("validate result is error");
            }
        }
    }

    public class MenuValidator : BaseValidator<admin_menu>
    {
        public MenuValidator()
        {
            RuleFor(x => x.name).NotEmpty().WithMessage("请输入名字！");
            RuleFor(x => x.parentidx).GreaterThanOrEqualTo(0).WithMessage("上级分类不正确");
            RuleFor(x => x.disorder).GreaterThan(0).WithMessage("请输入正确的排序！");
        }

        public static MenuValidator CreateInstance()
        {
            return new MenuValidator();
        }

        private bool BeEmail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            //  return false;
        }
    }
}
