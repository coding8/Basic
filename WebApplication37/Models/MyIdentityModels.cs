using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace WebApplication37.Models
{
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [Display(Name = "角色名")]
        public string Name { get; set; }
    }

    public class UserViewModel
    {
        public string Id { get; set; }

        [DisplayName("员工编号")]
        public string UserName { get; set; }

        public IEnumerable<SelectListItem> RolesList { get; set; }
    }

    //显示用户和角色列表
    public class ListUserAndRoleViewModel
    {
        public string UserId { get; set; }
        public string UserName { get; set; }
        public string RoleId { get; set; }
        public string RoleName { get; set; }
    }

    // 显示用户名称
    public class ListUser
    {
        public string Id { get; set; }
        [DisplayName("用户编号")]
        public string EmployeeId { get; set; }
        [DisplayName("用户名")]
        public string EmployeeName { get; set; }
        [DisplayName("锁定")]
        public bool LockoutEnabled { get; set; }
        [DisplayName("锁定时间")]
        public DateTime? LockoutEndDateUtc { get; set; }
        [DisplayName("错误尝试")]
        public int AccessFailedCount { get; set; }
    }
}