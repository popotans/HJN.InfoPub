using FluentValidation;
using HJN.InfoPub.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HJN.InfoPub.Core.Validate
{
    public class InfoValidator : AbstractValidator<infos>
    {
        public InfoValidator()
        {
            RuleFor(x => x.name).NotEmpty().NotNull().WithMessage("信息标题不能为空");
            RuleFor(x => x.catid).GreaterThan(0).WithMessage("请正确选择信息分类");
            RuleFor(x => x.creatorpwd).NotNull().NotEmpty().WithMessage("删除管理密码不能为空");
            RuleFor(x => x.userid).GreaterThan(0).WithMessage("用户ID不正确");
            RuleFor(x => x.shortcontent).NotEmpty().NotNull().WithMessage("信息内容不能为空");
        }

        public static InfoValidator CreateInstance()
        {
            return new InfoValidator();
        }

    }
}
