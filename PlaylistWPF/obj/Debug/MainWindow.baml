   M S B A M L   `   `   `  ����F  BPlaylistWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:PlaylistWPFPlaylistWPF  5   	       PlaylistWPF.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:PlaylistWPF     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $
��567* �6   �� 5      $
��226* �6   .+�5   
   �� -   5         ��Name$ BrowseButton��5      $��Browse��6'   $
��Left=�68   $��33��6S   $��102.8,329,0,0q�6_   $	��Top=�6v   $	��103��6�   $��1��6�   �� 5   
   -   5         ��Name$ 	linkField��5      $
��Left=�6%   $��28��6@   $��
530,96,0,0q�6L    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��243��6�   $��2��6�   �� 5   
   -   5         ��Name$ songView��5      $
��Left=�6%   $	��326��6@   $��	25,36,0,0q�6M   $	��Top=�6`   $	��467��6x    �� View 5      �� 5      .P�5      �� 5      5      �� 5   
   -   5        $ Clear_Button��5      $��Clear��6'   $
��Left=�67   $��33��6R   $��530,329,0,0q�6^   $	��Top=�6s   $	��103��6�   $��2��6�   5      5      