   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5      H DHamburgerMenu, Version=0.1.0.0, Culture=neutral, PublicKeyToken=nullD2clr-namespace:HamburgerMenu;assembly=HamburgerMenuHamburgerMenu 5          WpfApp1.ClientAbout   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5      LHamburgerMenu2clr-namespace:HamburgerMenu;assembly=HamburgerMenu     5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5        N� Title$  About��5      .��5      � .+�5   
   �  J� RenderTransformOrigin$ 0.495,0.521&�6   z�5      V� 5      .~�5      ��  �� ScaleY$ 1Q�6%    �� ScaleX$ 1Q�60   �� 5       �� AngleY$ 0Q�6$    �� AngleX$ 0Q�6/   �� 5       �� Angle$ 0Q�6&   T� 5      5       � RowDefinitions 5      �� 5      $	��29* �6    �� 5      $
��276* �6     � ColumnDefinitions 5      �� 5      $	��64* �6#   �� 5      $
��263* �6#   .+�5      �� -   5        	 ��Name$	 isaac_benhesed_249427_jpg��5      $��2��67   $��50,0,0,0q�6K   $��1��6]   $��isaac-benhesed-249427.jpg��6j   $
��Fill=�6�   (  "MaterialDesignThemes.Wpf.ColorZone  5       $��16q�6'   
   Mode$
 PrimaryDark=�64   $��2��6G   $��58��6[   .��5!      ]� .+�5"      '  !MaterialDesignThemes.Wpf.PopupBox  $��Right=�6.      PlacementMode$ BottomAndAlignRightEdges=�6E      PopupContent. 5#      �� .@�5$      �� $��Hello World��6*   �� 5%      $��
Nice Popup��6*   �� 5&      $��Goodbye.��6*   5'      5(      �� 5)       �� Orientation$ 
Horizontal=�6!   .+�5*      �� $��	430,0,0,0q�6$   $��Center=�67   �� 6S   $�Booking office��6W   6p   5+      5,      5-      !  HamburgerMenu.HamburgerMenu  5/      ���	#FF616161   MenuIconColor
 �����   SelectionIndicatorColor
 �����   MenuItemForeground
 �����$
��Left=�6�     50      ���	#FF616161
 �����
 �����
 �����$
��Left=�6�   $��2��6�      Content. 51      %  HamburgerMenu.HamburgerMenuItem  -   5           Text$ 
My Profile��51   3      SelectionCommand 6E   ��  �� ElementName$ this_��6t     52      -   5        $ Booking��52   3   6B     53      -   5        $ My appointment��53   3   6I     54      -   5        $ About Us��54   3   6C   55      �� 56      $��About us��6   $��24(�6'   $��1��65   $
��Left=�6E   $��113,118,0,0q�6`   $��1��6u   $	��Top=�6�   $	��108��6�   �� 57      $��Center=�6   $��Center=�68   $j��dVersion: 1.0.0
Language: English

ADNA Team:
Duc Pham, Nguyen Tran, An Pham, Anh Le

© LAMKBooking
��6Z   $��16(�6�   $��1��6�   $
��Left=�6  $��
35,199,0,0q�6  $��1��61  $	��Top=�6>  $	��187��6V  $	��342��6c  �� 58      $��1��6   $��200,391,536,88q�6$   $��1��6<   $��windows.png��6I   $
��Fill=�6^   �� 59      $��1��6   $��122,391,614,88q�6$   $��1��6<   $��instagram.png��6I   $
��Fill=�6`   �� 5:      $��45,391,691,88q�6   $��1��6+   $��facebook-box.png��68   $
��Fill=�6R   $��1��6a   �� 5;      $��1��6   $��276,391,460,88q�6$   $��1��6<   $��github-circle.png��6I   $
��Fill=�6d   5<      5=      5>      