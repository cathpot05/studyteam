   M S B A M L   `   `   `  ����G  CSampleSystem, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:SampleSystemSampleSystem  5          SampleSystem.CourseUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:SampleSystem     5      -   5        $	��220��5   7   $	��515��6D     � 	Resources  5
       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Styles/Buttons.xaml?�6%   %    5      .��5      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ White��6   $ 1Q�6-   5      .+�5   
   �  � RowDefinitions 5      �� 5      .+�5      � $��0��6    � ColumnDefinitions 5      �� 5       �� 5!      $	��350 �6'   .+�5#      �� $��1��6   $��5 5 5 5q�6-   .+�5$      �� $��Course Configurations��6    
�������$��Monotype Corsiva)�6U   $��0 0 0 5q�6s   $��Center=�6�   � 5%      .+�5&      �� -   5        	 ��Name$	 txtUASearchToolTip��5&   $   $��Search Here..��6@   $��Century Gothic)�6U   
�������$��20 5 0 0q�6�   $y�Visible=�6�   $��10(�6�   �� 5'      
�������$��1q�6:   
 �� CornerRadius$
 3��6N   $��0 0 0 7q�6_   ._�5(      ]� .+�5)   "   �� $
��Left=�6(   $��Images/search.png��6>   $��20��6Y   $��20��6d   $
��Left=�6p   $��Center=�6�   �� 5*   "   -   5         ��Name$ txtUASearch��5*   *   $��0 0 0 5q�6?   $��Century Gothic)�6P   
�������
������ 
������ $��0q�6   .��64  5+   #   5,      5-      5/      &   System.Windows.Controls.DataGrid  50      -   5          Name$ dgCourse��50      $��Century Gothic)�61   $	��160��6M      HorizontalGridLinesBrush �	#FF688CAF   VerticalGridLinesBrush �	#FF688CAF��6�   �� ��51      �� 52      $ 0.5,1&�62   $ 0.5,0&�6C   .��53   "   � $ Black��6/   $ 0Q�6=   � 54   "   $ White��6/   $ 1Q�6=   55      57      58      �� 59      $��0��6   $��5 5 5 5q�6-    �� Orientation$ Vertical=�6>   $��Center=�6V   .+�5:      �� -   5        $ txtCourseiD��5:      $��Century Gothic)�63   $y�Hidden=�6O   �� 5;      $��Course Code:��6    $��Century Gothic)�64   
�������$��10(�6h   �� 5<      -   5        $ txtCcode��5<      $��Century Gothic)�60   $��0 0 0 5q�6L   �� 5>      $��Course Description:��6    $��Century Gothic)�6;   
�������$��10(�6o   �� 5?      -   5        $ txtCdesc��5?      $��Century Gothic)�60   $��0 0 0 10q�6L    �� TextWrapping$
 Wrap=�6^   $��40��6r   �� 5A      -   5         ��Name$ FunctionButtons��5A   !   $ 
Horizontal=�6:   $��Center=�6S   .+�5B      �� $ Vertical=�6%   .+�5C      �� -	   5         ��Name$ btnA_Add��5C   %   $��40��67   $��40��6B   $�� ��6N   
������    BtnStyle#��[  6�   ��5D   "   �� 5E   &    �� ImageSource$ Images\crud_add.png��61   6U   5G      �� 5H      $	��New��6(   $��Century Gothic)�63   $��10(�6O   $��Center=�6]   $
��Bold"�6z   5I      �� 5K      $ Vertical=�6%   .+�5L      �� -
   5        $ 	btnA_Edit��5L   %   $��40��68   $��40��6C   $�� ��6O   
������ #��[  6�   ��5M   "   �� 5N   &   $ Images\crud_edit.png��61   6V   5P      �� 5Q      $��Modify��6(   $��Century Gothic)�66   $��10(�6R   $��Center=�6`   $
��Bold"�6}   5R      �� 5T      $ Vertical=�6%   .+�5U      �� -   5        $ btnA_Delete��5U   %   $��40��6:   $��40��6E   $�� ��6Q   
������ #��[  6�   ��5V   "   �� 5W   &   $ Images\crud_delete.png��61   6X   5Y      �� 5Z      $��Delete��6(   $��Century Gothic)�66   $��10(�6R   $��Center=�6`   $
��Bold"�6}   5[      �� 5]      $ Vertical=�6%   .+�5^      �� -   5        $ 	btnA_Save��5^   %   $��40��68   $��40��6C   $�� ��6O   
������ #��[  6�   ��5_   "   �� 5`   &   $ Images\crud_save.png��61   6V   5b      �� 5c      $
��Save��6(   $��Century Gothic)�64   $��10(�6P   $��Center=�6^   $
��Bold"�6{   5d      5e      5f      5h      5j      5m      5n      