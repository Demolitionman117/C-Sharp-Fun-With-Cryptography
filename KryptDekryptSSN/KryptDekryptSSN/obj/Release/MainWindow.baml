   M S B A M L   `   `   `  ���� J  FKryptDekryptSSN, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:KryptDekryptSSNKryptDekryptSSN       KryptDekryptSSN.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     /localclr-namespace:KryptDekryptSSN     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006       � Title$  RSA-Kryptering��$��Center=�$��Center=� � WindowStartupLocation$ CenterScreen=� � SizeToContent$ WidthAndHeight=� � 
ResizeMode$ CanMinimize=� J� SnapsToDevicePixels . .��� $
��10,0q� � ColumnDefinitions �� $	��12* ��� -    ��Name$ Rsa_Kryptering��$
��200* ��� $
��305* �.+�� -    �Name$ ProgressBar��$
��Left=�$��18��$��0,0,0,5q�$��Bottom=�$	��150��$��2�� � SmallChange$ 1Q�	 � Cursor$
	 None��
 J� RenderTransformOrigin$
 0.5,0.5&�z�V� .~��� �� ��  �� Angle$ -0.017Q�T� �� -    ��Name$ StackPanel_status��$��1��$
��Left=�$��25��$��130.288,0,0,2q�$��Bottom=� �� Orientation$ 
Horizontal=�.+��� $��Status:��$��Bottom=�$��43��$��10(�$
��Left=��� -    ��Name$ Status_Label��$
��Redo��$
��Left=�$��Bottom=�$��10(�]� -    ]�Name$ TopPaneL��$��Center=���.  $��50q�$	��Top=�$��2��$��1��$	��463��.+��� $��15��$
��Wrap=�$	��147��$��Center=�$��Center=�$	��Top=�$��	78,0,98,0q�$��Arial Black)�$
��Bold"�$��Vad vill du Kryptera? �����	#FF040000�� -    ��Name$ PlainTextBox�� �� TextWrapping$
 Wrap=�$	��Top=�$��Center=�$	��Top=�$��Comic Sans MS)�$��	Ange Text��$ �� HorizontalScrollBarVisibility$ Visible=�" �� VerticalScrollBarVisibility$
 Auto=�$��	0,10,0,30q�$	��200���� -   $ DeCryptedTextBox��$��Center=�$
 Wrap=�$��Dekrypterad text��$��Bottom=�$��Bottom=����	#FFFF1288$
 Auto=�$	��200���� -   $ CryptedTextBox��$
 Wrap=�$��Krypterad text��$��Bottom=�$��Center=�$��Bottom=�$��	0,30,0,10q�$	��200��$
 Auto=��� $��Center=�$
��0,20q�$��Center=�.+��� $��17��$
��Wrap=�$	��Top=�$��10,0,0,0q�$
��Left=��� $�Storlek på ���� $�p���� $� ���� $�i���� $� ���� $	�sif���� $
�fror���� -	    ��Name$ PSlider��$��30��$��Center=�$	��355��$��	40,0,49,0q� � Maximum$ 6Q� �� AutoToolTipPlacement$ TopLeft=� � Value$ 1Q� � Minimum$ 3Q�$��Center=�$ 1Q� �� TickPlacement$ TopLeft=� � ToolTip$- 'Större P kan ge längre kryptrings tid���� $��16��$
��Wrap=�$	��Top=�$��10,0,0,0q�$
��Left=��� $�Storlek på ���� $�q���� $� ���� $�i���� $� ���� $
�siff���� $	�ror���� -
   $ QSlider��$��Center=�$��Center=�$��	40,0,49,0q�$ 6Q�$ 1Q�$ 3Q�$ 1Q�$	��355��$��32��$ TopLeft=�$ BottomRight=�$. (Större Q kan ge längre krypterings tid��c� $
��Left=�$��-10,0q�$	��Top=�$��3��$��28��$	��740��$��Värden�����	#FF2D2D30���	#FF569CD6.@��� 
���   �����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ White��$ 1Q��� -   $ TaskBar_StackPanel��$
��Left=�$��0,0,0,-3q�$	��Top=�$ 
Horizontal=�$��26��.+��� $��N:��$��29��$	��Top=�$��0q�$
��Left=����	#FFF1F1F1�� -   $ N_ValueTextBox��$
��Left=�$��Center=�
���  ��$��73��$��0q�$��3,0,0,0q���. $	��N/A���� -   $ TaskBar_StackPanel2E��$
��Left=�$��0,0,0,-3q�$	��Top=�$ 
Horizontal=�$��26��.+��� $��E:��$��29��$	��Top=�$��0q�$
��Left=����	#FFF1F1F1�� -   $ E_ValueTextBox��$
��Left=�$��Center=����	#FF1FE400$��45��$��0q�$��3,0,0,0q���. $	��N/A��$	��0,5q��� -   $ TaskBar_StackPanel_3D��$
��Left=�$��0,0,0,-3q�$	��Top=�$ 
Horizontal=�$��26��.+��� $��D:��$��29��$	��Top=�$��0q�$
��Left=����	#FFF1F1F1�� -   $ D_ValueTextBox��$
��Left=�$��Center=����	#FFBE0FFF$��73��$��0q�$��3,0,0,0q���. $	��N/A���� -   $ TaskBar_StackPanel_4Phin��$
��Left=�$��0,0,0,-3q�$	��Top=�$ 
Horizontal=�$��26��.+��� $��Φ(N):��$��29��$	��Top=�$��0q�$
��Left=����	#FFF1F1F1�� -   $ Phin_ValueTextBox��$
��Left=�$��Center=����	#FF2B3EFF$��73��$��0q�$��3,0,0,0q���. $	��N/A���� -   $ TaskBar_StackPanel_5P��$
��Left=�$��0,0,0,-3q�$	��Top=�$ 
Horizontal=�$��26��.+��� $��P:��$��29��$	��Top=�$��0q�$
��Left=����	#FFF1F1F1�� -   $ P_ValueTextBox��$
��Left=�$��Center=����	#FFEC925E$��73��$��0q�$��3,0,0,0q���. $	��N/A���� -   $ TaskBar_StackPanel_6Q��$
��Left=�$��0,0,0,-3q�$	��Top=�$ 
Horizontal=�$��26��.+��� $��Q:��$��29��$	��Top=�$��0q�$
��Left=����	#FFF1F1F1�� -   $ Q_ValueTextBox��$
��Left=�$��Center=����	#FF2DE5F7$��73��$��0q�$��3,0,0,0q���. $	��N/A���� 
���   �$��0,2,4,2q����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q��� -   $ TaskBar_StackPanel_OM��$
��Left=�$��0,0,0,-3q�$	��Top=�$ 
Horizontal=�$��26��.+��� -    ��Name$ Om��$��Om��$��47��$��Center=�$��Center=�$��0,0,0,2q����	#FF7AC1FF���	#FF2D2D30
��������� $��2��$��Right=�$��	0,0,10,10q�$��Bottom=�$ 
Horizontal=�.+��� -   $ 	Btn_Abort��$��Avbryt/Återställ��$
��Left=�$��Bottom=�$��91��$��0,0,10,0q��� -   $ 	Btn_Crypt��$��Kryptera/Dekryptera��$��10,0,0,0q�$��Bottom=�$	��116��$��Right=�$��Center=��� $
��Left=�$��16��$��-10,18,-10,0q�$	��Top=�$	��740��$��3��$
 0.504,-0.851&