   M S B A M L   `   `   `  ����@  <Lab65, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:Lab65Lab65  5   	       Lab65.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:Lab65     5   	     � Title$  Eight Ball Answer��5   	   $	��350��6#   $	��525��60   .��5	      �  J� 	AllowDrop .   � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $��* �6   ��5   
   �� 5      .��5      �  � Offset$
 0.00Q�6    � Color$	 Red��6-   � 5      $
 0.50Q�6   $ Indigo��6-   � 5      $
 1.00Q�6   $ Violet��6-   5      .+�5   
   �� -   5         ��Name$ questionBox��5      $��Stretch=�6'   $	��123��6E    �� TextWrapping$
 Wrap=�6R   $��Place question here��6f   $��Stretch=�6�   $��10,13,19,10q�6�   $��0��6�   $��Veranda)�6�   $��24(�6�   �� 5   
   -   5         ��Name$ answer��5      $��Ask the Eight Ball��6!   $
��Left=�6>   $	��Top=�6Y   $	��149��6q   $��10,0,0,0q�6}   $��1��6�    J� RenderTransformOrigin$ 0.468,-0.863&�6�   $��25��6�   $��Veranda)�6�   �� 5   
   -   5        $ 	answerBox��5      $��Stretch=�6%   $	��123��6C   $
 Wrap=�6P   $�� Answer will appear here��6d   $��Stretch=�6�   $��10,10,19,10q�6�   $��2��6�   	 �� 
IsReadOnly	 . $��Veranda)�6�   $��24(�6�   5      5      