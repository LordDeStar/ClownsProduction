   M S B A M L   `   `   `  ����H  DClownsProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:ClownsProjectClownsProject  5          ClownsProject.AuthWindow   5   	   Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      -localclr-namespace:ClownsProject     5      -   5          �Name$
  auth��5       � Title$ Авторизация��5      $	��720��6   $
��1100��6#    � WindowStartupLocation$ CenterScreen=�5	       � WindowStyle$
 None=�6'   
������  � AllowsTransparency$
 True��5
       � 
ResizeMode$ NoResize=�5       � WindowState$ Normal=�6   $��Poppins)�6-    � 	Resources 5       �� 
TargetType	 �� Property
 �� Value �� Triggers P� Property P� Value �� 
TargetType ��Name �� CornerRadius��%�  '��       '�� ;    �� 5   
   " ��6   .�5      �� 	 � ��

 ���� 6+   �� 5      	 � ��
 �#FFF6,   �� 5      	 � ��$
 2q�60   �� 5      	 � ��
 �#FFF6+   �� 5      	 � ��$
 16(�6)   �� 5      	 � ��$
 	20,0,45,0q�6(   �� 5      	 � ��$
 0,10,0,0q�6'   �� 5      	 � ��$

 Left=�6;   �� 5      	 � ��$
 Center=�69   �� 5      	 � ��$
 50��6'   �� 5      	 � ��$	
 340��6&    5      P� 5       �@J�	IsFocused$
 True��6/   . �5      �� 	 � ��
 �#FFF64   5      5       �� 5!   
   " ��6   .�5"      �� 	 � ��
 5#      �� 5$      " ��6&   .R�5%      �� $ Border��6!   $��2q�5&   !   $ 20��5'   !   ���#FFF$	��100��5)   !   $��45��5*   !   ���#FFF._�5,      �� $��Center=�6/   $��Center=�6L   5-      5.      50      51      52      .��53      � .+�56   
   �� $��1��6   ���#FFF$��2q�64   $ 12��6H   
�����w� �� Padding$ 30,40,30,40q�6v   ._�57      �� $��Center=�6   .+�58      �� $��Авторизация��6   $��36(�6/   $��Center=�6=   
�������$��Impact)�6m   �� 59      -   5         ��Name$ username��59      $��Имя��6,   �� 5:      -   5        $ password��5:      $��Пароль��6,   �� 5;       �� Orientation$ 
Horizontal=�6   $��Right=�66   �� 5<      $ 
Horizontal=�6   $��Center=�66   $��0,10,0,0q�6S   .+�5=      �� $��Регистрация��6   $	��150��63   �� 5>      -   5        $��Авторизация��5>      $	��150��6H   5?      5@      5A      5C      5D      