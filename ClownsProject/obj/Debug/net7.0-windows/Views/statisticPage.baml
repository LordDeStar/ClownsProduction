   M S B A M L   `   `   `  ����H  DClownsProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:ClownsProject.ViewsClownsProject.Views  5      p lDotNetProjects.DataVisualization.Toolkit, Version=6.1.94.0, Culture=neutral, PublicKeyToken=79778c5f2eed289b�rclr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=DotNetProjects.DataVisualization.Toolkit2System.Windows.Controls.DataVisualization.Charting 67   '    !ClownsProject.Views.statisticPage   5      Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:ClownsProject.Views     5      �chartingToolkitrclr-namespace:System.Windows.Controls.DataVisualization.Charting;assembly=DotNetProjects.DataVisualization.Toolkit     67     N� Title$  statisticPage��5	      .��5      �  � 	Resources 5   
    �� 
TargetType �� Property �� Value �� Triggers P� Property P� Value �� 
TargetType	 ��Name
 �� CornerRadius��%W  '��       '��     �� 5      " ��6   .�5      ��  � ��
 ���� 6/   �� 5       � �� �#FFF60   �� 5       � ��$ 2q�64   �� 5       � �� �#FFF6/   �� 5       � ��$ 16(�6-   �� 5       � ��$ 	20,0,45,0q�6,   �� 5       � ��$
 Left=�6?   �� 5       � ��$ Center=�6=   �� 5       � ��$ 40��6+   �� 5       � ��$	 250��6*    5      P� 5       �@J�	IsFocused$
 True��63   . �5      ��  � �� �#FFF68   5      5       �� 5!      " ��6   .�5"      ��  � �� 5#      �� 5$      " ��6*   .R�5%      �� $	 Border��6%   $��2q�5&      $
 20��5'      ���#FFF$	��100��5)      $��45��5*      ���#FFF._�5,   "   �� $��Center=�63   $��Center=�6P   5-      5.      50      51      52       � ColumnDefinitions 53   
   �� 54      $
��auto �6   �� 55      $
��auto �6    � RowDefinitions 57   
   �� 58      $
��auto �6   �� 59      $
��auto �6   .+�5;   
   �� -   5         ��Name$ 	PageTitle��5;      $��Статистика��6'   $��310,20,0,20q�69   $��36(�6N   $
��Left=�6\   
�������$��Impact)�6�   $��0��6�   $��2��6�   �� 5<   
   $��1��6   $��0��6"   .+�5=      �� $6��0Количество задач в работе:��6   $��25(�6<   
�������$��Impact)�6^   $��0,10,0,0q�6r   �� 5>      $B��<Количество задач в тестировании:��6   $��25(�6B   
�������$��Impact)�6d   $��0,10,0,0q�6x   �� 5?      $=��7Количество выполненных задач:��6   $��25(�6?   
�������$��Impact)�6a   $��0,10,0,0q�6u   5@      �� 5B   
   $��1��6   $��1��6"   .+�5C      �� -   5        $ countInProgressTask��5C   *   $��0,10,0,0q�6   $	��100��6G   $��30��6S   $��18(�6_   $��Center=�6m   
��� ���$��Impact)�6�   6�   �� 5D      -   5        $ countInTestTask��5D   *   $��0,10,0,0q�6   $	��100��6C   $��30��6O   $��18(�6[   $��Center=�6i   
��� ���$��Impact)�6�   6�   �� 5E      -   5        $ countComplateTask��5E   *   $��0,10,0,0q�6   $	��100��6E   $��30��6Q   $��18(�6]   $��Center=�6k   
��� ���$��Impact)�6�   6�   5F      �� 5G   
   -   5         ��Name$ backBut��5G      $��
Назад��6"   $
��Left=�6H   5H      5I      