   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5      H DHamburgerMenu, Version=0.1.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:HamburgerMenu;assembly=HamburgerMenuHamburgerMenu 5          WpfApp1.AdminSetPlace   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      FHamburgerMenu2clr-namespace:HamburgerMenu;assembly=HamburgerMenu  5        N� Title$  serviceperson��5      $	��975��6   $	��582��6)   .��5      �  J� RenderTransformOrigin$ 0.495,0.521&�6   z�5   
   V� 5      .~�5      ��  �� ScaleY$ 1Q�6!    �� ScaleX$ 1Q�6,   �� 5       �� AngleY$ 0Q�6     �� AngleX$ 0Q�6+   �� 5       �� Angle$ 0Q�6"   T� 5      5       � RowDefinitions 5   
   �� 5      $	��29* �6   �� 5      $
��276* �6    � ColumnDefinitions 5   
   �� 5      $	��64* �6   �� 5      $
��263* �6   .+�5   
   �� -   5        	 ��Name$	 isaac_benhesed_249427_jpg��5      $��2��63   $��50,0,0,0q�6G   $��1��6Y   $��isaac-benhesed-249427.jpg��6f   $
��Fill=�6�   (  "MaterialDesignThemes.Wpf.ColorZone  5    
   $��16q�6#   
   Mode$
 PrimaryDark=�60   $��2��6C   $��58��6W   .��5!      ]� .+�5)      ��  �� Orientation$ 
Horizontal=�6   .+�5*      �� $��	430,0,0,0q�6    $��Center=�63   �� 6O   $�Service office��6S   6l   5+      5,      5-      !  HamburgerMenu.HamburgerMenu  50   
   ���	#FF616161   MenuIconColor
 �����   SelectionIndicatorColor
 �����   MenuItemForeground
 �����$
��Left=�6�     51   
   ���	#FF616161
 �����
 �����
 �����$
��Left=�6�   $��2��6�      Content. 52      %  HamburgerMenu.HamburgerMenuItem  -   5           Text$ Service Place��52   /      SelectionCommand 6D   ��  �� ElementName$ this_��6s     53      -   5        $ Appointments��53   /   6C     54      -   5        $ 
My Profile��54   /   6B     55      -   5        $ Users��55   /   6<     56      -   5        $ About Us��56   /   6?   57      � 59   
   -   5         �Name$ ServiceGrid��59      $y�Visible=�6$   $��1��69   $��1��6I   .+�5:      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��5:      $
��Left=�6)   $	��267��6D   $��
52,109,0,0q�6Q   $	��Top=�6e   $	��548��6}      AutoGenerateColumns .     CanUserAddRows .  ��5;      �� *Place+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 5<      0  *System.Windows.Controls.DataGridTextColumn  5=      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6@   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *ID+6@     5>      $ Place��6N    6)   �� *AppointmentPlace+6N     5?      $
 Room��6B    6)   �� *Room+6B   5A      �� 5C      $��Service Place��6   $
��Bold"�6,   $��24(�6>   $
��Left=�6L   $��46��6g   $��	69,58,0,0q�6s   $	��Top=�6�   $	��185��6�   
����������	#FF7AA0956�   �� 5D      -	   5        $	��Add��5D      $
��Left=�6#   $��33��6>   $��111,407,0,0q�6J   $	��Top=�6_   $	��100��6w   6�   5E      � 5G   
   -
   5        $ addGrid��5G      $y�	Collapsed=�6    $��1��67   $��1��6G   .+�5H      �� $��Appointment Place:��6   $��14(�61   $
��Left=�6?   $��35��6Z   $��
67,146,0,0q�6f   $	��Top=�6z   $	��144��6�   �� 5I      $��Appointment Room:��6   $��14(�60   $
��Left=�6>   $��35��6Y   $��
67,211,0,0q�6e   $	��Top=�6y   $	��144��6�   �� 5J      -   5         ��Name$ 	placeMess��5J      $��Required field��6'   $y�	Collapsed=�6@   
���  ��$��12(�6h   $
��Left=�6v   $��35��6�   $��436,213,0,0q�6�   $	��Top=�6�   $	��144��6�   �� 5K      -   5        $ roomMess��5K      $��Required field��6&   $y�	Collapsed=�6?   
���  ��$��12(�6g   $
��Left=�6u   $��35��6�   $��436,148,0,0q�6�   $	��Top=�6�   $	��144��6�   �� 5N      -   5         ��Name$ placeBox��5N      $
��Left=�6(   $��14(�6C   $��35��6Q   $��216,140,0,0q�6]    �� TextWrapping$
 Wrap=�6r   $	��Top=�6�   $	��186��6�   �� 5O      -   5        $ roomBox��5O      $
��Left=�6'   $��14(�6B   $��35��6P   $��216,205,0,0q�6\   $
 Wrap=�6q   $	��Top=�6�   $	��186��6�   �� 5Q      $��Add Service Place��6   $��20(�60   $��1��6>   $
��Left=�6N   $��43��6i   $��	69,58,0,0q�6u   $��1��6�   $	��Top=�6�   $	��203��6�   �� 5R      -   5        $	��Add��5R      $
��Left=�6#   $��27��6>   $��271,287,0,0q�6J   $	��Top=�6_   $��97��6w   6�   �� 5S      -   5        $��Cancel��5S      $��16(�6%   
�������$
��Left=�6E   $��35��6`   $��133,284,0,0q�6l   $	��Top=�6�   $��59��6�   6�   �� 5T      -   5        $ duplicateMess��5T      $!��Service place already exist��6,   $y�	Collapsed=�6R   $��12(�6i   
���  ��$
��Left=�6�   $��35��6�   $��262,252,0,0q�6�   $	��Top=�6�   $	��117��6�   6�   5U      5V      5W      