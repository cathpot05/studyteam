   M S B A M L   `   `   `  ����G  CSampleSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SampleSystemSampleSystem  5          SampleSystem.BarrowerUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:SampleSystem     5      -   5        $	��220��5   7   $	��515��6D     � 	Resources  5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Styles/Buttons.xaml?�6%   %    5      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ White��6   $ 1Q�6-   5      .+�5   
   �  � RowDefinitions 5      �� 5      .+�5      � $��0��6    � ColumnDefinitions 5       �� 5!      $	��350 �6'   �� 5"      .+�5$      �� $��0��6   $��5 5 5 5q�6-   .+�5%      �� $��Barrower Configurations��6    
�������$��Monotype Corsiva)�6W   $��0 0 0 5q�6u   $��Center=�6�   � 5&      .+�5'      �� -   5        	 ��Name$	 txtSearchToolTip��5'   $   $��Search Here..��6>   $��Century Gothic)�6S   
�������$��20 5 0 0q�6�   $y�Visible=�6�   $��10(�6�   �� 5(      $��1q�6!   
 �� CornerRadius$
 3��65   
�������$��0 0 0 5q�6_   ._�5)      ]� .+�5*   "   �� $
��Left=�6(   $��Images/search.png��6>   $��20��6Y   $��20��6d   $��Center=�6p   $
��Left=�6�   �� 5+   "   -   5         ��Name$ txtUBSearch��5+   *   $��0 0 0 5q�6?   $��Century Gothic)�6P   
������ $��0q�6�   
������ .��6  5,   #   5-      5.      50      &   System.Windows.Controls.DataGrid  51      -   5          Name$ 
dgBarrower��51      $��Century Gothic)�63   $	��160��6O      HorizontalGridLinesBrush �	#FF688CAF   VerticalGridLinesBrush �	#FF688CAF��6�   �� ��52      �� 53      $ 0.5,1&�62   $ 0.5,0&�6C   .��54   "   � $ Black��6/   $ 0Q�6=   � 55   "   $ White��6/   $ 1Q�6=   56      58      59      �� 5:      $��1��6   $��5 5 5 5q�6-    �� Orientation$ Vertical=�6>   $��Center=�6V   .+�5;      �� $��Borrower Id��6    $��Century Gothic)�63   
�������$��10(�6g   �� 5<      -   5        $ txtBarrowerId��5<       �� 
IsReadOnly . $��Century Gothic)�6G   $��0 0 0 5q�6c   �� 5>      $��First Name:��6    $��Century Gothic)�63   
�������$��10(�6g   �� 5?      -   5        $ txtFname��5?      $��Century Gothic)�60   $��0 0 0 5q�6L   �� 5A      $��
Last Name:��6    $��Century Gothic)�62   
�������$��10(�6f   �� 5B      -   5        $ txtLname��5B      $��Century Gothic)�60   $��0 0 0 5q�6L   �� 5D      $��Course:��6    $��Century Gothic)�6/   
�������$��10(�6c   �� 5E      -   5         ��Name$ 	cboCourse��5E      $��0 0 0 5q�62   $��Century Gothic)�6C   �� 5H      -	   5         ��Name$ FunctionButtons_Book��5H   !   $ 
Horizontal=�6?   $��Center=�6X   .+�5I      �� $ Vertical=�6%   .+�5J      �� -
   5         ��Name$ btnB_Add��5J   %   $��40��67   $��40��6B   $�� ��6N   
������    BtnStyle#��[  6s   ��5K   "   �� 5L   &    �� ImageSource$ Images\crud_add.png��61   6U   5N      �� 5O      $	��Add��6(   $��Century Gothic)�63   $��10(�6O   $��Center=�6]   $
��Bold"�6z   5P      �� 5R      $ Vertical=�6%   .+�5S      �� -   5        $ 	btnB_Edit��5S   %   $��40��68   $��40��6C   $�� ��6O   
������ #��[  6t   ��5T   "   �� 5U   &   $ Images\crud_edit.png��61   6V   5W      �� 5X      $��Modify��6(   $��Century Gothic)�66   $��10(�6R   $��Center=�6`   $
��Bold"�6}   5Y      �� 5[      $ Vertical=�6%   .+�5\      �� -   5        $ btnB_Delete��5\   %   $��40��6:   $��40��6E   $�� ��6Q   
������ #��[  6v   ��5]   "   �� 5^   &   $ Images\crud_delete.png��61   6X   5`      �� 5a      $��Delete��6(   $��Century Gothic)�66   $��10(�6R   $��Center=�6`   $
��Bold"�6}   5b      �� 5d      $ Vertical=�6%   .+�5e      �� -   5        $ 	btnB_Save��5e   %   $��40��68   $��40��6C   $�� ��6O   
������ #��[  6t   ��5f   "   �� 5g   &   $ Images\crud_save.png��61   6V   5i      �� 5j      $
��Save��6(   $��Century Gothic)�64   $��10(�6P   $��Center=�6^   $
��Bold"�6{   5k      5l      5m      5o      5p      5q      5r      