   M S B A M L   `   `   `  ����G  CmyDictionary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:myDictionarymyDictionary  5   	   d `DotNetProjects.Input.Toolkit, Version=6.1.94.0, Culture=neutral, PublicKeyToken=79778c5f2eed289bgKclr-namespace:System.Windows.Controls;assembly=DotNetProjects.Input.ToolkitSystem.Windows.Controls 62       myDictionary.UserPage   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:myDictionary     5   	   `controlsKclr-namespace:System.Windows.Controls;assembly=DotNetProjects.Input.Toolkit     62     � Title$  UserPage��5   	   $	��450��6   $	��800��6'   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��96* �6   �� 5      $	��24* �6   �� 5      $	��97* �6   .+�5   
   �� $��Give me a word��6   $
��Left=�6)   $��
282,85,0,0q�6D   $	��Top=�6X   $	��160��6p   $��20(�6|    J� RenderTransformOrigin$ 1.024,0.459&�6�   �� 5   
   -   5         ��Name$ searchButton��5      $��Search��6'   $
��Left=�68   $��443,149,0,0q�6S   $	��Top=�6h   $��41��6�   $��99��6�   $��14(�6�   6�   �� 5   
   -   5         ��Name$ 	outputBox��5      $
��Left=�6'   $��
208,47,0,0q�6B   $
��Wrap=�6V   $	��Top=�6j   $	��117��6�   $	��535��6�   ���	#FFE68383���	#FFE9E9E9$��2��6�   $��1��6�   �� 5   
   -   5         ��Name$ imageBox��5      $
��Left=�6"   $	��100��6=   $��	49,22,0,0q�6J   $	��Top=�6]   $	��100��6u   $��2��6�   �� 5   
   -   5         ��Name$ categoryBox��5      $
��Left=�6'   $��
49,145,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $	��Top=�6j   $	��694��6�   $��2��6�   �� 5   
   -   5         ��Name$ inputBox��5      	 �� Orientation$	 Vertical=�6'   $��219,149,404,37q�6>   $��2��6V   .+�5      -  'System.Windows.Controls.AutoCompleteBox  -   5        
  Name$
 autoCompleteBox��5   (   5      �� 5   
   -   5         ��Name$ categoryBox1��5      $
��Left=�6)   $��
10,148,0,0q�6D   $	��159��6X   6d   5      5      