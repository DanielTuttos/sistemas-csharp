   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5        Samba.Modules.SettingsModule/   )Samba.Modules.SettingsModule.SettingsView   5      M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $Q Kpack://application:,,,/Samba.Presentation.Controls;component/OfficeTab.xaml?�6%   %    5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   ��    OfficeTabControl#��[  6   .@�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *	General+.��5      �� .+�5      �� ��6     *Name_f+   FormatSegment1   *
Terminal+   Suffix$ :���� 5      $
��Left=�6   $	��200��6:   ��6F   �� *TerminalNames+ �� Text 5      �� *TerminalName+�� 5      $
��Left=�6   $��3q�6:   ��6E     *ProgramLanguage+.��5      �� .+�5      ��  �� Orientation$ 
Horizontal=�6)   $��Center=�6B   $	��0,5q�6]   .+�5   "   �� ��6(     *
UiLanguage+$ :���� 5   "   $
��Left=�6+   $	��100��6F    �� DisplayMemberPath$ 
NativeName��5   '   	 �� SelectedValuePath$
	 Name��6F   
 �� SelectedValue
 5   R   �� *
Language+��5   _   �� *SupportedLanguages+5       �� 5!      $��0q�6'   {�62   �� *OverrideLanguage+ d� 	IsChecked 6Y   �� *!OverrideWindowsRegionalSettings+��5"   #     *!OverrideWindowsRegionalSettings+5#      5$      �� 5%      ��6     *DataConnection+$ :���� 5&      $
��Left=�6   $	��300��69   ��6H   �� *ConnectionString+�� 5'      ��6     *CallerIdDevice+$ :��]� 5(      .+�5)      �� $
��Left=�6#   $	��200��6>    �� 
IsEditable .  5*      �� *CallerIdDeviceName+��6C   �� *CallerIdDeviceNames+�� 5+      $	��2,5q�6$   y�61   �� *CanEditDeviceSettings+  VisibilityConverter �� 	Converter# [ �� 5,       �� Command 6(   �� *#!EditCallerIdDeviceSettingsCommand+.�6^   .�5-   "   �� ��6,   ��  �� Path$/ )EditCallerIdDeviceSettingsCommand.Caption�5.      5/      50      �� 51      ��6     *MessageServerName+$ :���� 52      $
��Left=�6   $	��200��69   ��6H   �� *MessagingServerName+�� 53      ��6     *MessageServerPort+$ :���� 54      $
��Left=�6   $	��100��69   ��6H   �� *MessagingServerPort+�� 55      $	��0,5q�6    6,   �� *StartMessagingClient+��6W     *AutoStartMessageClient+�� 57      $
��Left=�6   $
��0,10q�68   ��6F   �� *%#StartMessagingServerCommand.Caption+��58      �� *StartMessagingServerCommand+59      5:      �� 5;      $��Display��6   .��5<      �� .+�5=      �� ��6     *WindowScale+$ :���� 5>      $ 
Horizontal=�6!   .+�5?      <   6Samba.Presentation.Controls.UIControls.FilteredTextBox     Type$ Number=�65   $
��Left=�6C   $��50��6^   ��6l   �� *WindowScale+�� 5@      $��%��6    5A      5B      5C      5D      �� 5E   
   $��1��6   $ 
Horizontal=�6"   .+�5F      �� $
��Left=�6   $��
0,10,20,10q�60   $��70��6D   ��6R   �� *SaveSettingsCommand.Caption+��5G      �� *SaveSettingsCommand+�� 5H      $
��Left=�6   $
��2,10q�60   ��6>   �� *%#DisplayCommonAppPathCommand.Caption+��5I      �� *DisplayCommonAppPathCommand+�� 5J      $
��Left=�6   $
��2,10q�60   ��6>   �� *#!DisplayUserAppPathCommand.Caption+��5K      �� *DisplayUserAppPathCommand+5L      5M      5N      