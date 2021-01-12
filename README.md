## 19.11.2765 
## Hafit Abekrori
## 19-S1IF-03



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
  - pada `MenuController.cs` terdapat 3 method yaitu `addItem();` yang berfungsi untuk menambahkan item pada list , kemudian `getItem();` yang berfungsi mengembalikan nilai dari `menuController()` item, dan yang terakhir adalah `menuItem()` berfungsi untuk menyimpan data yang sudah ditambahkan.
  - pada `PromoController`  terdapat 3 method yaitu `addPromo();` untuk menambahkan promo pada list, kemudian `getPromo();` untuk mengembalikan nilai pada list, dan `PromoController();` untuk menyimpan data sebagai list 
  -pada `MainWindowController.cs` berfungsi untuk menambahkan Item dan Promo ke view, kemudian menghapus item dari view, dan selain itu untuk menampilkan item dan promo yang dipilih


- Kemudian pada Model terdapat 4 Class yaitu `Item.cs`, `KeranjangBelanja.cs`, `Payment,cs`, dan `Promo.cs`
  - pada `Item.cs` berfungsi untuk menampung itemnya
  - pada `Promo.cs` berfungsi untuk menampung promonya
  - pada `KeranjangBelanja.cs` Berfungsi untuk menampung item dan promo yang dipilih dan terdapat logika perhitungan jumlah subtotal
  ``` private void calculateSubTotal()
        {
            double subTotal = 0;
            
            foreach (Item item in itemkeranjangBelanja)
            {
                subTotal += item.price;
                
            }
            payment.updateTotal(subTotal);
        } 
   ```
  - pada `Payment.cs` berfungsi untuk menampung logika perhitungan banyak promo yang didapat dan logika perhitungan total dari subtotal dan promo 
  ``` public void updateTotal(double subTotal)
        {
            double promo = 0;

            foreach (Promo promos in promodigunakan)
            {
                if (promos.potongan == 1)
                {
                    promo = (subTotal * 25 / 100);
                }
                else if (promos.potongan == 2)
                {
                   
                    promo = (subTotal * 30 / 100);

                    if(promo > 30000)
                    {
                        promo = 30000;
                    }
                }
                else if (promos.potongan == 3)
                {
                    promo = 10000;
                    
                }
                
            }

            double total = subTotal - promo;
            this.paymentListener.onPriceUpdated(subTotal, total);
            
        } 
  ```

- kemudiann terdapat 3 class untuk mengatur logika taampilannya yaitu `Menu.xaml.cs`, `Promo.xaml.cs`, dan `MainWindow.xaml.cs` 

  - pada `Menu.xaml.cs` terdapat penambahan item untuk dijadikan list berserta harganya yaitu 
``` private void generateContentMenu()
        {
            Item menu1 = new Item("Coffe Late", 30000);
            Item menu2 = new Item("Black Tea", 20000);
            Item menu3 = new Item("Pizza", 75000);
            Item menu4 = new Item("Milk Shake", 15000);
            Item menu5 = new Item("Fried Frice Special", 45000);
            Item menu6 = new Item("Watermelon Juice", 25000);
            Item menu7 = new Item("Lemon Squash", 30000);

            menuController.addItem(menu1);
            menuController.addItem(menu2);
            menuController.addItem(menu3);
            menuController.addItem(menu4);
            menuController.addItem(menu5);
            menuController.addItem(menu6);
            menuController.addItem(menu7);

            listMenu.Items.Refresh();

        }
```
  - pada `Promo.xaml.cs` terdapat penambahan promo untuk dijadikan list yaitu pada
  
  ```  private void generateContentPromo()
        {
            Model.Promo promo1 = new Model.Promo("Promo Awal tahun Diskon 25 % ", 1);
            Model.Promo promo2 = new Model.Promo("Promo Tebus Murah Diskon 30 % atau maksimal 30.000", 2);
            Model.Promo promo3 = new Model.Promo("Promo Natal Potongan 10000", 3);

            promoController.addPromo(promo1);
            promoController.addPromo(promo2);
            promoController.addPromo(promo3);

            listBoxDaftarPromo.Items.Refresh();
        } 
  ```
 - pada `MainWindow.xaml.cs`terdapat logika dari event misalkan penghapusan item yang sudah dipilih terdapat pada
 ```
 private void onlistKeranjangBelanjaDoubleClicked(object sender, MouseButtonEventArgs e)
        {
            if (MessageBox.Show("Apakah kamu ingin menghapus item ini?",
                   "Konfirmasi", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ListBox listBox = sender as ListBox;
                Item item = listBox.SelectedItem as Item;
                controller.removeItem(item);
            }
        }
 ```
