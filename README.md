# Program Penjualan
Tujuan utama dari pembuatan program ini adalah untuk memenuhi Tugas uas dari matakuliah Pemrograman Lanjut yaitu mebuat aplikasi berdasarkan kasus atau studi kasus

## Fungsi
Untuk menghitung total dari menu yang dipilih setelah dikurang dengan promo yang tersedia

## Fitur
- User dapat melihat daftar makanan yang ditawarkan
- User dapat memasukkan atau menghapus makanan pilihan ke dalam keranjang
- User dapat melihat subtotal makanan yang terdapat pada keranjang
- User dapat melihat daftar voucher yang ditawarkan
- User dapat menggunakan salah satu voucher
- User dapat melihat harga total termasuk potongannya

## Class Diagram
![Class Diagram](https://github.com/hafit0/UASpemrog2765/blob/main/UASpemrog2765/diagram.png)

## Simulasi
- Simulasi 1  
![Simulasi 1](https://github.com/hafit0/UASpemrog2765/blob/main/1.PNG)  
- Simulasi 2  
![Simulasi 2](https://github.com/hafit0/UASpemrog2765/blob/main/2.PNG)  
- Simulasi 3  
![Simulasi 3](https://github.com/hafit0/UASpemrog2765/blob/main/3.PNG)  

## Penjelasan
- Terdapat 3 class dalam folder controller yaitu `MenuController.cs` , `PromoController.cs`, dan `MainWindowController.cs`. ketiganya berfungsi untuk menjebatani view dan Model
-- pada `MenuController.cs` terdapat 3 method yaitu `addItem();` yang berfungsi untuk menambahkan item pada list , kemudian `getItem();` yang berfungsi mengembalikan nilai dari `menuController()` item, dan yang terakhir adalah `menuItem()` berfungsi untuk menyimpan data yang sudah ditambahkan.
-- pada `PromoController`  terdapat 3 method yaitu `addPromo();` untuk menambahkan promo pada list, kemudian `getPromo();` untuk mengembalikan nilai pada list, dan `PromoController();` untuk menyimpan data sebagai list 
--
