   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5      H DHamburgerMenu, Version=0.1.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:HamburgerMenu;assembly=HamburgerMenuHamburgerMenu 5          WpfApp1.ClientAppointment   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      FHamburgerMenu2clr-namespace:HamburgerMenu;assembly=HamburgerMenu  5        N� Title$  ClientBooking��5
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
��Left=�6�   $��2��6�      Content. 5)      %  HamburgerMenu.HamburgerMenuItem  -   5           Text$ My appointment��5)   .      SelectionCommand 6D   ��  �� ElementName$ this_��6s     5*      -   5        $ Booking��5*   .   6=     5+      -   5        $ 
My Profile��5+   .   6@     5,      -   5        $ About Us��5,   .   6>   5-      � 5/   
   -   5         �Name$ appointmentGrid��5/      $��1��6(   $��1��68   .+�50      &   System.Windows.Controls.DataGrid  -   5          Name$ dataGrid��50      $
��Left=�6)   $	��325��6D   $��	0,109,0,0q�6Q   $	��Top=�6d   $	��751��6|      AutoGenerateColumns .     CanUserAddRows .  ��51      �� *Appointment+ �� UpdateSourceTrigger$ PropertyChanged=�   Columns 52      0  *System.Windows.Controls.DataGridTextColumn  53      ,  &System.Windows.Controls.DataGridColumn   Header$ ID��6@      
FontWeight$
 Bold"�6L   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6)   �� *ID+6L     54      $ Category��6I   $
 Bold"�6[    6)   �� *ProductName+6[     55      $ Service Person��6K   $
 Bold"�6c    6)   �� *ServicePerson+6c     56      $ Place��6C   $
 Bold"�6R    6)   �� *Place+6R     57      $
 Date��6B   $
 Bold"�6P    6)   �� *Date+6P     58      $ 	Time Slot��6G   $
 Bold"�6Z    6)   �� *	StartTime+6Z   4  .System.Windows.Controls.DataGridTemplateColumn  5:      $ Select��6-      CellTemplate 5;      �� 5<      .R�5=   "   	� $��Center=�6.    	� 	GroupName$
 Test��6K    d� 	IsChecked 6\   �� *
IsSelected+$ PropertyChanged=�  �� Mode$  TwoWay=�5>      5@      5B      �� 5D      -   5        ! ��Name$! cancelButton��5D      $y�Visible=�6+   $��Cancel��6@   $
��Left=�6Q   $��30��6l   $��304,468,0,0q�6x   $	��Top=�6�   $	��100��6�   6�   �� 5G      -	   5        $! cancelcancelButton��5G      $y�	Collapsed=�61   $��Cancel��6H   $
��Left=�6Y   $��30��6t   $��122,468,0,0q�6�   $	��Top=�6�   $	��134��6�   6�   �� 5H      -
   5        $! confirmCancelButton��5H      $y�	Collapsed=�62   $��Confirm��6I   $
��Left=�6[   $��30��6v   $��392,468,0,0q�6�   $	��Top=�6�   $	��144��6�   6�   �� 5J      -   5        " ��Name$" noappointmentMess��5J      $y�	Collapsed=�6/   $��No appointment selected!��6F   
���  ��$��14(�6z   $
��Left=�6�   $��31��6�   $��100,441,0,0q�6�   $	��Top=�6�   $	��179��6�   �� 5K      -   5        $" warningMess��5K      $y�	Collapsed=�6)   $P��JDo you really want to cancel the appointment? This action can not be undo.��6@   
���  ��$��14(�6�   $
��Left=�6�   $��31��6�   $��100,441,0,0q�6�   $	��Top=�6�   $	��479��6  5M      �� 5O   
   $��My Appointment��6   $
��Bold"�6)   $��20(�6;   $��1��6I   $
��Left=�6Y   $��43��6t   $��	35,61,0,0q�6�   $��1��6�   $	��Top=�6�   $	��203��6�   ���	#FF7AA0956�   5P      5Q      