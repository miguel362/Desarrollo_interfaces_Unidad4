   M S B A M L   `   `   `  ????H  DP4_Ejercicio2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:P4_Ejercicio2P4_Ejercicio2  5   	       P4_Ejercicio2.MainWindow   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:P4_Ejercicio2     5   	   T PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3f;Controls,http://metro.mahapps.com/winfx/xaml/controls  5   	   _ [MaterialDesignThemes.Wpf, Version=4.6.1.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	     ? Title$  Configuración??5	   	   $	??650??6   $
??1000??6,   (  "MahApps.Metro.Controls.MetroWindow   ShowTitleBar$ False??69      ShowCloseButton$ False??6N      ShowMaxRestoreButton$ False??6f      ShowMinButton$ False??6?      MaterialDesignBody#???   5   	   $??Regular"?5   	   $??13(?5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=?5   	      TextRenderingMode$
 Auto=?5   	     MaterialDesignPaper#???  5   	     MaterialDesignFont#???  5   	   .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $??* ?6   ?? 5      $??2* ?6   .+?5   
   ?? $??imagenes/OIP.jfif??6   $
??Fill=?6+   ?? 5   
   $??1??6   
???????._?5      ? $??1??6    5      ?? 5      $	??350 ?6'   ?? 5      $??* ?6'    ? RowDefinitions 5      ?? 5      $	??150 ?6$   ?? 5       $	??200 ?6$   ?? 5!      $??* ?6$   .+?5#      ?? -   5        $??
ch_pintura??5#      $!??Pintura Metalizada(2000€)??6-   $
??Bold"?6Q   $??Center=?6c   $??Center=?6?   $??	0,0,70,50q?6?   $??20(?6?   ?? 5$      -   5        $??ch_lunas??5$   +   $??1??6   $??Lunas tintadas(1200€)??6;   $
??Bold"?6[   $??Center=?6m   $??Center=?6?   $??	0,90,50,0q?6?   $??20(?6?   ?? 5%      -   5        $??ch_remolque??5%   (   $??1??6   $(??"Accesorios para remolque (1000€)??6;   $
??Bold"?6f   $??Center=?6x   $??Center=?6?   $??	0,0,0,100q?6?   $??20(?6?   ?? 5&      -   5        $??ch_seguridad??5&   8   $??1??6   $??1??6(   $ ??Pack de seguridad(6000€)??6L   $
??Bold"?6o   $??Center=?6?   $??	0,20,20,0q?6?   $??Center=?6?   $??20(?6?   6?   ?? 5'      -   5        $??	ch_airbag??5'   8   $??1??6   $??1??6(   $??	7 airbags??6I   $??Center=?6]   $??Center=?6z   $??
0,70,122,0q?6?   $??14(?6?   6?   ?? 5(      -   5        $??ch_colision??5(   8   $??1??6   $??1??6(   $??Detector de colisión??6K   $??Center=?6j   $??Center=?6?   $??
0,110,55,0q?6?   $??14(?6?   6?   ?? 5)      -   5        $??	ch_carril??5)   8   $??1??6   $??1??6(   $"??Detector de cambio de carril??6I   $??Center=?6p   $??Center=?6?   $??18,150,22,0q?6?   $??14(?6?   	 J? RenderTransformOrigin$	 0.201,0.623&?6?   6
  ?? 5*      -   5        $??	ch_deluxe??5*   (   $??2??6   $??Pack deluxe(5500€)??69   $
??Bold"?6V   $??Center=?6h   $??0,0,135,230q?6?   $??Center=?6?   $??20(?6?   6?   ?? 5+      -	   5        $??	ch_espejo??5+   (   $??2??6   $)??#Espejos del color de la carrocería??69   $??Center=?6f   $??Center=?6?   $??
0,0,35,170q?6?   $??14(?6?   6?   ?? 5,      -
   5        $??
ch_llantas??5,   (   $??2??6   $??Llantas de perfil bajo??6:   $??Center=?6[   $??Center=?6x   $??0,0,109,120q?6?   $??14(?6?   6?   ?? 5-      -   5        
 ??Name$
 
btn_config??5-   &   $??2??6   $??Finalizar configuración??6:   $??Center=?6\   $??	0,120,0,0q?6y   $??Center=?6?   $??2??6?   $??50??6?   $??30(?6?   
?????p?6?   5.      5/      50      51      