   M S B A M L   `   `   `  ????H  DP4_ejercicio3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:P4_ejercicio3P4_ejercicio3  5   	       P4_ejercicio3.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:P4_ejercicio3     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	     ? Title$  Mostrador de vehículos??5	   	   $	??450??6(   $	??800??65   (  "MahApps.Metro.Controls.MetroWindow   ShowCloseButton$ False??6A      ShowTitleBar$ False??6Y      ShowMinButton$ False??6n      ShowMaxRestoreButton$ False??6?      MaterialDesignBody#???   5   	   $??Regular"?5   	   $??13(?5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5   	      TextRenderingMode$
 Auto=?5   	     MaterialDesignPaper#???  5   	     MaterialDesignFont#???  5   	   .??5      ?? 
???????._?5   
   ?  ? ColumnDefinitions 5      ?? 5      $??* ?6#   ?? 5      $??* ?6#    ? RowDefinitions 5      ?? 5      $??75 ?6    ?? 5      $??* ?6    .+?5      ?? -   5        	 ??Name$	 	im_imagen??5   1   $??1??6   $??1??6!   $??Center=?6D   ?? 5      -   5        
 ??Name$
 	tx_titulo??5      $$??Mostrador de Vehículos Toyota??6+   $??2??6P   $??Center=?6d   $??40(?6?   $
??Bold"?6?   
???**??$??50??6?   ?? 5      $??1??6   $??45??6%   $??50??60   $??	220,0,0,0q?6<    / +MaterialDesignFloatingActionMiniLightButton#??[ 6O    ? Cursor$ Arrow??6?   .??5      ?? $??Center=?6   $??Center=?65   $??imagenes/logo.png??6Q   $
??Fill=?6l   5       ? 5!      $??1??6    5"      ?? 5#      $??* ?6$   ?? 5$      $??* ?6$   ?? 5%      $??* ?6$   .+?5'      ?? -   5         ??Name$ cb_motor??5'       ?? Text$ Motor??6-    ?? 
IsEditable$
 True??6:    ?? 
IsReadOnly$
 True??6L   $	??200??6^   $??25??6j   .@?5(      ?? $??Combustión??6#   ?? 5)      $??Híbrido??6#   ?? 5*      $??
Eléctrico??6#   5+      ?? 5,      -   5        $ cb_tipo??5,   (   $??1??6   $ Tipos de vehículo??69   $
 True??6R   $
 True??6d   $	??200??6v   $??25??6?   ${?False??6?   6?   ?? 5-      -   5        $ 
cb_modelos??5-   (   $??2??6   $ Modelo??6<   $
 True??6J   $
 True??6\   $	??200??6n   $??25??6z   ${?False??6?   5.      5/      50      51      