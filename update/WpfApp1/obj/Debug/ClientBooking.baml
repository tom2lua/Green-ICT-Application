   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5      H DHamburgerMenu, Version=0.1.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:HamburgerMenu;assembly=HamburgerMenuHamburgerMenu 5          WpfApp1.ClientBooking   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      FHamburgerMenu2clr-namespace:HamburgerMenu;assembly=HamburgerMenu  5        N� Title$  ClientBooking��5
       N� 
Background �#F8F0FB$	��582��62   $	��975��6?    � 	Resources 5         ItemCollectionViewSource �� CollectionViewType��%"   &	        �� 5   
   " ��6A   5      .��5      �  J� RenderTransformOrigin$ 0.495,0.521&�6   z�5   
   V� 5      .~�5      ��  �� ScaleY$ 1Q�6!    �� ScaleX$ 1Q�6,   �� 5       �� AngleY$ 0Q�6     �� AngleX$ 0Q�6+   �� 5      	 �� Angle$	 0Q�6"   T� 5      5      
 � RowDefinitions
 5   
   �� 5      $	��29* �6   �� 5      $
��276* �6    � ColumnDefinitions 5   
   �� 5      $	��64* �6   �� 5      $
��263* �6   .+�5!   
   �� -   5         ��Name$ isaac_benhesed_249427_jpg��5!      $��2��63   $��50,0,0,0q�6G   $��1��6Y   $��isaac-benhesed-249427.jpg��6f   $
