   M S B A M L   `   `   `  ����F  BCD7_Kyrkosh, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CD7_KyrkoshCD7_Kyrkosh  5   	   =#clr-namespace:CD7_Kyrkosh.ViewModelCD7_Kyrkosh.ViewModel  5   	   5clr-namespace:CD7_Kyrkosh.ViewsCD7_Kyrkosh.Views  5   	       CD7_Kyrkosh.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CD7_Kyrkosh     5   	   2vm#clr-namespace:CD7_Kyrkosh.ViewModel     5   	   -vclr-namespace:CD7_Kyrkosh.Views     5   	     � Title$  
MainWindow��5   	   $	��450��6   $
��1000��6)    � DataContext 5	   	   ��    Locator �� Source# [   �� Path$
 Main�.��5      �  � ColumnDefinitions 5   
   �� 5      $	��100 �6   6-   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      6   �� 5      $	��100 �6   6+   .+�5   
   �� $��0��6   $	��100��6%   .+�5      �� $��Overview��6   $��5q�6(   ��63   �� *OverviewBtnClickedCmd+6_   �� 5      $��MyToys��6   $��5q�6&   ��61   �� *MyToysBtnClickedCmd+6[   5      �� 5   
   $��1��6   $��0��6"   
���   �$��1q�6C   $
��1000��6W    �� CornerRadius$ 30 0 0 0��6d   ._�5   
   �� $��0q�6   
�������$��1��6A   ��6Q   �� *	CurrentVm+ � 	Resources 5       �� DataType&    CD7_Kyrkosh.ViewModel.OverviewVm$   CD7_Kyrkosh.Views.OverviewView$   CD7_Kyrkosh.ViewModel.MyToysVm"   CD7_Kyrkosh.Views.MyToysView��%�   (��       5      *, +)(�� 2     5       *, +)�� 5      "  6   .R�5        5      �� 5       "  6   .R�5!        5"      5#      5$      5%      �� 5'   
   $��1��6   $��1��6%   $��2��62   $��80��6F   $	��900��6R   	 �� Orientation$	 
Horizontal=�6^   .+�5(      �� $��10q�6/   $��50��6;   $��50��6F   ��6   �� *	MyImage+6T   �� 5)      $��1��6   $��5q�6%   $ 8��60   
�������$��1q�6X   $	��800��6l   ._�5*      �� $��5q�6   $��Center=�6B   $��25��6]   ��6$   �� *	MyMessage+6]   5+      5,      5-      5/      