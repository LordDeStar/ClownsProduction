   M S B A M L   `   `   `  ����H  DClownsProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ClownsProject.ViewsClownsProject.Views  5      &     ClownsProject.Views.editTaskPage   5      Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ClownsProject.Views     5        N� Title$  editTaskPage��5	       � 	Resources 5       �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value �� 
TargetType	 ��Name
 �� CornerRadius��%�  '��       '�� ;    �� 5   
   " ��6   .�5      ��  � ��
 ���� 6+   �� 5       � �� �#FFF6,   �� 5       � ��$ 2q�60   �� 5       � �� �#FFF6+   �� 5       � ��$ 16(�6)   �� 5       � ��$ 	20,0,45,0q�6(   �� 5       � ��$ 0,10,0,0q�6'   �� 5       � ��$
 Left=�6;   �� 5       � ��$ Center=�69   �� 5       � ��$ 50��6'   �� 5       � ��$	 340��6&    5      P� 5       �@J�	IsFocused$
 True��6/   . �5      ��  � �� �#FFF64   5      5      �� 5    
   " ��6   .�5!      ��  � �� 5"      �� 5#      " ��6&   .R�5$      �� $	 Border��6!   $��2q�5%      $
 20��5&      ���#FFF$	��100��5(      $��45��5)      ���#FFF._�5+      �� $��Center=�6/   $��Center=�6L   5,      5-      5/      50      51      .��52      � .+�53   
   �� $��Center=�6   $��Center=�62   .+�54      �� $%��Изменение задачи��6   $��36(�60   $��Center=�6>   
�������$��Impact)�6n   �� 55       �� Orientation$ 
Horizontal=�6   $
��Left=�62   .+�56      �� $��20(�6   $��Center=�6*   
�������$��Impact)�6Z   Описание6x   57      �� 59      -   5         ��Name$ descriptionTB��59      $	��341��6-   $��40��69   �� 5:      $ 
Horizontal=�6   $
��Left=�62   .+�5;      �� -   5         ��Name$ editTB��5;      $��20(�6,   $��Center=�6:   
�������$��Impact)�6j   Статус6�   5<      �� 5=      -   5         ��Name$ statusCB��5=      $	��341��6)   $��33��65   6C   �� 5>      -   5        $ 
executorCB��5>      $	��341��6+   $��33��67   6E   �� 5?      $ 
Horizontal=�6   $��Center=�62   $��0,10,0,0q�6O   .+�5@      �� -   5         ��Name$ backBut��5@      $��
Назад��6*   $	��100��6P   �� 5A      -   5        $ saveChangesBut��5A      $��Изменить��61   $	��100��6a   $��	140,0,0,0q�6m   5B      5C      5E      5F      