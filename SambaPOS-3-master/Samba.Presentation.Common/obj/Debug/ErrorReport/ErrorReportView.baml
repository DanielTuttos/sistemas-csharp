   M S B A M L   `   `   `  ����T  PSamba.Presentation.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullE'clr-namespace:Samba.Presentation.CommonSamba.Presentation.Common  5   C   ;    5Samba.Presentation.Common.ErrorReport.ErrorReportView   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35M ISamba.Localization, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      6I   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6=   @d2http://schemas.microsoft.com/expression/blend/2008     5      :Common'clr-namespace:Samba.Presentation.Common     6C     � WindowStartupLocation$  CenterScreen=�5   @    � WindowStyle$ SingleBorderWindow=�5      $	��360��6'   $	��530��64    � Title 5      4  .Samba.Localization.Extensions.LocTextExtension  *SambaPOSReporter+,   &Samba.Presentation.Common.DialogCloser   DialogResult 5      �� *DialogResult+.��5      �  � RowDefinitions 5   
   �� 5	      $��* �6   �� 5
      $
��auto �6   .+�5   
   �� $��0��6   $��5q�6"   .@�5      �� ��6     *ErrorMessage+.��5      �  5      �� 5      $
��auto �6(   �� 5      $
��auto �6(   �� 5      $��* �6(    � ColumnDefinitions 5      �� 5      $
��auto �6+   �� 5      $��* �6+   .+�5      �� $��0,5,10,0q�6   $��Images/warning.png��6.   5      �� 5      $��0��6    $��1��6-   $��5q�6[   $
��Bold"�6f   $��16(�5      $
��Wrap=�6(   ��5   =   �� *ErrorMessage+5   (   �� 5      $��1��6   $��2��6*   $��0,5,0,0q�6>   $��0,1,0,0q�6O   
�������._�5      �� $	��5,1q�5      $��14(�6+   $
��Wrap=�69   ��5   $     * PleaseEnterABriefExplanationOf+   Suffix$ :��5   9   5       �� 5!      $��2��6;   $��2��6H   $��5q�6\   $��14(�5"       �� AcceptsReturn .  �� 
AcceptsTab . #��["��6O   ��5!      �� *UserMessage+.��5"   �   5#      5$      5%      �� 5&      ��6     *DetailedReport+.��5'      � $��5q�6    5(      �� 5)      $
��auto �6(   �� 5*      $��* �6(   .+�5,      �� $��0��6!   .+�5-      �� $��5q�6B   $
��Bold"�6M   $
��Wrap=�6_   ��6$   �� *ErrorMessage+6_   5.      �� 5/      $��Lucida Console)�6   $
��Auto=�6:   $
��Auto=�50      $��1��6J   	 �� 
IsReadOnly	 .  . ��6W   �� *ErrorReportAsText+.��51   A   52      53      54      55      �� 56   
   $��1��6   
 �� Orientation$
 
Horizontal=�6"   $��Right=�6;   $��30��6W   $��0,0,3,5q�57      .+�58      �� $��2q�6   $��70��6    ��6.   �� *CopyCommand+��6N   �� *CopyCommand.Caption+�� 59      $��2q�6   $��70��6    ��6.   �� *SaveCommand+��6N   �� *SaveCommand.Caption+�� 5:      $��2q�6   $��70��6    ��6.   �� *SubmitCommand+��6P   �� *SubmitCommand.Caption+�� 5;      -   5        $��2q�5;      $��70��6    ��6.     *Close+5<      5=      5>      5?      