   M S B A M L   `   `   `  ����B  >Cliente, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Cliente.ViewCliente.View  5   	       Cliente.View.MarcarCon   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Cliente.View     5   	     � Title$  	MarcarCon��5   	   $	��450��6   $	��800��6(   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��0* �6   �� 5      .+�5   
   �� -   5        $��Marcar��5      $��1��6"   $
��Left=�62   $��666,342,0,0q�6M   $	��Top=�6b   $��94��6z   $��25��6�   ���	#FF4568506�   �� 5   
   -   5         ��Name$ ComboBoxConv��5      $��2��6)   $
��Left=�6=   $��
42,295,0,0q�6X   $	��Top=�6l   $	��189��6�    J� RenderTransformOrigin$ 0.505,0.598&�6�    �� DisplayMemberPath$
 tipo��6�    �� SelectedValuePath$ 
idtipoconv��6�   �� 5   
   -   5        $ ComboBoxLoc��5      $��2��6(   $
��Left=�6<   $��
42,152,0,0q�6W   $	��Top=�6k   $	��188��6�   �� 5   
   -   5        $ ComboBoxProf��5      $��2��6)   $
��Left=�6=   $��
42,222,0,0q�6X   $	��Top=�6l   $	��189��6�   $
 nome��6�   $ utilizador_iduser��6�   �� 5   
   $��2��6   $��Convenção(Opcional)��6$   $
��Left=�6B   $��
42,264,0,0q�6]   $	��Top=�6q   $	��127��6�   �� 5   
   $��2��6   $��Local��6$   $
��Left=�64   $��
42,121,0,0q�6O   $	��Top=�6c   $��38��6{   �� 5   
   $��2��6   $��Profisional de saúde��6$   $
��Left=�6C   $��
42,191,0,0q�6^   $	��Top=�6r   $	��121��6�   �� 5   
   -   5        $��Voltar��5      $��1��6"   $
��Left=�62   $��
27,342,0,0q�6M   $	��Top=�6a   $��95��6y   $��25��6�   ���	#FF4568506�   �� 5   
   $��2��6   ���	#FFF4F4F5$
��Left=�69   $��4��6T   $��
27,333,0,0q�6_   
���   �$	��Top=�6�   $	��733��6�   �� 5   
   $
��Left=�6   $��
27,7,0,300q�6+   $	��109��6?   $��Img/logo.png��6K   $��2��6a   �� 5   
   $��2��6   ���	#FFF4F4F5$
��Left=�69   $��4��6T   $��
10,102,0,0q�6_   
���   �$	��Top=�6�   $	��750��6�   �� 5   
   $��2��6   $��Marcação de consulta��6$   $
��Left=�6C   $��
194,24,0,0q�6^   $	��Top=�6r   $��14(�6�   $
��Bold"�6�   �� 5   
   $��2��6   $7��1Faça aqui o seu pedido de marcação ou contacto��6$   $
��Left=�6]   $��
194,53,0,0q�6x   $	��Top=�6�   $��11(�6�   �� 5   
   $��2��6   $l��f*Alguns médicos/tratamentos podem não estar abrangidos pelos seguros/sistemas de saúde apresentados��6$   $
��Left=�6�   $��127,366,0,0q�6�   $	��Top=�6�   $��9(�6�   �� 5   
   $��2��6   $O��IPara mais informações sobre este assunto, por favor contacte a cliníca��6$   $
��Left=�6u   $��127,388,0,0q�6�   $	��Top=�6�   $��9(�6�   �� 5   
   $��2��6   $
��Data��6$   $
��Left=�63   $��561,122,0,0q�6N   $	��Top=�6c   $	��127��6{   &   System.Windows.Controls.Calendar  5   
   -   5          Name$ DataCalendary��5      $��2��6*   $
��Left=�6>   $��561,153,0,0q�6Y   $	��Top=�6n   $	��165��6�   $	��173��6�   �� 5   
   -   5         ��Name$ TextDescricao��5      $��2��6)   $
��Left=�6=   $��66��6X   $��304,159,0,0q�6d    �� TextWrapping$
 Wrap=�6y   $	��Top=�6�   $	��189��6�   �� 5    
   $��2��6   $��Descrição��6$   $
��Left=�68   $��304,129,0,0q�6S   $	��Top=�6h   �� 5!   
   -   5        $ ComboBoxTipoCon��5!      $��2��6,   $
��Left=�6@   $��304,295,0,0q�6[   $	��Top=�6p   $	��189��6�   $
 tipo��6�   $ idtipo��6�   �� 5"   
   $��2��6   $��Tipo de consulta��6$   $
��Left=�6?   $��304,264,0,0q�6Z   $	��Top=�6o   $	��121��6�   5$      5%      