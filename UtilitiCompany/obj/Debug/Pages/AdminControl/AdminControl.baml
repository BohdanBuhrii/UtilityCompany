   M S B A M L   `   `   `  ����I  EUtilitiCompany, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullU/clr-namespace:UtilitiCompany.Pages.AdminControl!UtilitiCompany.Pages.AdminControl  5      4    .UtilitiCompany.Pages.AdminControl.AdminControl   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Alocal/clr-namespace:UtilitiCompany.Pages.AdminControl     5      V RMaterialDesignThemes.Wpf, Version=2.6.0.1366, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      $��Medium"�5	      $��14(�5
      $X��Rpack://application:,,,/MaterialDesignThemes.Wpf;component/Resources/Roboto/#Roboto)�5      
���   �
������ .��5      � -   5        $��MainGrid��5      .+�5   
   ?  9MaterialDesignThemes.Wpf.Transitions.TransitioningContent  -   5           Name$  TrainsitionigContentSlide��5   .   C  =MaterialDesignThemes.Wpf.Transitions.TransitioningContentBase   OpeningEffect 6Q   D  >MaterialDesignThemes.Wpf.Transitions.TransitionEffectExtension  *SlideInFromLeft+   Duration$ 0:0:0.8X�.��5      � -   5         �Name$ windowTables��5       � RowDefinitions 5      �� 5      $��353.6 �6$   �� 5       � ColumnDefinitions 5      �� 5      $��0* �6'   �� 5      $��0* �6'   �� 5      $
��126* �6'   �� 5      $
��356* �6'   �� 5      $
��189* �6'   �� 5      $
��128* �6'   .+�5      �� -   5        $��Log Out��5      $��Right=�6+   $	��Top=�6G   $��0��6_   $��5��6l   $��30��5      $	��110��6!      StandartButton#��[  6-   $��SemiBold"�5      $��17(�6+   $��0,7,9,0q�6Q   &   System.Windows.Controls.DataGrid  5!      -   5          Name$ grid_tabels��5!      $��3��60   $
��Left=�6D   $	��375��6_   $	��Top=�6l   $	��674��6�   $��0,61,0,0q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   ���	#FFF0F0F0   CanUserReorderColumns .  	   ClipboardCopyMode$
	 None=�6�   $
 �� IsSynchronizedWithCurrentItem$

 TrueY�6  $��3��65     
IsReadOnly . $��2��6W     CanUserAddRows .   � BindingGroup 5"      &   System.Windows.Data.BindingGroup  5#      5%        5&      -   5        $ data_grid_change��5&      $��3��65   $
��Left=�6I    .  $	��110��6{   $��40.6,27,0,0q�6�   $	��Top=�6�   $	��600��6�   $y�Hidden=�6�    �� AlternationCount$ 1��6�      FrozenColumnCount$ 1��6�   
�������$��3��6  � 5'      -   5        $ grid_datatable_control��5'      $��4��68   $
��Left=�6L   $	��269��6g   $��	10,44,0,0q�6t   $	��Top=�6�   $	��141��6�    5(      �� 5)      $	��26* �6+   �� 5*      $	��21* �6+   .+�5,      �� -   5         ��Name$ button_delete��5,      #��[  64   
���iii�$��10(�6q   $��Delete��6   $
��Left=�6�   $��20��6�   $��
10,115,0,0q�6�   $	��Top=�6�   $��91��6�   $��2��6�   6  �� 5-      -	   5        $ button_edit��5-      #��[  62   
���iii�$��10(�6o   $��
Edit table��6}   $
��Left=�6�   $��20��6�   $��	10,90,0,0q�6�   $	��Top=�6�   $��91��6�   $��2��6	  �� 5.      -
   5        $ button_create_new��5.      #��[  68   
���iii�$��10(�6u   $��
Create new��6�   $
��Left=�6�   $��20��6�   $��	10,65,0,0q�6�   $	��Top=�6�   $��91��6�   $��2��6  5/      � 50      -   5        $ grid_ok_cancel��50      $
��Left=�60   $	��110��6K   $	��Top=�6X   $	��158��6p   $��
31,186,0,0q�6|   $��2��6�   $��2��6�   .+�51      �� -   5        $ button_cancel_changes��51      #��[  6<   
���iii�$��10(�6y   $��Cancel��6�   $��Right=�6�   $	��Top=�6�   $��60��6�   $��25��6�   $ 2.475,-0.306&�6  $��	0,60,98,0q�6,  �� 52      -   5        $ button_accept_changes��52      #��[  6<   
���iii�$��10(�6y   $��Ok��6�   $
��Left=�6�   $��25��6�   $	��Top=�6�   $��60��6�   $ -0.798,0.739&�6  $��
0,30,0,-10q�6(  53      �� 54      -   5         ��Name$ combobox_choose_table��54      ���#ECEB6A
���iii�$
��Left=�6d   $��26��6   $��0,18,0,0q�6�   $	��Top=�6�   $	��126��6�   $ 
0.63,0.477&�6�   $��2��6  55      56      57      58      