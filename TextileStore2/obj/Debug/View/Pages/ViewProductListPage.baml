   M S B A M L   `   `   `  ????H  DTextileStore2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:TextileStore2.View.PagesTextileStore2.View.Pages  5      2    ,TextileStore2.View.Pages.ViewProductListPage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:TextileStore2.View.Pages     5        N? Title$  ViewProductList??5	      .??5      ?  ? RowDefinitions 5   
   ?? 5      $??50 ?6   ?? 5       ? ColumnDefinitions 5   
   ?? 5      ?? 5      ?? 5      .+?5   
   ?? $??0??6   $??2??6"    ?? Orientation$ 
Horizontal=?62   .+?5      ?? $??
Найти??6   $??
10 10 10 0q?6%   ?? 5      -   5         ??Name$ tbFind??5      $	??150??6&   $??25??62   6>   5      ?? 5   
   $ 
Horizontal=?6   $??Right=?6.   $??0??6J   .+?5      ?? $'??!Отфильтровать по  ??6   $??0 10 0 0q?62   ?? 5      -   5         ??Name$ cbFilter??5   /   $	??100??6   $??25??6#   5      5      ?? 5!   
   $ 
Horizontal=?6   $??Right=?6.   $??1??6J   .+?5"      ?? $#??Сортировать по  ??6   $??0 10 0 0q?60   ?? 5#      -   5        $ 	cbOrderBy??5#   /   $	??100??6   $??25??6#   .@?5$      ?? $??убыванию??6   ?? 5%      $??возрастанию??6   5&      5'      ?? 5(   
   -   5         ??Name$ lvProductList??5(      $??1??6*   $??3??67   ??5)      ?? 5*      .R?5+      ?  5,      ?? 5-      $	??200 ?6/   ?? 5.      $	??400 ?6/   ?? 5/      .+?52      ?? $??0??6!   ??61   ?? *
BackGround+._?53      ?? $??
10 0 10 10q?6$   $
??Fill=?68   ??6G   ?? *	ImagePath+54      ?? 55      $??1??6!   ??61   ?? *
BackGround+._?56      ?? .+?57   "   ?? $
??Bold"?6I   ??6,   ?? *ProductName+6I   ?? 58   "   $
??Wrap=?6P   ??6,   ?? *ProductDescription+6P   ?? 59   "   ??6,   ?? *ProductManufacturer+?? 5:   "   ??6,   ?? *ProductCost+?? 5;   "   $?? ??6,   5<      5=      ?? 5>      $??2??6!   ??61   ?? *
BackGround+._?5?      ??  ?? TextAlignment$ Center=?6G   $??Center=?6^   ??6(   ?? *ProductStatus+6^   5@      5A      5B      5D      5E      5F      