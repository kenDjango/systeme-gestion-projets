   M S B A M L   `   `   `  ����F  BSMInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SMInterfaceSMInterface  5   	       SMInterface.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:SMInterface     5   	   b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   $	��600��5      $
��1080��6'   
�������  � 
ResizeMode$  NoResize=�6G    � WindowStartupLocation$ CenterScreen=�6]   
�������$��Regular"�5
   	   $��13(�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Ideal=�5   	      TextRenderingMode$
 Auto=�5   	      MaterialDesignPaper#���   5   	   $��Calibri)�5   	    � Title$ 
MainWindow��5   	    � 	Resources 5        OpenMenu �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value  	CloseMenu��%�  &	       &	 �     �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5        $ 0��6'   $	 70Q�63     5      $ 0:0:0.5��6'   $		 200Q�69   5      5      �� 5   
   .��5      U� $ (FrameworkElement.Width)�6,   $ GridMenu��6a   .\�5         $ 0��6'   $		 200Q�63     5!      $ 0:0:0.5��6'   $	 70Q�69   5"      5#      5$      
 � Triggers
 5%      :� 5&   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ ButtonOpenMenu��66   .[�5'      �� #��[ 6   5(      :� 5)   
   $ ButtonBase.Click��6   $ ButtonCloseMenu��66   .[�5*      �� #��[ 6   5+      .��5.      � ���#1c1c1c.+�5/   
   � -   5         �Name$ GridMain��5/      $��Right=�6!   $��Bottom=�6=   $	��506��6X   $	��999��6e   � 51   
   $��60��6   $	��Top=�6   ���#3b3b3b J� Effect 52      3  -System.Windows.Media.Effects.DropShadowEffect  53         
BlurRadius$ 1Q�6#      ShadowDepth$ 1Q�62      Color$ 	#FFACACAC��6B   .+�56      ��  �� Orientation$ 
Horizontal=�6   $��Right=�62   .+�57      �� $��
Guest User��6   $��Center=�6.   $��16(�6I   '  !MaterialDesignThemes.Wpf.PopupBox  58         PlacementMode$ BottomAndAlignRightEdges=�6*      	StaysOpen .  $��10q�6e      PopupContent. 59      �� $	��150��6!   .+�5:      �� -   5        $��Close��5:   7   �� 5;      $��Settings��6!   �� 5<      $��Account��6!   �� 5=      $
��Help��6!   �� 5>      �� 5?      -   5        $��Log in��5?   4   5@      5A      5B      �� 5C      $��Center=�6   $��Center=�66   $��22(�6Q   Project Manager6p   5D      � 5F   
   -   5        $ GridMenu��5F      $��70��6!   $
��Left=�6,   ���#3b3b3b 5G        5H      $ 2Q�6#   $ 1Q�62   $ 	#FFAEAEAE��6B   .+�5J      �� .+�5K      � $	��150��6   ���#3b3b3b J� RenderTransformOrigin$ 0.5,0.5&�69   z�5L      V� 5M      .~�5N      �� �� 5O      �� 5P      T� 5Q      5R      .+�5T      �� -   5         ��Name$ ButtonOpenMenu��5T      $��60��65   $��60��6A   $��5q�6L   $��Right=�6W   $	��Top=�6s    0 ,MaterialDesignFloatingActionMiniAccentButton#��[ 6�   
���������6�   Z� ��6�   Z� .��5U      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$
 Menu=�62   $��25��6>   $��25��6I   5V      �� 5W      -   5        $ ButtonCloseMenu��5W      $y�	Collapsed=�66   $��60��6M   $��60��6Y   $��5q�6d   $��Right=�6o   $	��Top=�6�   #��[ 6�   ���	#FF31577E��6�   Z� ��6�   Z� .��5X        $ 	ArrowLeft=�62   $��25��6C   $��25��6N   5Y      �� 5[      $��80��6   $��Bottom=�6(   5\      �� 5]      -   5         ��Name$ ListViewMenu��5]      
�������$��Disabled=�6D   .@�5^      �� -   5         ��Name$ ItemProjects��5^   #   $��60��69   .��5_      �� $ 
Horizontal=�6%   .+�5`        $
 Apps=�66   $��25��6B   $��25��6N   $��10q�6Y   �� 5a      $��My Projects��6(   $��Center=�6;   $��20 10q�6V   5b      5c      �� 5d      -	   5        $ 	ItemBoard��5d   #   $��60��66   .��5e      �� $ 
Horizontal=�6%   .+�5f        $ DeveloperBoard=�66   $��25��6L   $��25��6X   $��10q�6c   �� 5g      $��Board��6(   $��Center=�65   $��20 10q�6P   5h      5i      �� 5j      -
   5        $ 
ItemCreate��5j   #   $��60��67   .��5k      �� $ 
Horizontal=�6%   .+�5l        $ Sticker=�66   $��25��6E   $��25��6Q   $��10q�6\   �� 5m      $��Create ticket��6(   $��Center=�6=   $��20 10q�6Y   5n      5o      �� 5p      -   5        $ ItemSettings��5p   #   $��60��69   .��5q      �� $ 
Horizontal=�6%   .+�5r        $ Settings=�66   $��25��6F   $��25��6R   $��10q�6]   �� 5s      $��Project Settings��6(   $��Center=�6@   $��20 10q�6\   5t      5u      5v      5w      5x      5y      5z      