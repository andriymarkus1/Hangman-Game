   M S B A M L   `   `   `  ����O  KШибениця 2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Шибениця_2._0Шибениця_2._0  5      3    -Шибениця_2._0.DifficultySelectionMenu   5      ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Шибениця_2._0     5        N� Title$  DifficultySelectionMenu��5      $	��889��5	      $
��1055��6   .��5      � ��5   
   �� 5       �� ImageSource$ 	/Back.png��6    j� Stretch$
 Fill=�61   .+�5   
   �� -   5         ��Name$ DCanvas��5      .+�5      �� -   5         ��Name$ DName��5   6   $��0��6   $��СЕРЕДНІЙ:��6%   $��40(�5      ���	#FF040082$
��Left=�69   $��BirchCTT)�6T    J� RenderTransformOrigin$ 0.5,0.5&�6j   $	��344��6�   $
��Bold"�6�    �� Left$	 125��6�   
 �� Top$	 125��6�   z�5      V� 5      .~�5      �� �� 5       �� AngleY$ 0.791Q�6(   �� 5      	 �� Angle$	 -3.38Q�6*   T� 5      
 T� Y$
 1.902Q�6-    T� X$ 0.004Q�67   5      5      �� 5      -   5        $ DText��5   %   $��0��6   $b��\- ВІДКРИТА ПЕРША І ОСТАННЯ ЛІТЕРИ - 7-10 ЛІТЕР У СЛОВІ��64   $��25(�5      
���   �$��
35,200,0,0q�6-   $
��Left=�6A   $��BirchCTT)�6\   $ 0.5,0.5&�6r   $	��471��6�   $	��Top=�6�   $��WrapWithOverflow=�6�   $
��Bold"�6�   $��Italic$�6�   z�5      V� 5      .~�5      �� �� 5       $ 0.791Q�6(   �� 5!      $	 -2.577Q�6*   T� 5"      $
 1.902Q�6-   $ 0.004Q�67   5#      5%      5&      �� 5'   
   $��0��6   $��РІВЕНЬ��6!   $��40(�6/   ���	#FF05018A$��505,383,0,621q�6T   $
��Left=�6k   $��BirchCTT)�6�   $ 0.5,0.5&�6�   $	��131��6�   $
��Bold"�6�   z�5(      V� 5)      .~�5*      �� �� 5+      $ 0.791Q�6$   �� 5,      $	 2.494Q�6&   T� 5-      $
 1.902Q�6)   $ 0.004Q�63   5.      50      �� 51   
   $��0��6   $��СКЛАДНОСТІ:��6!   $��36(�64   $
��Bold"�6B   ���	#FF05018A$��510,427,0,577q�6k   $
��Left=�6�   $��BirchCTT)�6�   $ 0.5,0.5&�6�   $	��244��6�   z�52      V� 53      .~�54      �� �� 55      $ 0.791Q�6$   �� 56      $	 -6.229Q�6&   T� 57      $
 1.902Q�6)   $ 0.004Q�63   58      5:      	� 5;   
   -   5         	�Name$ 	EasyRadio��5;      $��Легкий��6)      EasyRadioButtonStyle#��[  6:   $
��Left=�6h   $��45��6�   $��473,527,0,0q�6�   $	��Top=�6�   $	��261��6�   $��36(�6�   $��Oblique$�6�   ���	#FF6F6F6F$ 0.501,0.567&�6  $��Center=�6%  z�5<      V� 5=      .~�5>      �� �� 5?      �� 5@      $	 -2.818Q�6&   T� 5A      $ 0.164Q�6)   $
 0.351Q�63   5B      5D      	� 5E   
   -   5        $ MidRadio��5E      $��СЕРЕДНІЙ��6(    d� 	IsChecked$
 TrueY�6;     MidRadioButtonStyle#��[ 6L   $
��Left=�6y   $��69��6�   $��447,578,0,0q�6�   $	��Top=�6�   $	��302��6�   ���	#FF05018A$��36(�6�   $ 0.263,0.444&�6�   z�5F      V� 5G      .~�5H      �� �� 5I      $ -0.279Q�6$   �� 5J      $	 3.643Q�6&   T� 5K      $ 0.454Q�6)   $
 -5.779Q�63   5L      5N      	� 5O   
   -   5        $ 	HighRadio��5O        HighRadioButtonStyle#��[ 6)   $��НАЙВИЩИЙ��6W   $
��Left=�6j   $��62��6�   $��411,652,0,0q�6�   $	��Top=�6�   $	��368��6�   ���	#FF9B1409$��40(�6�   $ 0.5,0.5&�6�   $��Oblique$�6  z�5P      V� 5Q      .~�5R      �� �� 5S      �� 5T      $	 -3.519Q�6&   T� 5U      5V      5X      �� 5Y   
   -   5        $��Далі��5Y      $��36(�6    $��428,717,226,285q�6J     PlayButtonStyle#��[ 6d   ���	#FF00098C$
��Bold"�6�   $ 0.642,0.229&�6�   z�5Z      V� 5[      .~�5\      �� �� 5]      �� 5^      $	 4.159Q�6&   T� 5_      $ 1.148Q�6)   $
 2.579Q�63   5`      5b      �� 5c   
   -   5          BackToMenuButtonStyle#��[ 5c      $��566,758,129,242q�6@   $��
