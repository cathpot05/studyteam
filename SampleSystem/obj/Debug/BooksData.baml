   M S B A M L   `   `   `  ����G  CSampleSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SampleSystemSampleSystem  5          SampleSystem.BooksData   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:SampleSystem     5      -   5        $	��220��5   7   $	��515��6D     � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Styles/Buttons.xaml?�6%   %    5      .��5      � ��5   
   
� 5      .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FFBFC5CD��6   $ 1Q�61   5      .+�5   
   �  � RowDefinitions 5      �� 5      .+�5       � $��0��6    � ColumnDefinitions 5!      �� 5"      $	��350 �6'   �� 5#      .+�5%      �� $��0��6   $��5 5 5 5q�6-   .+�5&      �� $��Book Configurations��6    
�������$��Monotype Corsiva)�6S   $��0 0 0 5q�6q   $��Center=�6�   � 5'      .+�5(      �� -   5         ��Name$ txtSearchToolTip��5(   $   $��Search Here..��6>   $��Century Gothic)�6S   
�������$��20 5 0 0q�6�   $y�Visible=�6�   $��10(�6�   �� 5)      $��1q�6!    �� CornerRadius$ 3��65   
�������$��0 0 0 5q�6_   ._�5*      ]� .+�5+   "   �� $
��Left=�6(   $��Images/search.png��6>   $��20��6Y   $��20��6d   $��Center=�6p   $
��Left=�6�   �� 5,   "   -   5        	 ��Name$	 txtUBSearch��5,   *   $��0 0 0 5q�6?   $��Century Gothic)�6P   
������ $��0q�6�   
������ .��6  .��5/   5   50   #   51      52      54      &   System.Windows.Controls.DataGrid  55      -   5        
  Name$
 dgBooks��55      $��Century Gothic)�60   $	��160��6L      HorizontalGridLinesBrush �	#FF688CAF   VerticalGridLinesBrush �	#FF688CAF��6�   �� ��56      �� 57       �� EndPoint$ 0.5,1&�62    �� 
StartPoint$ 0.5,0&�6C   .��58   "   � $ Black��6/   $ 0Q�6=   � 59   "   $ White��6/   $ 1Q�6=   5:      5<      �� 5=      -   5        $	 	txtBookId��5=      $y�Hidden=�61   5>      �� 5?      $��1��6   $��5 5 5 5q�6-    �� Orientation$ Vertical=�6>   $��Center=�6V   .+�5@      �� $��Book Title:��6    $��Century Gothic)�63   
�������$��10(�6g   �� 5A      -   5        $	 	txtbTitle��5A      $��Century Gothic)�61   $��0 0 0 5q�6M   �� 5C      $��Author:��6    $��Century Gothic)�6/   
�������$��10(�6c   �� 5D      -   5         ��Name$ 
cboBauthor��5D      $��0 0 0 5q�63   $��Century Gothic)�6D   �� 5F      $��Date Published:��6    $��Century Gothic)�67   
�������$��10(�6k   (  "System.Windows.Controls.DatePicker  5G      -   5          Name$ dP_datePublished��5G   !   $��Century Gothic)�6;   � 5H       5I      �� 5J      �� 5K      .+�5M      �� $��0��6%   $��0 0 3 0q�65   .+�5N      �� $��	Quantity:��6(   $��Century Gothic)�69   
�������$��10(�6m   �� 5O      -	   5        $	 txtbQty��5O   &   $��Century Gothic)�67   $��0 0 0 5q�6S   5P      �� 5Q      $��1��6%   $��3 0 0 0q�65   .+�5R      �� $��Stocks:��6(   $��Century Gothic)�67   
�������$��10(�6k   �� 5S      -
   5        $	 
txtbStocks��5S   &   $��Century Gothic)�6:   $��0 0 0 5q�6V    �� 
IsReadOnly . 6g   5T      5V      �� 5W      -   5         ��Name$ FunctionButtons_Book��5W   !   $ 
Horizontal=�6?   $��Center=�6X   .+�5X      �� $ Vertical=�6%   .+�5Y      �� -   5         ��Name$ btnB_Add��5Y   %   $��40��67   $��40��6B   $�� ��6N   
������    BtnStyle#��[  6s   ��5Z   "   �� 5[   &    �� ImageSource$ Images\crud_add.png��61   6U   5]      �� 5^      $	��Add��6(   $��Century Gothic)�63   $��10(�6O   $��Center=�6]   $
��Bold"�6z   5_      �� 5a      $ Vertical=�6%   .+�5b      �� -   5        $ 	btnB_Edit��5b   %   $��40��68   $��40��6C   $�� ��6O   
������ #��[  6t   ��5c   "   �� 5d   &   $ Images\crud_edit.png��61   6V   5f      �� 5g      $��Modify��6(   $��Century Gothic)�66   $��10(�6R   $��Center=�6`   $
��Bold"�6}   5h      �� 5j      $ Vertical=�6%   .+�5k      �� -   5        $ btnB_Delete��5k   %   $��40��6:   $��40��6E   $�� ��6Q   
������ #��[  6v   ��5l   "   �� 5m   &   $ Images\crud_delete.png��61   6X   5o      �� 5p      $��Delete��6(   $��Century Gothic)�66   $��10(�6R   $��Center=�6`   $
��Bold"�6}   5q      �� 5s      $ Vertical=�6%   .+�5t      �� -   5        $ 	btnB_Save��5t   %   $��40��68   $��40��6C   $�� ��6O   
������ #��[  6t   ��5u   "   �� 5v   &   $ Images\crud_save.png��61   6V   5x      �� 5y      $
��Save��6(   $��Century Gothic)�64   $��10(�6P   $��Center=�6^   $
��Bold"�6{   5z      5{      5|      5~      5�      5�      5�      