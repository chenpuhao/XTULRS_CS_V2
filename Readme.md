﻿# 湘潭大学图书馆预约系统 C# 语言部分

## 项目简介

湘潭大学图书馆预约系统 C# 语言部分是 2025 年湘潭大学软件工程 C 语言大作业的项目之一。本项目是系统的第二代版本，相较于第一代，进行了以下改进：

- **UI 框架升级**：使用了 AntdUI，界面更加美观，用户体验更佳。
- **功能优化**：改进了座位管理、用户管理和预约记录管理的功能。
- **代码结构优化**：更清晰的模块划分，便于维护和扩展。

项目地址：[https://github.com/chenpuhao/XTULRS_CS_V2](https://github.com/chenpuhao/XTULRS_CS_V2)

---

## 功能概述

### 1. 座位管理
- **新增座位**：支持通过表单添加新的座位。
- **删除座位**：可以删除指定的座位。
- **导入/导出座位**：支持 JSON 格式的座位数据导入和导出。
- **筛选座位**：按房间号、座位号或占用情况筛选座位。
- **解除占用**：可以解除座位的占用状态。

### 2. 用户管理
- **新增用户**：支持通过表单添加新用户。
- **删除用户**：可以删除指定用户（不能删除当前登录用户）。
- **修改用户名/密码**：支持修改用户的用户名和密码。
- **设置权限**：可以将用户设置为管理员或普通用户。
- **清除预约**：清除用户的所有预约记录。

### 3. 预约记录管理
- **筛选记录**：按房间号、座位号、用户或时间范围筛选预约记录。
- **删除记录**：支持删除单条或所有预约记录。
- **导出记录**：将筛选后的记录导出为 JSON 或 Excel 文件。

### 4. 系统管理
- **数据刷新**：实时刷新座位、用户和预约记录数据。
- **退出系统**：保存所有数据并安全退出。

---

## 技术栈

- **编程语言**：C#
- **UI 框架**：AntdUI
- **数据序列化**：`System.Text.Json`
- **加密技术**：AES 对称加密
- **外部库**：EPPlus（用于导出 Excel 文件）

---

## 项目结构

```
LRSV2/
├── Admin.cs                // 管理端主界面逻辑
├── Admin.Designer.cs       // 管理端界面设计
├── addSeatForm.cs          // 新增座位窗口逻辑
├── addSeatForm.Designer.cs // 新增座位窗口设计
├── Classes.cs              // 数据模型类
├── Dll.cs                  // 与 C 语言动态库交互的封装
├── Encryption.cs           // 加密与解密工具类
├── Register.cs             // 注册窗口逻辑
├── Program.cs              // 程序入口
├── Readme.md               // 项目说明文档
└── ...                     // 其他文件
```

---

## 使用说明

### 1. 环境要求
- **操作系统**：Windows
- **开发工具**：Visual Studio 或 JetBrains Rider
- **依赖**：
    - .NET Framework 4.8 或更高版本
    - AntdUI
    - EPPlus
    - `libLRS.dll`（C 语言动态库）

### 2. 编译与运行
1. 克隆项目：
   ```bash
   git clone https://github.com/chenpuhao/XTULRS_CS_V2.git
   ```
2. 打开项目文件夹，使用开发工具加载解决方案。
3. 确保 `libLRS.dll` 位于可执行文件同目录下。
4. 编译并运行项目。

### 3. 使用流程
- **管理员登录**：进入管理端，管理座位、用户和预约记录。
- **普通用户注册**：通过注册窗口创建新用户。
- **预约操作**：用户登录后可通过系统预约座位。

---

## 主要改进

### 相较于第一代的变化
1. **UI 改进**：引入 AntdUI，界面更加现代化。
2. **功能增强**：增加了筛选、导入导出等功能。
3. **代码优化**：模块化设计，提升了代码可读性和可维护性。

---

## 贡献者

- 亡灵

---

## 许可证

本项目遵循 MIT 许可证。详细信息请参阅项目中的 `LICENSE` 文件。

---

## 联系方式

如有问题，请通过 GitHub 提交 Issue：[https://github.com/chenpuhao/XTULRS_CS_V2/issues](https://github.com/chenpuhao/XTULRS_CS_V2/issues)