   M S B A M L   `   `   `  ����V  RSamba.Presentation.Controls, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null�Yclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls&Samba.Presentation.Controls.UIControls  5      Y USamba.Modules.AutomationModule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullO,clr-namespace:Samba.Modules.AutomationModuleSamba.Modules.AutomationModule 5      3   -Samba.Modules.AutomationModule.RuleActionView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullW SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     6F   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6E   @d2http://schemas.microsoft.com/expression/blend/2008     5      p
UIControlsYclr-namespace:Samba.Presentation.Controls.UIControls;assembly=Samba.Presentation.Controls     5      GSettingsModule,clr-namespace:Samba.Modules.AutomationModule     5        � 	Resources  5         comboTemplate �� Orientation �� 
IsEditable �� Text  textTemplate  passwordTemplate@   :Samba.Presentation.Controls.UIControls.BindablePasswordBox   PasswordC  =Samba.Modules.AutomationModule.ParameterValueTemplateSelector  parameterTemplateSelector   TextTemplate   ValueTemplate   PasswordTemplate��%h  &	        &	     &	     &	     7  7   7  �� 5   
   .R�5	      �� $��5,3,0,0q�6   $ 
Horizontal=�6*   .+�5
      �� $��0,0,5,0q�69   $	��120��6J   ��6   �� *NameDisplay+6J   �� 5       . $
��Left=�6c   $	��150��6~   ��6-   �� *Values+ 6L   �� *Value+6~   5      5      �� 5   
   .R�5      �� $��5,3,0,0q�6   $ 
Horizontal=�6*   .+�5      �� $��0,0,5,0q�69   $	��120��6J   ��6   �� *NameDisplay+6J   �� 5      $
��Left=�61   $	��150��6L   ��6   �� *Value+6L   5      5      �� 5   
   .R�5      �� $��5,3,0,0q�6   $ 
Horizontal=�6*   .+�5      �� $��0,0,5,0q�69   $	��120��6J   ��6   �� *NameDisplay+6J     5      $
��Left=�6L   $	��150��6g    61   �� *Value+6g   5      5        5   
   8   8  8  5       5"      .��5#      �  � RowDefinitions 5$   
   �� 5%      $��* �6   �� 5&      $
��auto �6   .+�5(   
   �� $��0��6   $
��Auto=�6$   .��5)      �� .+�5*      �� $
��Left=�6   ��63   4  .Samba.Localization.Extensions.LocTextExtension  *
ActionName+	   Suffix$	 :���� 5+      $
��Left=�6   $	��200��65   ��6D   �� *Name+�� 5,      $
��Left=�6   ��63     *
ActionType+$	 :���� 5-      $
��Left=�6   $	��200��66   
 �� SelectedValuePath$
 	ActionKey��5.   6    �� DisplayMemberPath$ 
ActionName��6T    �� SelectedValue 5-   E   �� *SelectedActionType+��5.      �� *ActionTypes+6T   �� 50      $
��Left=�51      y�50      �� *IsParameterLabelVisible+  VisibilityConverter �� 	Converter# [  �� FallbackValue$ 	Collapsed����51   /     *
Parameters+$	 :���� 53      #��[ 54      ��53      �� *ParameterValues+54      56      57      �� 58   
   $��1��6   .+�59      �� $
��Left=�6   $��0,10,3,0q�60   $��70��6B   ��6P   �� *SaveCommand.Caption+��5:      �� *SaveCommand+�� 5;      
���  ����6   �� *Error+6.   5<      5=      5>      