   M S B A M L   `   `   `  ����  MagazinOkna    UserList1.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$-  'Список пользователей��5   	   $	��300��5   	   $	��300��5   	   .��5      �  � RowDefinitions 5	   
   �� 5
      $
��Auto �6   �� 5      .+�5   
   �� $.��(Список пользователей:��6   $��16(�5      $��10q�5      $
��Left=�5      �� 5   
   -   5        $��UserList��5      $��1��5      $��10q�5      ��5      �� *Users+ �� View 5      �� 5      .P�5      �� -   5        	UserList1��$��Имя��5   %    �� DisplayMemberBinding 5   %   �� *Name+�� 5      $��Фамилия��6%    5   %   �� *
UserName+5      5       5"      5#      