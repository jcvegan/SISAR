   M S B A M L   `   `   `  ����C  ?Schedule, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5(clr-namespace:Schedule;assembly=ScheduleSchedule  5      O Kmscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      P LAvalonControlsLibrary, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nulltNclr-namespace:AC.AvalonControlsLibrary.Controls;assembly=AvalonControlsLibrary!AC.AvalonControlsLibrary.Controls 5       SISAR.Desktop6   0SISAR.Desktop.Administracion.AdministrarReservas   5      W SPresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      8x,http://schemas.microsoft.com/winfx/2006/xaml    5      ;toolkit-http://schemas.microsoft.com/wpf/2008/toolkit  5      7schedule(clr-namespace:Schedule;assembly=Schedule  5      0sys&clr-namespace:System;assembly=mscorlib  5      [AvalonNclr-namespace:AC.AvalonControlsLibrary.Controls;assembly=AvalonControlsLibrary  5      $��Center=�5      $��Center=�5	      .��5   
   �� -   5        $��FormReservas��5      $!��Administración de Reservas��6'   .��5      ��   �� Orientation$  
Horizontal=�6   .+�5      �� $��
Parametros��6   .��5      �� $  Vertical=�6!   .+�5      �� $  
Horizontal=�6%   .+�5      �� $��Desde��6$   $��80��64   +  %Microsoft.Windows.Controls.DatePicker  5      -   5          Name$ dpInicio��5   1   $	��120��6D   5      �� 5      $  
Horizontal=�6%   .+�5      �� $��Hasta��6$   $��80��64     5      -   5        $ dpFin��5   1   $	��120��6@   5      �� 5      $  Vertical=�6%   .+�5      �� $  
Horizontal=�6)   .+�5   "   �� $��Hora Inicio��6(   2  ,AC.AvalonControlsLibrary.Controls.TimePicker  5   "   5      5      5      5         Schedule.Schedule  5      -   5          Name$ CalendarioReservas��5   $      ItemSize$ HalfHour=�6@   $	��720��6U   $	��360��6a      DisplayedDates 5!      ��
09/14/2009��63   ��5"      
09/15/2009��63   ��5#      
09/16/2009��63   ��5$      
09/17/2009��63   ��5%      
09/18/2009��63   ��5&      
09/19/2009��63   ��5'      
09/20/2009��63      Appointments 5*         Schedule.Appointment     Start$ 09/14/2009 18:00:00��6/   
   End$ 09/14/2009 20:00:00��6K      Location$ Mesa 5��6e   	   Summary$	 Cena de Gala��6w   
   Title$
 Sr. Juan Carlos Vega��6�   5,      5-      5.      5/      