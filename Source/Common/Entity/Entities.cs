﻿using System.Data.Entity;

namespace Insight.Base.Common.Entity
{
    public class Entities : DbContext
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public Entities() : base("name=Entities")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<User> users { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<Organization> organizations { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<DataConfig> dataConfigs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<Log> logs { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<LogRule> logRules { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<Application> applications { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<Navigator> navigators { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<Function> functions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<Role> roles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<RoleMember> roleMembers { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<RoleFunction> roleFunctions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<RoleData> roleDatas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<UserRole> userRoles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<Category> categories { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<ImageData> imageDatas { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<ModuleParam> moduleParams { get; set; }
    }
}