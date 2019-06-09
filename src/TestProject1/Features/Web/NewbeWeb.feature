Feature: 使用必应搜索Newbe相关的内容

  Background:
    Given 打开必应首页 "https://cn.bing.com/"

  @NewbeDemo
  Scenario: 使用必应搜索 newbe
    When 搜索框输入内容 "newbe"
    When 点击搜索按钮
    Then 出现在必应搜索第一条的标题是 "Newbe"