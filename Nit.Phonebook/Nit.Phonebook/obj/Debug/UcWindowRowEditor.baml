   M S B A M L   `   `   `  ����H  DNit.Phonebook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Nit.PhonebookNit.Phonebook  5      %    Nit.Phonebook.UcWindowRowEditor   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:Nit.Phonebook     5      F BWpfControls, Version=1.0.0.8, Culture=neutral, PublicKeyToken=null!wpfhttp://wpfcontrols.com/  5   	   V RMaterialDesignThemes.Wpf, Version=2.4.0.1044, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	      MaterialDesignBody#���   5
   	   $��Regular"�5   	   $��13(�5   	   &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5   	      TextRenderingMode$
 Auto=�5   	     MaterialDesignPaper#���  5   	     MaterialDesignFont#���  5   	   $	��450��5   	   $	��768��6     PrimaryHueMidBrush#���  6"   $��1q�6U   .��5      � $��RightToLeft=�6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6    � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ btnCancelAndClose��5      $y�	Collapsed=�6,     MaterialDesignFlatButton#��[ 6�   $��2��6�    K� ZIndex$ 10��6�   $��50��6�   $��35��6�   $
��Left=�6  $	��Top=�6  ��6c   0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Close=�6  `� 5    
   -   5         `�Name$ toolBarTray��5       $��2��6+   $��0��6?   .�5!      c�   MaterialDesignToolBar#���  6   }�.  .@�5"      �� -   5        $ btnOk��5"      $
��Left=�6=   #��[ 6Y   $	��100��6�   $��Bottom=�6�   .��6�   
تایید6�   �� 5#      -   5        $ btnClose��5#      $��Right=�6B   #��[ 6_   $	��100��6�   .��6�   
بستن6�   �� 5$      -   5         ��Name$ chkRemoveUnused��5$      	 d� 	IsChecked$	 FalseY�64   .��6�   ECحذف از جداول اصلی در صورت نبودن ارجاع5&      �� 5'      -   5        $ chkAutoSuggestionMode��5'      $
	 TrueY�6:   .��6�   FDپشینهاد گزینه های منطبق در هنگام تایپ5)      5*      5+      `� 5-   
   -   5        $ toolBarTrayProgress��5-      $��2��63   $��0��6G   $y�	Collapsed=�6T   .�5.      c� #���  6   }�.  .@�5/      #  MaterialDesignThemes.Wpf.Card  
   UniformCornerRadius$
 14Q�6&   $��4q�6?   .��50      �  % !MaterialDesignCircularProgressBar#��[ 6"    � Value$ 50Q�6]    � IsIndeterminate . 6h   51      52      53      -  'WpfControls.Editors.AutoCompleteTextBox  55   
   -   5          Name$ txtAutoEmployee��55   .   $��10q�6"   $	��Top=�6G   $��1��6_   $��0��6l   $��25��56   "      	Watermark$ نام��57   "      IconPlacement$
 Left=�58   "      IconVisibility$ Visible=�59   "      SelectedItem 5:      �� 5;       �� Path$ SelectedPath�6    �� Mode$ TwoWay=�6.   5<         LoadingContent 5>      �� 5?      $��
Loading...��6   $��5q�5@      $��14(�5A         Icon 5C      �� 5D      -	   5        $ btnInsertEmployeeToRow��5D      $��3q�69   $
��Auto��5E      $
��Auto��5F      $��Center=�5G      $��Center=�5H      ��5D   E     $ Pencil=�5H      5J      &   System.Windows.Controls.DataGrid  5K   
   -
   5          Name$ dataGridEmployee��5K      $	��350��6-   $	��250��69   $��15q�6F      CanUserAddRows .  $��Center=�6i   $��Center=�6�   $��2��6�   $��0��6�   5M      � 5P   
   $��1��6   $��1��6!   $��3q�61   .+�5Q      �� -   5        $ chkIsInternalPhoneNumber��5Q   %   $��10(�6   $
	 TrueY�6G   .��6X   
داخلی6_     5R      -   5        $ txtAutoPhone��5R   >   $	��290��6&   $��10q�62   $	��Top=�6T   $��25��5S   "   $ شماره تلفن��5T   "   $
 Left=�5U   "   $ Visible=�5V   "    5W      �� 5X      $ SelectedPath�6   $ TwoWay=�62   5Y       5[      �� 5\      $��
Loading...��6    $��5q�5]      $��14(�5^       5`      �� 5a      -   5        $ btnInsertPhoneToRow��5a      $��3q�6:   $
��Auto��5b      $
��Auto��5c      $��Center=�5d      $��Center=�5e      ��5a   F     $ Pencil=�5e      5g      5h        5k   
   -   5        $ dataGridPhone��5k      $	��350��6*   $	��250��66   $��15q�6C    .  $��Center=�6f   $��Center=�6�   $��2��6�   $��1��6�   5m      5o      5p      