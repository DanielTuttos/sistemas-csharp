   M S B A M L   `   `   `  ����"  Samba.Modules.AutomationModule0    *Samba.Modules.AutomationModule.TriggerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6C   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6=   @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      � .+�5   
   �� .+�5      �� $
��Left=�6   ��6/   4  .Samba.Localization.Extensions.LocTextExtension  *TriggerName+�� 5      $
��Left=�6   $	��200��61   ��6@   �� *Name+�� 5	      $
��Left=�6   ��6/     *
Expression+�� 5
        �� 
IsReadOnly  . $
��Left=�6(   $	��200��6C   ��6R   �� *
Expression+�� 5      $
��Left=�6<   $��5q�5      ��5        *ExpressionBuilder+.��5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6!   $	��0,5q�6:   .+�5      �� $	��126��6    ��6/     *CommonSettings+   Suffix$ :���� 5      $	��150��6#    �� DisplayMemberPath$ SettingName��5      ��5   2   �� *CommonCronSettings+ �� SelectedItem 6]   �� *SelectedCronSetting+5      5      �� 5      $ 
Horizontal=�6!   $	��0,5q�6:   .+�5      �� $��70��6    ��6.     *Minute+$ :���� 5      $	��5,0q�6"   $��50��6G   ��6/   �� *Minute+6G   �� 5      $	��150��6#   $ SettingName��5      ��5   2   �� *CommonMinuteCronSettings+ 6c   �� *SelectedMinuteCronSetting+5      5      �� 5      $ 
Horizontal=�6!   $	��0,5q�6:   .+�5      �� $��70��6    ��6.     *Hour+$ :���� 5      $	��5,0q�6"   $��50��6E   ��6/   �� *Hour+6E   �� 5      $	��150��6#   $ SettingName��5      ��5   2   �� *CommonHourCronSettings+ 6a   �� *SelectedHourCronSetting+5      5      �� 5      $ 
Horizontal=�6!   $	��0,5q�6:   .+�5       �� $��70��6    ��6.     *Day+$ :���� 5!      $	��5,0q�6"   $��50��6D   ��6/   �� *Day+6D   �� 5"      $	��150��6#   $ SettingName��5#      ��5"   2   �� *CommonDayCronSettings+ 6`   �� *SelectedDayCronSetting+5#      5$      �� 5%      $ 
Horizontal=�6!   $	��0,5q�6:   .+�5&      �� $��70��6    ��6.     *Month+$ :���� 5'      $	��5,0q�6"   $��50��6F   ��6/   �� *Month+6F   �� 5(      $	��150��6#   $ SettingName��5)      ��5(   2   �� *CommonMonthCronSettings+ 6b   �� *SelectedMonthCronSetting+5)      5*      �� 5+      $ 
Horizontal=�6!   $	��0,5q�6:   .+�5,      �� $��70��6    ��6.     *	Weekday+$ :���� 5-      $	��5,0q�6"   $��50��6H   ��6/   �� *	Weekday+6H   �� 5.      $	��150��6#   $ SettingName��5/      ��5.   2   �� *CommonWeekdayCronSettings+ 6d   �� *SelectedWeekdayCronSetting+5/      50      51      52      �� 53      $ 
Horizontal=�6   .+�54      �� $
��Left=�6   $��0,10,3,0q�64   $��70��6F   ��6T   �� *SaveCommand.Caption+��55      �� *SaveCommand+�� 56      $
��Left=�6   $��0,10,3,0q�64   $��70��6F   ��6T   �� *TestExpressionCommand.Caption+��57      �� *TestExpressionCommand+58      �� 59      
���  ����6   �� *Error+6.   5:      5;      5<      