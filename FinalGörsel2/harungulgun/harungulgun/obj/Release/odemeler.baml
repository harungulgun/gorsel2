   M S B A M L   `   `   `  ���� F  Bharungulgun, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:harungulgunharungulgun      harungulgun.odemeler   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:harungulgun       � Title$  odemeler��$��407.845��$��790.426��$��407.845��$��790.426��$��407.845��$��790.426��.��� $��0,0,3.5,1.5q� � RowDefinitions �� $
��164* ��� $
��107* � � ColumnDefinitions �� $
��111* ��� $
��416* �����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FF1D0A0A��$ 1Q�.+�o� -    o�Name$
 menu��$��30��$	��Top=�$��5.726,2.667,5.592,0q�$��2������ $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q�.@�m� $
��Ekle��$��19(�.@�m� -   $��Personel Ekle��$��15(����	#FF789974m� -   $��Personel Sil��$��15(����	#FF789974m� $��	Ürünler��$��19(�.@�m� -   $��Ürünleri Göster��$��15(����	#FF789974m� -   $��Ürün Girişi Yap��$��15(����	#FF789974m� -   $��
Ürün Sil��$��15(����	#FFBD3434m� $��Hesaplar��$��19(�.@�m� -   $��	Ödemeler�����	#FF789974m� -   $��
Gelen Para�����	#FF789974m� -	   $
��KASA�����	#FF789974m� -
   $��Anasayfa��$��19(��� -    ��Name$ odemetur��$��1��$��-45.09,46.5,0,0q�$	��Top=�$��21.96��$
��Left=�$	��159���� -   	 ��Name$	 label��$��Ödeme Türü:
��$��19.387,41.03,-13.652,0q�$	��Top=����	#FFBFBFBF$��30.269����Z� �� -   $	 
label_Copy��$��Ödeme Tipi:
��$"��18.72,85.343,-12.985,111.534q����	#FFBFBFBF��Z� �� -   $ 	odemetipi��$��1��$��-45.09,85.343,0,111.534q�$
��Left=�$	��159���� -   $	 label_Copy1��$��Açıklama Ekle:
��$��14.22,0,59.062,69.534q�$��Bottom=����	#FFBFBFBF$��30.269����Z� �� -   $	 label_Copy2��$��Tutar:
��$��18.22,0,51.515,-6.924q����	#FFBFBFBF$��29.727��$��Bottom=���Z� �� -   
 ��Name$
 tutar��
�������$��25.861��$��-45.09,0,0,0q� �� TextWrapping$
 Wrap=�$�� ��$��Bottom=� � ToolTip$ Tc numarası Gir��$
��Left=�$	��157��$��1��&   System.Windows.Controls.DataGrid  -     Name$ odemelistele��$��1��$��131.938,48,28.426,69.291q�$��2���� -    ��Name$ 	odemeekle��$��Ödemeyi Gerçekleştir
��$"��45.195,39.555,-82.702,69.291q�$��20(�$��Italic$�$��1�� J� 	CacheMode &   System.Windows.Media.BitmapCache   � BindingGroup &   System.Windows.Data.BindingGroup  ���� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q��� -   $ 
odemeyisil��$��Seçili Ödemeyi Sil��$��0,0,28.426,24.938q�$��20(�$��Italic$�$��1��$��1��$��39.353��$��Bottom=�$��Right=�$��260.5��      ���� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q��� -   $
 aciklama��
�������$��53.249��$��-47.09,0,0,42.146q�$
 Wrap=�$�� ��$��Bottom=�$ Tc numarası Gir��$
��Left=�$	��159��$��1��