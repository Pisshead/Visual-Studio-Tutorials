   M S B A M L   `   `   `  ����   WPFAnimDreiDRotation%    WPFAnimDreiDRotation.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$  
MainWindow��$	��200��$	��300�� � 	Resources  	  SbRes g� RepeatBehavior �� 
TargetName �� TargetProperty g� Duration g� AutoReverse �� From �� Axis	 �� Angle	
 �� To g� 	BeginTime��%�  &	        �� $ Forever��.���� $
 Rt3d��$ Rotation�$ 0:0:5D� .  �� $ 1,0,05�$	 0Q�
 �� $ 1,0,05�$		 180Q��� $
 Rt3d��$ Rotation�$ 0:0:5D�$ 0:0:10X� .  �� $ 0,1,05�$	 0Q�
 �� $ 0,1,05�$		 180Q��� $
 Rt3d��$ Rotation�$ 0:0:5D�$ 0:0:20X� .  �� $ 0,0,15�$	 0Q�
 �� $ 0,0,15�$		 180Q� � Triggers :�  :� RoutedEvent$ Loaded��.[��� #��[  .��'�  '� Camera P�  � Position$ 1,3,51� � LookDirection$ -1,-3,-55� P� Width$ 6Q�x�g�  g� Content t�  �� Color$ White�� t� 	Direction$ -1,-3,-55�g�  �  � Geometry k�  k� 	Positions- �    k� TriangleIndices �     	

 � Material u�  u� Brush
 ����� � BackMaterial u� 
 �  �� j� 	Transform �� -   Rt3d�� �� Rotation �� 