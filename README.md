# 🐱 NekoGirl-猫娘下载器，随机获取猫娘

一个轻量级的 Windows 桌面应用程序，用于浏览和收藏来自 [nekos.best](https://nekos.best/) 的随机猫娘图片。

## ✨ 功能特性

* **🎲 随机浏览** - 每次加载获取随机猫娘图片，带来惊喜
* **📖 流畅翻页** - 支持上/下浏览，自动预加载
* **💾 一键保存** - 将喜欢的图片保存到本地，自动创建目录
* **📁 快速查看** - 一键打开保存目录，方便管理收藏
* **⚡ 异步加载** - 网络请求不阻塞 UI，体验流畅
* **🔍 随意放大** - 支持拖拽窗口随意放大

🖼️ 界面预览（win10）
--------

![04a59164-3218-4fd4-85d2-c922dafadfdb.png](https://picui.ogmua.cn/s1/2026/02/24/699dc229ed3ad.webp)

## 🔧 技术实现

### 架构概览

    NekoGirl/
    ├── NekoGirl.e             # 图片获取核心逻辑
    │                          # 主窗体，处理 UI 交互
    │
    └── README.md              # 本文档

### 技术栈

| 组件      | 技术选型            |
| --------- | ------------------  |
| HTTP 请求 | WinApi:GetHttpFile  |
|  获取链接  | WinApi:InStr&mid&len|

📄 许可证
------

本项目采用 MIT 许可证 - 详见 [LICENSE](https://chatglm.cn/main/LICENSE) 文件

🙏 致谢
-----

* 图片来源：[nekos.best](https://nekos.best/)

* 贡献值：
  
  <a href="https://github.com/YUZU384/NekoGirl/graphs/contributors">
    <img src="https://contrib.rocks/image?repo=YUZU384/NekoGirl" />
  </a>
