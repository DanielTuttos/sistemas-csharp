   M S B A M L   `   `   `  ����  Samba.Modules.AccountModuleF    @Samba.Modules.AccountModule.Dashboard.AccountTransactionTypeView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .��5      �   � RowDefinitions  5	   
   �� 5
      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� .+�5      �� ��6   4  .Samba.Localization.Extensions.LocTextExtension  *Name_f+   FormatSegment1   *AccountTransactionType+   Suffix$ :���� 5      $
��Left=�6   $	��250��61   ��6@   �� *Name+�� 5      $	��120��6   ��6#     *SourceAccountTypeDesc+$ :���� 5       �� 
IsEditable . $
��Left=�6)   $	��170��6D    �� DisplayMemberPath$
 Name��6S   ��6l   �� *AccountTypes+ �� SelectedItem 5   &   �� *SourceAccountType+�� 5      $	��120��6   ��6#     *TargetAccountTypeDesc+$ :���� 5       . $
��Left=�6)   $	��170��6D   $
 Name��6S   ��6l   �� *AccountTypes+ 5   &   �� *TargetAccountType+�� 5      $	��120��6   ��6#     *DefaultSourceAccount+$ :���� 5       . $
��Left=�6)   $	��170��6D   $
 Name��6S    �� SelectedValuePath$ Id��5      ��5      �� *SourceAccounts+ �� SelectedValue 5      �� *DefaultSourceAccountId+5      �� 5      $	��120��6   ��6#     *DefaultTargetAccount+$ :���� 5       . $
��Left=�6)   $	��170��6D   $
 Name��6S   $ Id��5!      ��5      �� *TargetAccounts+ 5       �� *DefaultTargetAccountId+5!      �� 5"      $
��Left=�6   ��6/     *
Currency+$ :���� 5#       . $
��Left=�6)   $	��150��6D   $
 Name��5$   B   ��5#   S   �� *ForeignCurrencies+ 5$      �� *ForeignCurrency+6B   5%      �� 5'   
   $��2��6   .+�5(      �� $
��Left=�6   $
��0,10q�60   $��70��6>   ��6L   �� *SaveCommand.Caption+��5)      �� *SaveCommand+�� 5*      
���  ����6   �� *Error+6.   5+      5,      5-      