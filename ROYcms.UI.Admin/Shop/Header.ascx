﻿<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="ROYcms.UI.Admin.Shop.Header" %>
<div class="header">
  <div class="header_inner">
    <h1 class="logo"> <a title="ROYcms开源cms" href="/">ROYcms开源cms</a> </h1>
    <ul class="nav">
      <li><a href="/index.html">首页</a></li>
       <li><a href="/index.html">团购</a></li>
      <li><a href="/news.html">礼品行业</a></li>
      <li><a href="/shop/index.aspx">礼品商城</a></li>
      <li><a href="/share.html">良品分享</a></li>
      <li><a href="/down.html">壁纸下载</a></li>
    </ul>
    <div class="search">
      <input id="keywords" name="keywords" class="input" type="text" x-webkit-speech="" autofocus="" placeholder="输入回车搜索" onkeydown="if(event.keyCode==13){SiteSearch('/search.html', '#keywords');return false};" />
      <input class="submit" type="submit" value="搜索" onclick="SiteSearch('search.html', '#keywords');" />
    </div>
    <ul class="menu">
      <li><a href="/shop/cart.aspx">购物车<%= ROYcms.Common.ShopCooksCar.GetProductCon() %>件</a></li>
      <li><a href="/ucenter/reg.aspx">注册</a></li>
      <li><a href="/ucenter/login.aspx">登录</a></li>
    </ul>
  </div>
</div>
