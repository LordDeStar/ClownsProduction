   M S B A M L   `   `   `  ����H  DClownsProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:ViewsssViewsss  5          Viewsss.TaskPage   5      Z VDevExpress.Mvvm.UI, Version=23.2.0.0, Culture=neutral, PublicKeyToken=382ad28f6ae31f30W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      'localclr-namespace:Viewsss     5        N� Title$  TaskPage��5	       � 	Resources 5         ListViewItemTemplate �� CornerRadius J� Effect3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   ShadowDepth   Opacity �� TextAlignment J� Opacity
	 � Tag��%�  &	        �� 5   
   .R�5      � .+�5      �� ���	#FFF3F3F3$ 10��5      ���	#FFE0E0E0$��1q�5      $��Stretch=�6!    5        5      $ 10Q�6+   $ 1Q�5   !   $	 0.5Q�5   !   5      �� 5      $��Center=�6   $��	15,0,15,0q�5      .+�5      �� $��18(�5      $
��Bold"�5      $
��Wrap=�5      ��5       �� *Title+5      �� 5      $��14(�5      $ Right=�5       $	 0.6Q�5!      ��5       �� *Login+5!      �� 5"      -   5        $��Изменить��5"      $
��auto��6\   	 60   �� *IdTask+6\   5#      5$      5%      5&      .��5'      � 
������ 
 � RowDefinitions
 5(   
   �� 5)      $��1* �6   �� 5*      $
��Auto �6   �� 5+      $��1* �6   .+�51   
   �� $��0��6   .+�52      �� $��20(�6   
�������$��Impact)�69   В работе6W   �� 53      -   5         ��Name$ 	listView1��53      #��[  6*   $��5q�6_   $��Stretch=�6j   
������ 6�   54      �� 55   
   $��1��6   $��5��6$   $��Stretch=�6/   
�������6M   �� 56   
   $��2��6   .+�57      �� $��20(�6   
�������$��Impact)�69   В тестировании6]   �� 58      -   5        $ 	listView2��58      #��[  6*   $��5q�6_   $��Stretch=�6j   
������ 6�   59      �� 5;   
   $��2��6   $��3��6%   .+�5<      �� $��20(�6   
�������$��Impact)�69   Выполнено6X   �� 5=      -   5        $ 	listView3��5=      #��[  6*   $��5q�6_   $��Stretch=�6j   
������ 6�   5>       � ColumnDefinitions 5B   
   �� 5C      �� 5D      $
��Auto �6   �� 5E      5H      5I      