   M S B A M L   `   `   `  ���� F  Bharungulgun, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:harungulgunharungulgun      harungulgun.urungiris   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     +localclr-namespace:harungulgun       � Title$  	urungiris��$��498.507��$��923.729��$��498.507��$��923.729��$��498.507��$��923.729������  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FF1D0A0A��$ 1Q�.��� $��0,0,71.729,0q����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FF1D0A0A��$ 1Q�.+��� -    ��Name$ urunad��
�������$��25.861��$��168.255,57.889,0,0q� �� TextWrapping$
 Wrap=�$�� ��$	��Top=� � ToolTip$ Tc numarası Gir��$
��Left=�$��174.105���� -   $ urunadet��
�������$��25.861��$��168.255,109.611,0,0q�$
 Wrap=�$	��Top=�$ Personel Adını Gir��$
��Left=�$��174.105���� -   $ urunuret��
�������$
 Wrap=�$�� ��$ Personel Soyadını Gir��$��167.255,149.241,0,0q�$��25.86��$	��Top=�$
��Left=�$��174.105���� -    ��Name$ label��$��Ürün Adı:
��$��21.72,56.53,0,0q�$	��Top=����	#FFBFBFBF$��30.269��$
��Left=�$��105.356����Z� �� -   $ 
label_Copy��$��Ürün Adedi:
��$��21.72,103.513,0,0q����	#FFBFBFBF$
��Left=�$��75.891��$��39.353��$	��Top=���Z� �� -   $ label_Copy1��$��Üretici Firma:
��$��20.72,148.987,0,0q�$	��Top=����	#FFBFBFBF$��30.269��$
��Left=�$��75.891����Z� �� -   $ label_Copy2��$��Giriş Tarihi:
��$��20.16,0,0,144.479q����	#FFBFBFBF$
��Left=�$��75.891��$��39.352��$��Bottom=���Z� �� -   	 ��Name$	 urunekle��$
��Ekle��$��139.695,0,0,72.953q�$��Bottom=�$��39.353��$��20(�$��Italic$�$
��Left=�$��116.069��
 J� 	CacheMode
 &   System.Windows.Media.BitmapCache   � BindingGroup &   System.Windows.Data.BindingGroup  ���� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q�&   System.Windows.Controls.DataGrid  -	     Name$ 
urungoster��$"��366.76,57.889,-55.771,23.486q����	#FF78705A���	#FF0675E0���	#FF3E6430�� -
   $ 
urunbarkod��
�������$
 Wrap=�$�� ��$  Kullanıcı Adını Gir��$��167.035,193.279,0,0q�$��25.86��$	��Top=�$
��Left=�$��174.105���� -   $ 	urunfiyat��
�������$
 Wrap=�$ 
Tarihi Gir��$��167.035,245.001,0,0q�$��25.86��$	��Top=�$
��Left=�$��174.105���� -   $ label_Copy4��$��Barkod Numarası:

��$��19.5,187.733,0,0q����	#FFBFBFBF$
��Left=�$��110.891��$��39.352��$	��Top=���Z� �� -   $ label_Copy5��$��
Fiyatı:
��$��23.5,0,0,189.414q����	#FFBFBFBF$
��Left=�$��83.035��$��43.852��$��Bottom=���Z� (  "System.Windows.Controls.DatePicker  -   $��
giristarih��$��168,0,0,158.447q�$��Bottom=�$��24.031��$
��Left=�$��179.64��o� -    o�Name$
 menu��$��30��$	��Top=�$��6.726,8.667,-65.605,0q����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ White��$ 1Q�.@�m� $
��Ekle��$��19(�.@�m� -   $��Personel Ekle��$��15(����	#FF789974m� -   $��Personel Sil��$��15(����	#FF789974m� $��	Ürünler��$��19(�.@�m� -   $��Ürünleri Göster��$��15(����	#FF789974m� -   $��Ürün Girişi Yap��$��15(����	#FF789974m� -   $��
Ürün Sil��$��15(����	#FFBD3434m� $��Hesaplar��$��19(�.@�m� -   $��	Ödemeler�����	#FF789974m� -   $��
Gelen Para�����	#FF789974m� -   $
��KASA�����	#FF789974m� -   $��Anasayfa��$��19(