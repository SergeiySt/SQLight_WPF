   M S B A M L   `   `   `  ����C  ?WpfApp23, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:WpfApp23WpfApp23  5   	       WpfApp23.UserWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:WpfApp23     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ 
UserWindow��5	   	   $	��292��6   $	��662��6)    � Icon$ /user_add_12818.ico��65    � WindowStartupLocation$ CenterScreen=�6P    � 	Resources 5
       �� 
TargetType �� Property �� Value��%  '��       '�� H     '�� �     �� 5   
   " ��6   .�5      ��  � ��$ 10q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 10q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 60��6)   �� 5       � ��$ 8q�6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      �� 5      �� 5      	 � ColumnDefinitions	 5   
   �� 5      $	��100 �6   �� 5      .+�5"   
   �� $
��Name��6   $��16(�6    �� 5#   
   $	��Age��6   $��1��6   $��16(�6,   �� 5&   
   -   5        
 ��Name$
 textBoxName��5&      $��1��6=   $��16(�6M   ��6'   �� *Name+6M   �� 5'   
   -   5        $
 
textBoxAge��5'      $��1��6;   $��1��6K   $��16(�6X   ��6&   �� *Age+6X   �� 5*   
   $
��Left=�6    �� Orientation$ 
Horizontal=�60   $��2��6I   $��1��6V   $��56��6f   $��	140,0,0,0q�6r   $��Center=�6�   .+�5+      �� -   5         �� 	IsDefault$
 True��5+      $��30��6;   $��16(�6G   $��73��6U   .��6`   Ok6d   �� 5,      -   5         �� IsCancel$
 True��5,      $��32��6&   $��16(�62   $��76��6@   .��6b   Отмена6j   5-      5.      5/      