   M S B A M L   `   `   `  ����G  CSampleSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SampleSystemSampleSystem  5          SampleSystem.AuthorData   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:SampleSystem     5      -   5        $	��220��5   7   $	��515��6D     � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Styles/Buttons.xaml?�6%   %    5      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ 	#FFBFC5CD��6   $ 1Q�61   5      .+�5   
   �  � RowDefinitions 5      �� 5      .+�5      � $��0��6   	 � ColumnDefinitions	 5      �� 5       �� 5!      $	��350 �6'   .+�5#      �� $��1��6   $��5 5 5 5q�6-   .+�5$      �� $��Author Configurations��6    
�������$��Monotype Corsiva)�6U   $��0 0 0 5q�6s   $��Center=�6�   � 5%      .+�5&      �� -   5        
 ��Name$
 txtUASearchToolTip��5&   $   $��Search Here..��6@   $��Century Gothic)�6U   
�������$��20 5 0 0q�6�   $y�Visible=�6�   $��10(�6�   �� 5'      
�������$��1q�6:    �� CornerRadius$ 3��6N   $��0 0 0 7q�6_   ._�5(      ]� .+�5)   "   �� $
��Left=�6(   $��Images/search.png��6>   $��20��6Y   $��20��6d   $
��Left=�6p   $��Center=�6�   �� 5*   "   -   5         ��Name$ txtUASearch��5*   *   $��0 0 0 5q�6?   $��Century Gothic)�6P   
�������
������ 
������ $��0q�6   .��64  .��5-   5   5.   #   5/      50      52      &   System.Windows.Controls.DataGrid  53      -   5          Name$ dgAuthor��53      $��Century Gothic)�61   $	��160��6M      HorizontalGridLinesBrush �	#FF688CAF   VerticalGridLinesBrush �	#FF688CAF��6�   �� ��54      �� 55      $ 0.5,1&�62   $ 0.5,0&�6C   .��56   "   � $ Black��6/   $ 0Q�6=   � 57   "   $ White��6/   $ 1Q�6=   58      5?      5@      �� 5A      $��0��6   $��5 5 5 5q�6-    �� Orientation$ Vertical=�6>   $��Center=�6V   .+�5B      �� -   5        $ txtAuthoriD��5B      $��Century Gothic)�63   $y�Hidden=�6O   �� 5C      $��Author First Name:��6    $��Century Gothic)�6:   
�������$��10(�6n   �� 5D      -   5        $ txtAuthorFname��5D      $��Century Gothic)�66   $��0 0 0 5q�6R   �� 5F      $��Author Last Name:��6    $��Century Gothic)�69   
�������$��10(�6m   �� 5G      -   5        $ txtAuthorLname��5G      $��Century Gothic)�66   $��0 0 0 10q�6R   �� 5I      -   5         ��Name$ FunctionButtons��5I   !   $ 
Horizontal=�6:   $��Center=�6S   .+�5J      �� $ Vertical=�6%   .+�5K   "   �� -	   5         ��Name$ btnA_Add��5K   )   $��40��6;   $��40��6F   $�� ��6R   
������    BtnStyle#��[  6�   ��5L   "   �� 5M   &    �� ImageSource$ Images\crud_add.png��61   6U   5O      �� 5P      $	��New��6(   $��Century Gothic)�63   $��10(�6O   $��Center=�6]   $
��Bold"�6z   5Q      �� 5S      $ Vertical=�6%   .+�5T      �� -
   5        $ 	btnA_Edit��5T   %   $��40��68   $��40��6C   $�� ��6O   
������ #��[  6�   ��5U   "   �� 5V   &   $ Images\crud_edit.png��61   6V   5X      �� 5Y      $��Modify��6(   $��Century Gothic)�66   $��10(�6R   $��Center=�6`   $
��Bold"�6}   5Z      �� 5\      $ Vertical=�6%   .+�5]      �� -   5        $ btnA_Delete��5]   %   $��40��6:   $��40��6E   $�� ��6Q   
������ #��[  6�   ��5^   "   �� 5_   &   $ Images\crud_delete.png��61   6X   5a      �� 5b      $��Delete��6(   $��Century Gothic)�66   $��10(�6R   $��Center=�6`   $
��Bold"�6}   5c      �� 5e      $ Vertical=�6%   .+�5f      �� -   5        $ 	btnA_Save��5f   %   $��40��68   $��40��6C   $�� ��6O   
������ #��[  6�   ��5g   "   �� 5h   &   $ Images\crud_save.png��61   6V   5j      �� 5k      $
��Save��6(   $��Century Gothic)�64   $��10(�6P   $��Center=�6^   $
��Bold"�6{   5l      5m      5n      5p      5r      5t      5u      