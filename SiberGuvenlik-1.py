# -*- coding: utf-8 -*-
"""
Created on Thu Oct 19 10:19:00 2023

@author: fnsss
"""

"""
Python proglama dili diğer progralama dillerinde olduğu gibi
input output şeklinde çalışır
inputlar değişken tanımlanır.
Diğer programlama dillerinden pythonı ayıran özellik ise değişken tipi 
yazmaya gerek yoktur.
int a = 5;
a=5
python programlama dilinde iki türlü değişken değer alır.
1- Varsayılan değer  = a=5
2- Kullanıcıdan çekilen değerler vardır.
"""
"""
a = 5 
print(5)"""
"""
Varsayılan python değişken tanımlama örneğidir.
"""
"""
sayi1 = input("1. Sayıyı giriniz : ")
sayi2 = input("2. Sayıyı giriniz : ")
toplam = int(sayi1)+int(sayi2)
print(toplam)"""
"""
Kullanıcıdan aldığımız her bir input değeri bize string olarak gelir
yani terminalden ne değer gelirse gelsin metin olrak geliyor.
biz bunları istedğimiz değişken tipine convert edebiliriz.
bu dönüştürme yöntemi nasıl yapılır toplam = int(sayi1)+int(sayi2)
metinsel ifadelerde toplama operatörü kullanıldığında metinin kaldığı yerden ekleme yapar
"""
"""sayi="5"
sayi3="6"
print(sayi+sayi3)"""
"""
Girilen iki sayının ortalamasını bulan python örneği
"""
sayi1 =input("1. Sayıyı Giriniz : ")
sayi2 = input("2. Sayıyı Giriniz : ")
ortalama = (int(sayi1)+ int(sayi2))/2
print("Ortalama : {0}" .format(ortalama))