   M S B A M L   `   `   `  ����  EP    EP.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          � Title$$  장비 정비 이력 시스템��5   	   $	��550��5   	   $	��900��6   .��5      � $��10q�6    � RowDefinitions 5   
   �� 5	      $��* �6   �� 5
      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��10 �6   �� 5      $��* �6   .+�55   
   �� $��0��6   .+�57      �� $��장비 목록��6   $��16(�6%   $
��Bold"�63   $��0 0 0 10q�6E   �� 58      -   5         ��Name$ EquipmentListBox��58       �� DisplayMemberPath$
 Name��59      $	��400��5;      �� 5<      -   5        $��BtnAddEquipment��5<      $��장비 추가��6,   $	��100��6<   $��0,10,0,0q�6I   $��Right=�6y   5=      �� 5@   
   $��0��6   $��2��6"   $��2��62   .+�5A      �� $��정비 이력��6   $��16(�6%   $
��Bold"�63   $��0 0 0 10q�6E   &   System.Windows.Controls.DataGrid  5B      -   5          Name$ MaintenanceHistoryGrid��5B         AutoGenerateColumns$ False��5C         
IsReadOnly$
 True��5D         SelectionMode$ Single=�5E      $	��400��5F      	   HeadersVisibility$	 Column=�5G      
   Columns
 5H      0  *System.Windows.Controls.DataGridTextColumn  5I      ,  &System.Windows.Controls.DataGridColumn   Header$ 날짜��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 130 6t   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *Date+ �� StringFormat$ {0:yyyy-MM-dd HH:mm}��6t     5J      $ 	정비사��6)   $	 100 6U    66   �� *
Technician+6U     5K      $ 설명��6)   $	 200 6U    65   �� *Description+6U     5L      $ 다음 점검일��6)   $	 120 6x    69   �� *NextDueDate+$ {0:yyyy-MM-dd}��6x   5N      �� 5P       �� Orientation$ 
Horizontal=�6   $��0,10,0,0q�62   $��Right=�6D   .+�5R      �� -   5         ��Name$ 	BtnAddLog��5R      $��정비 이력 추가��6,   $	��120��6?   $��10,0,5,0q�6K   6^   5S      5T      5U      5V      