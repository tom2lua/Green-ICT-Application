   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp1WpfApp1  5          WpfApp1.register   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      U QMaterialDesignThemes.Wpf, Version=2.3.1.953, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:WpfApp1     5        N� Title$  register��5
       N� 
Background �#F8F0FB$	��610��6-   $	��981��6:   .��5      � .+�5   
    � -   5          �Name$ frame��5      $
��Left=�6   $	��610��6:   $	��Top=�6G   $	��981��6_   �� 5   
   $��demo.jpg��6   $
��Fill=�6"   �� 5   
   $��106,118,861,478q�6   $��account-circle.png��6)   $
��Fill=�6E    J� RenderTransformOrigin$ -2.273,1.238&�6T   $��14��6y   $��14��6�   �� 5   
   $��106,174,861,422q�6   $��lock-reset.png��6)   $
��Fill=�6A   $ -2.273,1.238&�6P   $��14��6u   $��14��6�   �� 5   
   $��	Username:��6   $
��Left=�6$   $��154,110,0,0q�6?   $	��Top=�6T   �� 5   
   $��	Password:��6   $
��Left=�6$   $��154,165,0,0q�6?   $	��Top=�6T   �� 5   
   $��Confirm Password:��6   $
��Left=�6,   $��154,214,0,0q�6G   $	��Top=�6\   �� 5   
   $��
Real Name:��6   $
��Left=�6%   $��154,266,0,0q�6@   $	��Top=�6U   �� 5   
   $��Email:��6   $
��Left=�6!   $��154,316,0,0q�6<   $	��Top=�6Q   �� 5   
   -   5         ��Name$ shortMessage��5      $"��Your Username is too short!!��6&   $
��Left=�6M   $��413,110,0,0q�6h   $	��Top=�6}   
���  ��$y�	Collapsed=�6�   �� 5   
   -   5        $ 	OkMessage��5      $	��Ok!��6$   $
��Left=�62   $��413,110,0,0q�6M   $	��Top=�6b   
��� � �$y�	Collapsed=�6�   �� 5   
   -   5        $ passMatchMessage��5      $&�� Confirm Password did not match!!��6+   $
��Left=�6V   $��413,214,0,0q�6q   $	��Top=�6�   
���  ��$y�	Collapsed=�6�   �� 5   
   -   5        $ usernameRequiredMess��5      $��Required field��6/   $
��Left=�6H   $��413,110,0,0q�6c   $	��Top=�6x   
���  ��$y�	Collapsed=�6�   �� 5   
   -   5        $ passwordRequiredMess��5      $��Required field��6/   $
��Left=�6H   $��413,165,0,0q�6c   $	��Top=�6x   
���  ��$y�	Collapsed=�6�   �� 5   
   -   5        $ emailRequiredMess��5      $��Required field��6,   $
��Left=�6E   $��413,316,0,0q�6`   $	��Top=�6u   
���  ��$y�	Collapsed=�6�   �� 5   
   -   5        $ usernameCheckMess��5      $'��!Username currently not available!��6,   $
��Left=�6X   $��413,110,0,0q�6s   $	��Top=�6�   
���  ��$y�	Collapsed=�6�   �� 5   
   -	   5        $ registeredMess��5      $��14(�6(   $.��(Your account has successfully registered��67   $
��Left=�6j   $��148,411,0,0q�6�   $	��Top=�6�   
��� � �$y�	Collapsed=�6�   $	��262��6�   $��35��6�   $ 0.5,0.5&�6�   z�5       V� 5!      .~�5"      �� �� 5#      �� 5$       �� Angle$ -0.071Q�6&   T� 5%      5&      5(      �� 5*   
   -
   5         ��Name$ usernameBox��5*      $
��Left=�6'   $��24��6B   $��277,110,0,0q�6N    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��120��6�   $ 0.458,2.417&�6�   6�   G� 5+   
   -   5         G�Name$ passwordBox��5+      $
��Left=�6+   $��278,158,0,0q�6F   $	��Top=�6[   $	��120��6s   G� 5,   
   -   5        $ 
retypePass��5,      $
��Left=�6*   $��277,207,0,0q�6E   $	��Top=�6Z   $	��120��6r   �� 5-   
   -   5        $ nameBox��5-      $
��Left=�6#   $��24��6>   $��277,260,0,0q�6J   $
 Wrap=�6_   $	��Top=�6s   $	��120��6�   $ 0.458,2.417&�6�   �� 5.   
   -   5        $ emailBox��5.      $
��Left=�6$   $��24��6?   $��278,310,0,0q�6K   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 50   
   $��105,271,860,323q�6   $��account-card-details.png��6)   $
��Fill=�6K   �� 51   
   $��105,321,859,271q�6   $��	email.png��6)   $
��Fill=�6<   �� 52   
   $��	Register
��6   $��24(�6(   ���	#FF7AA095$
��Left=�6M   $��
231,43,0,0q�6h   $	��Top=�6|   $��45��6�   �� 53   
   -   5        $��Sign up��53      $
��Left=�6#   $��231,365,0,0q�6>   $	��Top=�6S   $��86��6k   6v   �� 54   
   $��105,220,862,376q�6   $��lock-reset.png��6)   $
��Fill=�6A   $ -2.273,1.238&�6P   $��14��6u   $��14��6�   �� 55   
   -   5        $��back-logo-icon-27727.png��55      $��26,26,917,548q�62   6I   57      58      