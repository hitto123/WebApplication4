using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Web;
using WebApplication4.Models.DTOs;

namespace WebApplication4.Models.VM
{
    public class MemberCreateVM
    {
        public int id { get; set; }
        [Display(Name ="中文姓名")]
        [Required(ErrorMessage ="{0}必填")]
        [StringLength(30,ErrorMessage= "{0}長度不能超過{1}字")]
        public string Name { get; set; }
        [Display(Name = "帳號")]
        [Required(ErrorMessage ="{0}必填")]
        [StringLength(30,ErrorMessage ="{0}長度不能超過{1}字")]
        public string Account { get; set; }
        [Display(Name = "密碼")]
        [Required(ErrorMessage = "{0}必填")]
        [StringLength(30, ErrorMessage = "{0}長度不能超過{1}字")]
        public string Password { get; set; }
        [Display(Name = "確認密碼")]
        [Required(ErrorMessage = "{0}必填")]
        [StringLength(30, ErrorMessage = "{0}長度不能超過{1}字")]
        public string ConfirmPassword { get; set; }
        [Display(Name ="手機號碼" )]
        [Required(ErrorMessage = "{0}必填")]
        [StringLength(10, ErrorMessage = "{0}長度不能超過{1}字")]
        public string Cellphone { get; set; }

    }
    public static class MemberCreateVMExtensions
    {
        public static MemberCreateDTO ToDTO(this MemberCreateVM model)
        {
            return new MemberCreateDTO
            {
                Name = model.Name,
                Account = model.Account,
                Password = model.Password,
                Cellphone = model.Cellphone
            };
        }
    }

}