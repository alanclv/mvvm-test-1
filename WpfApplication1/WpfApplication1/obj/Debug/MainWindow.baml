   M S B A M L   `   `   `  ����J  FWpfApplication1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:WpfApplication1WpfApplication1  5   	        WpfApplication1.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	   )localclr-namespace:WpfApplication1  5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)    � DataContext 5      '   !WpfApplication1.EmployeeViewModel  5   
   .��5
      � .+�5   
   �� $
��Left=�62   $��23��6M    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $	��120��6�   $��211,127,0,0q�6�   ��6   ��  �� Path$ 	FirstName�6�   �� 5   
   $
��Left=�61   $��23��6L   $��211,155,0,0q�6X   $
 Wrap=�6m   $	��Top=�6�   $	��120��6�   ��6   �� $ LastName�6�   �� 5   
   $��Submit��6a   $
��Left=�6s   $	��Top=�6�   $��75��6�   $��124,193,0,0q�6�    � ToolTip$% Submit changes to employee name��6�   ��6   �� $ SubmitCommand�{�68   �� $ SubmitEnabled�6�   �� 5   
   $
��Left=�68   $��211,193,0,0q�6S   $
��Wrap=�6h   $	��Top=�6|    J� RenderTransformOrigin$ 0.5,0.5&�6�   $	��266��6�   $��50��6�   ��6   �� $ EmployeeName�6�   �� 5   
   $��
First Name��6   $
��Left=�6%   $��133,127,0,0q�6@   $	��Top=�6U   $��78��6m   �� 5   
   $��	Last Name��6   $
��Left=�6$   $	��Top=�6?   $��133,152,0,0q�6W   5      5      