﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XEngine.Models;

namespace XEngine.DAL
{
    public class XEngineInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<XEngineContext>
    {
        protected override void Seed(XEngineContext context)
        {
            var sysUsers = new List<SysUser>
            {
                new SysUser{ID=1,Name="ZS",CName="张三",Email="zs@163.com",Password="1",ModifiedDate=DateTime.Now},
                new SysUser{ID=2,Name="LS",CName="李四",Email="ls@163.com",Password="2",ModifiedDate=DateTime.Now},
                new SysUser{ID=3,Name="WW",CName="王五",Email="ww@163.com",Password="3",ModifiedDate=DateTime.Now}
            };
            sysUsers.ForEach(s => context.SysUsers.Add(s));
            context.SaveChanges();

            var sysRoles = new List<SysRole>
            {
                new SysRole{ID=1,Name="Admin",CName="管理员",Description="最高权限",ModifiedDate=DateTime.Now},
                new SysRole{ID=2,Name="User",CName="普通用户",Description="一般权限",ModifiedDate=DateTime.Now}
            };
            sysRoles.ForEach(s => context.SysRoles.Add(s));
            context.SaveChanges();

            var sysUserRoles = new List<SysUserRole>
            {
                new SysUserRole{SysUserID = 1,SysRoleID=1,ModifiedDate=DateTime.Now},
                //new SysUserRole{SysUserID = 1,SysRoleID=2,ModifiedDate=DateTime.Now},
                new SysUserRole{SysUserID = 2,SysRoleID=1,ModifiedDate=DateTime.Now},
                new SysUserRole{SysUserID = 3,SysRoleID=2,ModifiedDate=DateTime.Now},
            };
            sysUserRoles.ForEach(s => context.SysUserRoles.Add(s));
            context.SaveChanges();
        }
    }
}