   M S B A M L   `   `   `  ����  WiiConnectV2    WiiConnectV2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��526��6)   .��5      � -   5         �Name$ Grid1��5      $��0q�6   
������� � RowDefinitions 5   
   �� 5      $��40 �6   �� 5       � ColumnDefinitions 5
   
   �� 5      $
��127* �6   �� 5      $��5* �6   �� 5      $
��127* �6   .+�5   
   �� -   5         ��Name$ Arena1��5      $��1��6!   
���   �$��3��6A   $��0,0,0,-0.333q�6U   .+�5      �� -   5         ��Name$
 Wiz1��5      $	��130��6"    �� Left$ 63��6/   $��blueWizard.png��6@   $
��Fill=�6X   
 �� Top$ 70��6g   $	��125��6w   �� 5      -   5        $
 Wiz2��5      $��redWizard.png��6"   $
��Fill=�69   $	��140��6H   $	 324��6U   $ 70��6g   $	��135��6w   $��RightToLeft=�6�   5      �� 5   
   -   5         ��Name$ Player1ScoreBox��5      	 �� TextWrapping$
	 Wrap=�6+   $��0��6?   ���	#FF1700FF
 �� TextAlignment$
 Right=�6_   $��24(�6u   
���   �$��Stretch=�6�   $��Stretch=�6�   �� 5   
   -   5        $ Player2ScoreBox��5      $
	 Wrap=�6+   $��0��6?   $��2��6H   
���  ��$��24(�6i   
���   �$��Stretch=�6�   $��Stretch=�6�   �� 5   
   -   5        $ Border��5      $��1��6!   $��2��61   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ Black��6#    � Offset$ 0Q�61   � 5      $ 	#FFC500FF��6#   $ 1Q�65   5      5      5      5      