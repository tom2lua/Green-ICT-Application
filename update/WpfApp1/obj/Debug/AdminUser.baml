   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5      H DHamburgerMenu, Version=0.1.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:HamburgerMenu;assembly=HamburgerMenuHamburgerMenu 5          WpfApp1.AdminUser   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      FHamburgerMenu2clr-namespace:HamburgerMenu;assembly=HamburgerMenu  5        N� Title$  ClientBooking��5
       N� 
Background �#F8F0FB$	��582��62   $	��975��6?   .��5      �  J� RenderTransformOrigin$ 0.495,0.521&�6   z�5   
   V� 5      .~�5      ��  �� ScaleY$ 1Q�6!    �� ScaleX$ 1Q�6,   �� 5       �� AngleY$ 0Q�6     �� AngleX$ 0Q�6+   �� 5       �� Angle$ 0Q�6"   T� 5      5       � RowDefinitions 5   
   �� 5      $	��29* �6   �� 5      $
��276* �6   	 � ColumnDefinitions	 5   
   �� 5      $	��64* �6   �� 5      $
��263* �6   .+�5   
   �� -   5        
 ��Name$
 isaac_benhesed_249427_jpg��5      $��2��63   $��50,0,0,0q�6G   $��1��6Y   $��isaac-benhesed-249427.jpg��6f   $
��Fill=�6�   (  "MaterialDesignThemes.Wpf.ColorZone  5   
   $��16q�6#      Mode$ PrimaryDark=�60   $��2��6C   $��58��6W   .��5      ]� .+�5       ��  �� Orientation$ 
Horizontal=�6   .+�5!      �� $��	430,0,0,0q�6    $��Center=�63   �� 6O   $�Booking office��6S   6l   5"      5#      5$      !  HamburgerMenu.HamburgerMenu  5'   
   ���	#FF616161   MenuIconColor
 �����   SelectionIndicatorColor
 �����   MenuItemForeground
 �����$
��Left=�6�     5(   
   ���	#FF616161
 �����
 �����
 �����$
��Left=�6�   $��2��6�      Content. 5)      %  HamburgerMenu.HamburgerMenuItem  -   5           Text$ Users��5)   /      SelectionCommand 6<   ��  �� ElementName$ this_��6k     5*      -   5        $ Appointments��5*   /   6C     5+      -   5        $ 
My Profile��5+   /   6A     5,      -   5        $ Service Place��5,   /   6D     5-      -   5        $ About Us��5-   /   6?   5.      � 51   
   -   5         �Name$ userGrid��51   $   $y�Visible=�6   $��1��66   $��1��6F   .+�52      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��52      $
