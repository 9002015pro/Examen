   M S B A M L   `   `   `  ????A  =examen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:examenexamen  5   	       examen.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:examen     5   	     ? Title$  
MainWindow??5   	   $	??450??6   $	??800??6)    ? 	Resources 5	         defaultImage ?? 	UriSource??%<   &	        ?? 5
   
   $ .//Image/picture.png??5   	   5      .??5      ?  ? RowDefinitions 5   	   ?? 5      $
??auto ?6    ?? 5      ?? 5      $
??auto ?6     ? ColumnDefinitions 5      ?? 5      $	??200 ?6#   ?? 5      .+?5   
   ? $??0??6   $??1??6!   .+?5      ?? $??Сортировка??6   $
??Left=?6)   $	??Top=?6E   ?? 5      -   5        $??SortTypeComboBox??5   	    ?? SelectedIndex$ 0??5   	   $??Center=?5   	   $	??200??5   	   ??5    	   ?? *
SortList+?? 5!      $??Фильтрация??6   $
??Left=?6)   $	??Top=?6E   ?? 5#      $
??Left=?6   $	??Top=?62   $	??120??6J   ?? 5$      $??
Поиск??6   $
??Left=?6$   $	??Top=?6@   5&      ?? 5(   
   $??1??5)      $??1??5*      ??5+      ?? *ProductList+??5-      ?? 5.       ?? 
TargetType" ??5/      .?50      ??  ?? Property ? ?? ?? Value$ Stretch=?52      53      ??55      ?? 56      .R?57      ?? $??1q?58      
???   ?	 ?? CornerRadius$	 5??5:      ._?5;      ? $??10q?5<      $??Stretch=?5=       5?      ?? 5@   "   $??64 ?63   ?? 5A   "   $??* ?63   ?? 5B   "   $
??auto ?63   .+?5D      ?? $??64??5E      $??64??5F      ??5G      ?? *ImagePreview+
 ?? TargetNullValue#
 [  ?? 5I      $??1??5J      $??5q?5K       ?? Orientation$ Vertical=?5L      .+?5N   "   ?? ??5O   	   ?? *Name+?? 5Q   "   ??5R   	   ?? *Manufacturer+?? 5T   "   ??5U   	   ?? *Price+5V      5W      5Z      5[      5^      5`      5a      