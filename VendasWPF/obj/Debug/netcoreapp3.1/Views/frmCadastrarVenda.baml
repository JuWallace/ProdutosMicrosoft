   M S B A M L   `   `   `  ����D  @VendasWPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:VendasWPF.ViewsVendasWPF.Views  5   	   '    !VendasWPF.Views.frmCadastrarVenda   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:VendasWPF.Views     5   	   -   5          � Title$  Cadastrar Venda��5   	    � WindowStartupLocation$ CenterScreen=�6!   $��Medium"�6F   $��16(�6Z   $	��496��6h   $	��443��6u   .��5	      � $��0,0,10,0q�6   .+�5
   
   �� -   5         ��Name$ cboClientes��5
      $
��Left=�6(   $��	10,85,0,0q�6C   $	��Top=�6V   $	��197��6n   �� 5   
   -   5         ��Name$ btnAdicionar��5      $��	Adicionar��6'   $
��Left=�6;   $��318,153,0,0q�6V   $	��Top=�6k   $��27��6�   $��99��6�   6�   �� 5   
   $��18(�6   $��Cadastrar Venda��6   $
��Left=�68   $��	10,10,0,0q�6S   $	��Top=�6f   �� 5   
   -   5         ��Name$ txtQuantidade��5      $
��Left=�6)   $��215,153,0,0q�6D    �� TextWrapping$
 Wrap=�6Y   $	��Top=�6m   $��97��6�   $��27��6�   �� 5   
   $��Clientes��6   $
��Left=�6#   $��	10,49,0,0q�6>   $	��Top=�6Q   �� 5   
   -   5        $ cboVendedores��5      $
��Left=�6*   $��
220,85,0,0q�6E   $	��Top=�6Y   $	��197��6q   �� 5   
   $��
Vendedores��6   $
��Left=�6%   $��
220,49,0,0q�6@   $	��Top=�6T   �� 5   
   -   5        $ cboProdutos��5      $
��Left=�6(   $��
13,153,0,0q�6C   $	��Top=�6W   $	��197��6o   �� 5   
   $��Produtos��6   $
��Left=�6#   $��
13,117,0,0q�6>   $	��Top=�6R   �� 5   
   $��
Quantidade��6   $
��Left=�6%   $��215,117,0,0q�6@   $	��Top=�6U   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dtaProdutos��5      $
��Left=�6(   $	��Top=�6C   $	��166��6[   $	��404��6h   $��
13,185,0,0q�6t   5      5      