��Fill=�6�   (  "MaterialDesignThemes.Wpf.ColorZone  5"   
   $��16q�6#      Mode$ PrimaryDark=�60   $��2��6C   $��58��6W   .��5#      ]� .+�5$      ��  �� Orientation$ 
Horizontal=�6   .+�5%      �� $��	430,0,0,0q�6    $��Center=�63   �� 6O   $�Booking office��6S   6l   5&      5'      5(      !  HamburgerMenu.HamburgerMenu  5+   
   ���	#FF616161   MenuIconColor
 �����   SelectionIndicatorColor
 �����   MenuItemForeground
 �����$
��Left=�6�     5,   
   ���	#FF616161
 �����
 �����
 �����$
��Left=�6�   $��2��6�      Content. 5-      %  HamburgerMenu.HamburgerMenuItem  -   5           Text$ Booking��5-   .      SelectionCommand 6=   ��  �� ElementName$ this_��6l     5.      -   5        $ My appointment��5.   .   6D     5/      -   5        $ 
My Profile��5/   .   6@     50      -   5        $ About Us��50   .   6>   51      � 54   
   -   5         �Name$ productGrid��54      $y�	Collapsed=�6$   $��1��6T   $��1��6d   .+�56      �� -   5         ��Name$ 
placeLabel��56      $��Place:��6(   $
��Left=�69   $��109,261,0,0q�6T   $	��Top=�6i   $��42��6�   $��98��6�   �� 57      -   5        $ catalogLabel��57      $��Catalog:��6*   $
��Left=�6=   $��109,194,0,0q�6X   $	��Top=�6m   $��42��6�   $��98��6�   �� 58      -	   5        $ personLabel��58      $��Service person:��6)   $
��Left=�6C   $��109,128,0,0q�6^   $	��Top=�6s   $��42��6�   $��98��6�   �� 59      -
   5        $ durationLabel1��59      $��	Duration:��6,   $
��Left=�6@   $��109,318,0,0q�6[   $	��Top=�6p   $��42��6�   $��98��6�   �� 5:      -   5        $ durationLabel��5:      $�� ��6+   $
��Left=�66   $��233,318,0,0q�6Q   $	��Top=�6f   $��28��6~   $	��120��6�   $ 0.5,0.5&�6�   �� 5=      -   5         ��Name$ nameBox��5=   =   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$
 Name��6N    & "MaterialDesignFloatingHintComboBox#��[ 6t   $��233,115,389,370q�6�   $��Stretch=�6
  ��6   �� *servicePerson+6
  �� 5>      -   5        $ 
productBox��5>      $ Product��6,   #��[ 6U   $��233,181,389,304q�6�   $��Stretch=�6�   �� 5?      -   5        $ placeBox��5?      $ Place��6)   #��[ 6P   $��233,248,389,237q�6�   $��Stretch=�6�   �� 5@      -   5         ��Name$ contiButton��5@      $��Continue��6*   $
��Left=�6=   $��248,398,0,0q�6X   $	��Top=�6m   $	��105��6�   ���	#FF303030���	#FFF8F0FB���	#FF3030306�   �� 5B      -   5        $ nameMess��5B      $y�	Collapsed=�6&   $��Field required!��6=   
���  ��$
��Left=�6h   $��421,115,0,0q�6�   $	��Top=�6�   $��42��6�   $��98��6�   �� 5C      -   5        $ productMess��5C      $y�	Collapsed=�6)   $��Field required!��6@   
���  ��$
��Left=�6k   $��421,181,0,0q�6�   $	��Top=�6�   $��42��6�   $��98��6�   �� 5D      -   5        $ 	placeMess��5D      $y�	Collapsed=�6'   $��Field required!��6>   
���  ��$
��Left=�6i   $��421,248,0,0q�6�   $	��Top=�6�   $��42��6�   $��98��6�   5E      � 5H   
   -   5        $ dateTimeGrid��5H   $   $y�Visible=�6   $
��Left=�6:   $	��527��6U   $	��Top=�6b   $	��784��6z   $��1��6�   $��1��6�   .+�5I      �� -   5        $ dateMess��5I   ,   $y�	Collapsed=�6   $��Date not available!!��6>   
���  ��$��12(�6n   $
��Left=�6|   $��
37,119,0,0q�6�   $	��Top=�6�   �� 5J      -   5        $ 	back_icon��5J      $��1��6'   $��10,10,732,475q�67   $��1��6N   $��back-logo-icon-27727.png��6[   $
��Fill=�6}   6�   (  "System.Windows.Controls.DatePicker  5K      -   5          Name$ calendar��5K      $��14(�6+   $	��196��69   $��57,100,0,390q�6E   $
��Left=�6[   $ Pick a Date��6�    ( $MaterialDesignFloatingHintDatePicker#��[ 6�   �� 5L      $y�Visible=�6   $9��3Pick your time, each time slot lasts for 15 minutes��6)   
���   �$��14(�6z   $
��Left=�6�   $��
50,171,0,0q�6�   $	��Top=�6�   �� 5M      -   5        $ 
timeSubmit��5M      $
��Book��6)   $
��Left=�68   $��185,461,0,0q�6S   $	��Top=�6h   $	��105��6�   ���	#FF303030���	#FFF8F0FB���	#FF3030306�   �� 5N      -   5        $ currentDuration��5N      $y�Visible=�6-   $�� ��6B   
���   �$��14(�6`   $
��Left=�6n   $��280,108,0,0q�6�   $	��Top=�6�   &   System.Windows.Controls.DataGrid  5P      -   5          Name$ dataGrid��5P      $
��Left=�6)   $	��199��6D   $��
43,219,0,0q�6Q   $	��Top=�6e   $	��415��6}      AutoGenerateColumns .     CanUserAddRows .  ��5Q      �� *Times+ �� UpdateSourceTrigger$ PropertyChanged=�    Columns  5R      0  *System.Windows.Controls.DataGridTextColumn  5S      ,  &System.Windows.Controls.DataGridColumn!   Header$! ID��6@   "   Width5	  /System.Windows.Controls.DataGridLengthConverter$" 50	 6L   #   
FontWeight$
# Bold"�6W   1
  +System.Windows.Controls.DataGridBoundColumn$ 
  Binding$ 6)   �� *id+6W     5T      $
! Date��6B   $	" 120	 6P   $
# Bold"�6\   $ 6)   �� *Date+6\     5U      $! 
Start Time��6H   $	" 170	 6\   $
# Bold"�6h   $ 6)   �� *
StartTimes+6h   4  .System.Windows.Controls.DataGridCheckBoxColumn  5V      $! Choose��6J   $ 6-   �� *
Selected+6J   5X      �� 5Y      -   5        $ 
noTimeMess��5Y      $y�	Collapsed=�6(   $��No time selected!��6?   $��12(�6[   $
��Left=�6i   $��185,428,0,0q�6�   $	��Top=�6�   $��28��6�   $	��104��6�   
���  ��6�   �� 5Z      -   5        $ appointmentBookedMess��5Z      $y�	Collapsed=�63   $��Appointment Booked��6J   $��12(�6g   $
��Left=�6u   $��170,428,0,0q�6�   $	��Top=�6�   $��28��6�   $	��132��6�   
��� � �6�   5[      �� 5\   
   -   5        
�������$��Sign Out��5\   #   $��1��66   $
��Left=�6F   $��
716,14,0,0q�6a   $��58��6u   $��26��6�   $	��Top=�6�   �� 5]   
   $��Book your appointment��6   $��24(�60   $��DemiBold"�6>   $
��Left=�6T   $��	37,47,0,0q�6o   $��1��6�   $	��Top=�6�   $��57��6�   $	��282��6�   $��1��6�   ���	#DDB8641F6�   5_      5a      