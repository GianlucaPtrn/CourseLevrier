   M S B A M L   `   `   `  ����M  IAct7_CourseLevrier, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Act7_CourseLevrierAct7_CourseLevrier  5   	   #    Act7_CourseLevrier.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Act7_CourseLevrier     5   	     � Title$  
MainWindow��5   	   $
��22px(�6   $	��700��6,   $	��850��69   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��271 �6   �� 5      $��413px �6   .+�5   
   �� -   5         ��Name$ piste��5      .+�5      �� $��/Images/racetrack.png��6   5      �� 5   
   $��1��6   $��Salle des paris��6    $	��800��69   $	��380��6E   .��5      �  � ColumnDefinitions 5      �� 5      $	��400 �6'   �� 5      $	��400 �6'    5      �� 5      $	��170 �6$   �� 5      $��80 �6$   �� 5      $��* �6$   .+�5      �� $��0��6   $��0��6*   .+�5       �� $
��Bold"�6   .��6.   Pari minimum : 5 écus6E   �� 5!      .��6   Joe possède 50 écus64   �� 5"      .��6   bob possède 50 écus64   �� 5#      .��6   Bill possède 50 écus65   5$      �� 5&      $��0��6   $��1��6*   .+�5'      �� $
��Bold"�6    Pari :6:   �� 5(      Joe n'a pas encore parié :6<   �� 5)      Bob n'a pas encore parié :6<   �� 5*      Bill n'a pas encore parié :6=   5+      � 5-      $��2��6   $��1��60   $��0��6=   .+�5.      �� $��
30,20,20,0q�6    Bill6:   �� 5/      
����·�$��	30,20,0,0q�67   .��6J   Parie6Q   �� 50      -   5         ��Name$ 
BlocNumber��50      $��30��62   $��
10,20,20,0q�6=   6S   �� 51      $��
20,20,20,0q�6    écus sur le chien numero6N   �� 52      -   5         ��Name$ LancerCourse��52      
����·�$	��220��6M   $��
20,20,30,0q�6Y   .��6m   Lancer la course6   53      �� 55      
����·�$��2��63   $��2��6@   $	��740��6T   $��30,30,30,30q�6`   .��6u   
RESET GAME6�   57      58      5:      5;      