   M S B A M L   `   `   `  ????H  DTextileStore2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:TextileStore.View.WindowsTextileStore.View.Windows  5   	   ,    &TextileStore.View.Windows.ClientWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   9local'clr-namespace:TextileStore.View.Windows     5   	     ? Title$  Окно клиента??5   	   $	??450??6   $	??930??6+   .??5	      ?  ? RowDefinitions 5
   
   ?? 5      $??50 ?6   ?? 5       ? ColumnDefinitions 5   
   ?? 5      $	??200 ?6   ?? 5      .+?5   
   ?? -   5         ??Name$ imgLogotype??5      $??0??6%   $??0??65   $??0 0 0 10q?6B   ?? 5   
   $??0??6   $??2??6!   $??Right=?62      emphasizing#??[  5      $??2??6;   ?? 5   
   -   5         ??Name$ 
tbFullName??5      $??Fullname??6(   $??Right=?68   $??1??6T   $??0 0 20 0q?5      $??15(?6&   ?? 5   
   $??0??6   $??1??6%   $??10q?62   .+?5      ?? -   5         ??Name$ btnProductList??5   .   $!??Список товаров??6   6F   5      ?? 5   
   -   5        $ 
btnSignOut??5    S   $??
Выйти??5      $??0??6!   $??1??61   $??30??6>   $	??100??6J   $
??Left=?5       $??Bottom=?6,   $??10q?6G   6g    ? 5"   
   -   5          ?Name$ 	mainFrame??5"       $??1??6   $??1??63     ? NavigationUIVisibility$ Hidden=?6@   5#      5$      