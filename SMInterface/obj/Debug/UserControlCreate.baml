   M S B A M L   `   `   `  ����F  BSMInterface, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SMInterfaceSMInterface  5      #    SMInterface.UserControlCreate   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SMInterface     5      b ^MaterialDesignThemes.Wpf, Version=3.2.0.1979, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      .��5      )  #MaterialDesignThemes.Wpf.DialogHost  -   5           Name$  createDialog��5          MaterialDesignDivider#���   66      DialogContent 5   
   � 5      $	��300��6   $	��150��6   $��Center=�6,   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��15q�66   .+�5      '  !MaterialDesignThemes.Wpf.PackIcon  -   5          Name$
 icon��5   .      Kind$ Error=�6<     PrimaryHueMidBrush#��[ 6I   $��50��6z   $��50��6�   �� 5      -   5         ��Name$ success��5       
�������$	��200��6C   $
��15 5q�6O   $
��Wrap=�6]    Ticket created with no failure5      �� 5      -   5        $ failure��5       $y�Hidden=�61   
�������$	��200��6W   $
��15 5q�6c   $
��Wrap=�6q    Ticket created with no failure5      5      �� 5      $ 
Horizontal=�6   $��Right=�66   $��Bottom=�6R   $��15q�6m   .+�5      ��    CloseDialogCommand#��Z 6     MaterialDesignFlatButton#���  6_   $��4q�6�   $��Center=�6�   .��6�   Close5      5      5      .��5   
   � .+�5       � $	��600��6   $	��300��6   $��Center=�6,    � RowDefinitions 5!      �� 5"      $��10 �6$   �� 5#      �� 5$      $��40 �6$   �� 5%      $��10 �6$   .+�5(      � $
��10,0q�6   $��1��6%   .+�5)      �� -   5         ��Name$ ticketTitle��5)      
�������	 �� TextWrapping$
	 Wrap=�6F   $��Ticket Title��6Z   $��0,0,130,212q�6n   �� 5*      -   5        $ ticketDescription��5*      
�������$
	 Wrap=�6K   $��Ticket Description��6_   $��0,28,130,10q�6y   �� 5+      -   5        
 ��Name$
 comboxState��5+      $��Right=�64   $	��Top=�6P   $	��100��6h   .@�5,      ��  �� 
IsSelected . .��69   TODO6?   �� 5-      .��6'   WIP6,   �� 5.      .��6'   DONE6-   5/      50      � 52      $
��10,0q�6   $��2��6%   .+�53      �� $
��Left=�6!   $ 
Horizontal=�6<   .+�54      �� 
���   �.��63   Created by:6@   �� 55      
���������62   �� *CurrentUser.Username+6]   �� 57      $��10��6$   $y�Hidden=�6/   6E   �� 59      
���   �$��Owner:��63   �� 5:      
���������62   �� *CurrentUser.Username+5;      �� 5<      -   5        $��Center=�5<   3   $��Right=�6N   .��6j   Create5>      5?      5@      5A      5B      5C      