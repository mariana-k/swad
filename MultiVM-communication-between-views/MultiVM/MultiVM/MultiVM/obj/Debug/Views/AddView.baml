   M S B A M L   `   `   `  ����B  >MultiVM, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:MultiVM.ViewsMultiVM.Views  5          MultiVM.Views.AddView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:MultiVM.Views     5        � DataContext  5      ��    Locator �� Source# [   �� Path$	 Add�.��5
      �  � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      6!    � RowDefinitions 5   
   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   �� 5      $��30 �6   6*   .+�5   
   �� $��Manufacturer��6   $��0��6'   $��0��67   6F   �� 5   
   $
��Type��6   $��0��6   $��1��6/   6>   �� 5   
   $��Description��6   $��0��6&   $��2��66   6E   �� 5   
   $��
Article No��6   $��0��6%   $��3��65   6D   �� 5   
   $��Price��6   $��0��6    $��4��60   6?   �� 5   
   $��1��6   $��0��6#   $��20��60   $	��200��6<   $��Center=�6H   $
��Left=�6c   ��6~   �� *Manufacturers+ �� SelectedItem 6�   �� *Device.Manufacturer+6�   �� 5   
   $��1��6   $��1��6#   $��20��60   $	��200��6<   $��Center=�6H   $
��Left=�6c   ��6~   �� *Types+ 6�   �� *
Device.Typ+6�   �� 5   
   $��1��6   $��2��6"   $��20��6/   $	��200��6;   $��Center=�6G   $
��Left=�6b   ��6}   �� *Device.Description+6�   �� 5   
   $��1��6   $��3��6"   $��20��6/   $	��200��6;   $��Center=�6G   $
��Left=�6b   ��6}   �� *Device.Description+6�   �� 5    
   $��1��6   $��4��6"   $��20��6/   $	��200��6;   $��Center=�6G   $
��Left=�6b   ��6}   �� *Device.Description+6�   �� 5!   
   $
��Save��6   $��0��6    $��5��60   $��20��6=   $	��100��6I   $��5q�6U   ��6`   �� *SaveBtnClickedCmd+6�   5"      5#      