��Left=�6)   $	��345��6D   $��	10,76,0,0q�6Q   $	��Top=�6d   $	��744��6|      AutoGenerateColumns .     CanUserAddRows .  ��53      �� *Users+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6@   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *ID+6@     56      $ 	Real Name��6F    6)   �� *
RealName+6F     57      $ 	User Name��6F    6)   �� *
UserName+6F     58      $ Email��6C    6)   �� *Email+6C     59      $ Password��6F    6)   �� *
Password+6F     5:      $
 Role��6B    6)   �� *Role+6B   4  .System.Windows.Controls.DataGridTemplateColumn  5<      $ Select��6-      CellTemplate 5=      �� 5>      .R�5?   "   	� $��Center=�6.    	� 	GroupName$
 Test��6K    d� 	IsChecked 6\   �� *	Checker+$ PropertyChanged=� �� Mode$ TwoWay=�5@      5B      5D      �� 5F      $��Users��6   $��22(�6$   $
��Left=�62   $��43��6M   $��	35,27,0,0q�6Y   $	��Top=�6l   $��73��6�   �� 5G      -	   5          ��Name$  ChangeRoleButton��5G      $y�Visible=�6/   $��Change Role��6D   $
��Left=�6Z   $��34��6u   $��136,468,0,0q�6�   $	��Top=�6�   $	��134��6�   6�   �� 5H      -
   5        $  DeleteBUtton��5H      $y�Visible=�6+   $��Delete user��6@   $
��Left=�6V   $��34��6q   $��377,468,0,0q�6}   $	��Top=�6�   $	��134��6�   6�   �� 5I      -   5        ! ��Name$! adminRightMess��5I      $%��Admin Users cannot be editted!!��6,   $y�	Collapsed=�6V   $��12(�6m   $
��Left=�6{   
���  ��$��30��6�   $��136,433,0,0q�6�   $	��Top=�6�   $	��183��6�   �� 5L      -   5        $! deleteWarningMess��5L      $L��FAre you sure you want to delete this user? this action cannot be undo.��6/   $y�	Collapsed=�6�   $��12(�6�   $
��Left=�6�   
���  ��$��30��6�   $��136,433,0,0q�6�   $	��Top=�6�   $	��389��6
  �� 5M      -   5        $! noUserSelectedMess��5M      $��Please choose a user!��60   $y�	Collapsed=�6P   $��12(�6g   $
��Left=�6u   
���   �$��30��6�   $��136,433,0,0q�6�   $	��Top=�6�   $	��389��6�   �� 5N      -   5        $  DeleteConfirmButton��5N      $y�	Collapsed=�62   $��Confirm��6I   $
��Left=�6[   $��34��6v   $��136,468,0,0q�6�   $	��Top=�6�   $	��134��6�   6�   �� 5O      -   5        $  DeleteCancelButton��5O      $y�	Collapsed=�61   $��Cancel��6H   $
��Left=�6Y   $��34��6t   $��377,468,0,0q�6�   $	��Top=�6�   $	��134��6�   6�   5P      � 5R   
   -   5        $ ChangeRoleGrid��5R      $y�	Collapsed=�6'   $��1��6>   $��1��6N   .+�5S      �� $��24(�6   $��Change user role��6"   $
��Left=�6=   $��44��6X   $��
121,76,0,0q�6d   $	��Top=�6x   $	��203��6�   �� 5U      $��121,156,647,355q�6   $��account-circle.png��6-   $
��Fill=�6I   $ -2.273,1.238&�6X   $��16��6}   �� 5V      $��14(�6   $��	Username:��6"   $
��Left=�66   $��33��6Q   $��147,149,0,0q�6]   $	��Top=�6r   $��87��6�   �� 5W      -   5        " ��Name$" userNameBox��5W      # �� 
IsReadOnly# . $��14(�6=   $
��Left=�6K   $��33��6f   $��234,139,0,0q�6r   $ �� TextWrapping$
$ Wrap=�6�   $	��Top=�6�   $	��173��6�   �� 5Y      $��14(�6   $��Role:��6"   $
��Left=�62   $��33��6M   $��147,216,0,0q�6Y   $	��Top=�6n   $��87��6�   �� 5Z      -   5        % ��Name$% roleSelectBox��5Z      $
��Left=�6.   $��234,216,0,281q�6�   $	��173��6�   $ 0.5,0.5&�6�   -	  'MaterialDesignThemes.Wpf.ComboBoxAssist& 	  ClassicMode& 6I   �� *	IsChecked+$ ClassicModeCheckBox��.@�5[      �� -   5        ' ��Name$' serviceCombo��5[      $��Service Person��65   �� 5\      -   5        $' clientCombo��5\      $��Client��64   �� 5]      -   5        $' 
adminCombo��5]      $��Admin��63   5^      �� 5`      -   5        $��Confirm��5`      $
��Left=�6'   $��31��6B   $��273,287,0,0q�6N   $	��Top=�6c   $	��115��6{   6�   �� 5a      -   5        $��15(�5a      
�������$��Cancel��64   $
��Left=�6E   $��33��6`   $��161,285,0,0q�6l   $	��Top=�6�   $��73��6�   6�   �� 5b      $��121,224,647,287q�6   $��account-convert.png��6-   $
��Fill=�6J   $ 0.5,0.5&�6Y   $��16��6y   $��16��6�   5c      5e      5f      