назад��6x   $��36(�6�   $ 0.5,0.5&�6�   z�5d      V� 5e      .~�5f      �� �� 5g      �� 5h      $	 -7.865Q�6&   T� 5i      5j      5l      �� 5n   
   $��0��6   $��ГОЛОВНЕ��6!   $��36(�60   $
��Bold"�6>   
���   �$��716,971,0,48q�6c   $
��Left=�6y   $��BirchCTT)�6�   $ 0.5,0.5&�6�   $	��172��6�   z�5o      V� 5p      .~�5q      �� �� 5r      $ 0.791Q�6$   �� 5s      $	 197.531Q�6&   T� 5t      $
 1.902Q�6)   $ 0.004Q�63   5u      5w      �� 5x   
   $��0��6   $��МЕНЮ��6!   $��36(�6-   $
��Bold"�6;   
���   �$��601,952,0,66q�6`   $
��Left=�6v   $��BirchCTT)�6�   $ 0.5,0.5&�6�   $	��106��6�   z�5y      V� 5z      .~�5{      �� �� 5|      $ 0.791Q�6$   �� 5}      $	 181.413Q�6&   T� 5~      $
 1.902Q�6)   $ 0.004Q�63   5      5�      �� 5�   
   $��Налаштування��6   $��36(�6(   $��207,992,323,11q�66   {�.    SettingsButtonStyle#���  6`   ���	#FF00098C$
��Bold"�6�   $ 0.5,0.5&�6�   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      $	 -5.361Q�6&   T� 5�      5�      5�      �� 5�   
   -	   5        $��
Вихід��5�      $��36(�6!   $��-16,1015,752,1q�6/     ExitButtonStyle#��[ 6H   $ 0.5,0.5&�6q   ���	#FF9C0000$��Oblique$�6�   $
��Bold"�6�   z�5�      V� 5�      .~�5�      �� �� 5�      $ -1.68Q�6$   �� 5�      $	 -187.28Q�6&   T� 5�      $
 -2.926Q�6)   $ 0.314Q�64   5�      5�      �� 5�   
   $0��*\Visual\Difficulty_Selection_Menu\7(2).png��6   $��128,249,82,261q�6D   $ 0.194,0.514&�6\    J� IsHitTestVisible .  z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      $	 104.416Q�6&   T� 5�      $ -0.051Q�6)   $
 -1.498Q�64   5�      5�      �� 5�   
   $/��)\Visual\Difficulty_Selection_Menu\8sh.png��6   $��-205,449,529,233q�6C   $ 0.513,0.198&�6]   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      $
	 -2.1Q�6&   T� 5�      $ 96.921Q�6)   $
 60.179Q�64   5�      5�      �� 5�   
   $-��'\Visual\Difficulty_Selection_Menu\9.png��6   $��694,967,0,-34q�6A   $ 0.5,0.5&�6X   $
��Left=�6x   $	��136��6�   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      $	 -13.227Q�6&   T� 5�      5�      5�      �� 5�   
   $��
Грати��6   {�.  $��48(�63   $��539,977,100,27q�6A   #��[ 6Z   ���	#FF00098C$
��Bold"�6�   $ 0.5,0.5&�6�   z�5�      V� 5�      .~�5�      �� �� 5�      �� 5�      $	 -14.41Q�6&   T� 5�      5�      5�      5�      5�      