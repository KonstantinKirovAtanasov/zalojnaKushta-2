   M S B A M L   `   `   `  ���� J  FzalojnaKushta 2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:zalojnaKushta_2zalojnaKushta_2  $    zalojnaKushta_2.EmployeeWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     /localclr-namespace:zalojnaKushta_2     -     �Name$  W�� � Title$ EmployeeWindow����. $
��1100��$	��850��$	��850��$	��960��.��(�  (� Stretch$
 Fill=� (� StretchDirection$ UpOnly=�.��� $��0��$��0��.+��� $��Сделки:��$
��Left=�$	��513��$	��Top=�$	��540��$��-536,-289,-4,-224q�.��&   System.Windows.Controls.DataGrid  -   $��DealsDataGrid��   AutoGenerateColumns .     SelectionMode$ Single=�   
IsReadOnly . $��0,10,-1,-0.4q����� *deals+ �� SelectedItem �� *selectedDeal+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn	   Header$		 №��1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 ��  �� Path$ ID�  $	 Вещ:��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 0.05* 
 �� $ ItemDesc�  $	 Клиент:��$ 0.05* 
 �� $ 
ClientName�  $	 Категория:��
 �� $ ItemType�  $	 	Цена:��
 �� $ Price�  $	 Вид Сделка:��
 �� $ DealType�  $#	 Дата на покупка:��
 �� $ 	DateOfBuy��� $��Заложено:��$
��Left=�$	��622��$	��Top=�$	��535��$��4,-398,-539,-224q�.��  -   $��PladgedDataGrid��$ Single=� . $��0,10,-2,0.6q� .  ���� *
pladgeds+ �� *selectedPladged+   $		 №��
 �� $ ID�  $	 Вещ��$ 0.05* 
 �� $ ItemDesc�  $	 Клиент��$ 0.05* 
 �� $ 
ClientName�  $	 Категория��
 �� $ ItemType�  $	 Оценка��
 �� $ Price�  $	 
Лихва��
 �� $ increaseForMonth�  $	 Върнато��
 �� $ returned�  $	 КраенСрок��
 �� $ DeadLine��� $��-536,-398,-4,294q�.��� $��0��$��0��.+��� $;��5Изхарчено за покупки за деня:��$��-242,19,57,-48q��� $;��5Изкарано от продажби за деня:��$��-242,-10,57,-19q��� $&�� Всичко похарчено:��$��20,19,-140,-48q��� $$��Всичко изкарано:��$��20,-10,-140,-19q��� $��Потребител:��$��20,-44,-120,15q��� $��	Дата:��$��-242,-44,199,15q��� -   $��DateTimeLabel��$��-194,-40,57,11q����� $
 date��� -   $��UserNameLabel��$��120,-44,-244,15q����� $ User.UserName��� -   $��GetFromTheDay��$��-44,-10,-15,-19q����� *	dayEarned+�� -   $��SpentForTheDay��$��-44,19,-15,-48q����� *
daySpent+�� -   $��
OverallGet��$��140,-10,-244,-19q����� $ User.earned��� -	   $��OverAllSpent��$��140,19,-244,-48q� J� RenderTransformOrigin$ 0.5,0.5&����� $ 
User.spent��� -
   $��AddDealButton��$��Добави��$��-536,229,376,-259q��� -   $��AddPladgetButton��$��Добави��$��4,229,-164,-259q��� -   $��MarkAsSelled��$2��,Отбележи като продадено��$��-371,229,210,-259q�$ 0.484,-1.897&��� -   $��IncomeForPladged��$"��Внасяне на пари��$��169,229,-329,-259q��� -   $��DeletePladged��$��Изтрий��$��356,229,-521,-259q��� $��Филтрирай��$��4,264,-539,-365q�$ 0.5,0.5&�.��� $��0,0,-2.8,-6.4q�.+��� $(��"Потребителско име:��$��10,10,375.2,49.8q��� -   $%��ClientNamePladgedsFilterTextBox�� �� MaxLines$ 1��$��10,40,375.2,14.8q��� $��Категория:��$��155,10,228.2,49.8q��� -   $#��FilterItemTypeComboBoxPladged��$��155,40,228.2,14.8q��� -   $��filterListPladged��$��Филтрирай��$��339,10,11.2,14.8q��� $��Филтрирай��$��-536,264,1,-365q�$ 0.5,0.5&�.��� $��0,0,-2.8,-6.4q�.+��� $(��"Потребителско име:��$��10,10,375.2,49.8q��� -   $��ClientNameDealFilterDeal��$��10,40,375.2,14.8q�$ 1���� $��Категория:��$��155,10,228.2,49.8q��� -   $ ��FilterItemTypeComboBoxDeal��$��155,40,228.2,14.8q��� -   $��filterListDeal��$��Филтрирай��$��328,10,11.2,14.8q��� -    ��Name$ 
DeleteDeal��$��Изтрий��$��-185,229,20,-259q