   M S B A M L   `   `   `  ����F  BChallenge14, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:Challenge14Challenge14  5   	       Challenge14.LoadingScreen   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:Challenge14     5   	     � Title$  LoadingScreen��5   	   $	��450��5	   	   $	��800��5
   	    � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	    � AllowsTransparency . 
������ .��5      �  � RowDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $��* �6   �� 5      $
��0.3* �6   .+�5   
   �� $��1��6   $��Stretch=�5      $��Stretch=�5      ���#2727275      � 5   
   -   5         �Name$
 PBar��5      $��1��5      $
��10px��5      $	��Top=�5      ���#272727���#525252
������  � IsIndeterminate . 5#      �� 5%   
   
�������$
��18px(�5&      $��1��5'      $
��Left=�5(       �� Padding$
 10pxq�5)      	Blaadam's6.   �� 5+   
   
�������$
��24px(�5,      $��1��5-      $
��Left=�5.      $ 	10px 30pxq�5/      Event Calendar68   �� 51   
   
�������$��16(�52      $��1��53      $��Bottom=�54      $
��Left=�55      $
 10pxq�56      v0.16)   �� 58   
   -   5        	 ��Name$	 PercentageDisplay��59      
�������$
��12px(�5:      $��1��5;      $	��Top=�5<      $��Right=�5=      $ 	15px 10pxq�5>      0%6,   �� 5@   
   $��1��6   $
��50px��5A      $��Right=�5B      $��Bottom=�5C      $
��10pxq�5D      $��/Images/Flame.png��5E      5G      5H      