﻿using FreeSql.DataAnnotations;

namespace BootstrapBlazor.Components
{
    /// <summary>
    /// 菜单
    /// </summary>
    public partial class MenuEntity : EntityCreated
    {
        [Navigate(nameof(ParentId))]
        public MenuEntity Parent { get; set; }
        [Navigate(nameof(ParentId))]
        public List<MenuEntity> Childs { get; set; }

        /// <summary>
        /// 是否系统
        /// </summary>
        public bool IsSystem { get; set; }
        /// <summary>
        /// 父级菜单
        /// </summary>
        public long ParentId { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        [Column(StringLength = 50)]
        public string Label { get; set; }
        /// <summary>
        /// 图标
        /// </summary>
        [Column(StringLength = 50)]
        public string Icon { get; set; }
        /// <summary>
        /// 路径
        /// </summary>
        [Column(StringLength = 50)]
        public string Path { get; set; }
        [Column(StringLength = 50)]
        public string PathLower { get; set; }
        /// <summary>
        /// 新窗口打开
        /// </summary>
        public bool TargetBlank { get; set; }
        /// <summary>
        /// 排序
        /// </summary>
        public int Sort { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public MenuEntityType Type { get; set; }
    }
    public enum MenuEntityType { 菜单, 按钮, 外部连接, 增删改查 }
}
