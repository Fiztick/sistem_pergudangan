# Sistem Pergudangan
Pembuatan Sistem Pergudangan oleh Kelompok 4
## Link Panduan Project Akhir Pemrograman Visual
https://docs.google.com/document/d/19GLPqn6FGpnMx4cDTkt0vKoZDQ6YaGBKa8BFSxH-RNw/edit

## Class :
Users
Barang
Jenis Barang
Order
Masuk

## Form :
Sign In
Sign Up

Form Jenis Barang (Data Grid View Jenis Barang)
Form Add Jenis Barang
Form Edit Jenis Barang
Form Hapus Jenis Barang

Form Barang (Data Grid Show Data Barang)
Form Add Barang
Form Edit Barang
Form Hapus Barang

Form Order Barang
Form Add Order Barang
Form Hapus Order Barang

Form Masuk Barang
Form Tambah Barang Masuk
Form Hapus Barang Masuk

## Fitur :
User adalah orang yang maintain data gudang / administrasi gudang
Data Barang merupakan katalog barang yang ada di gudang dengan jumlah yang ada di gudang
Jenis Barang merupakan jenis barang yang ada di gudang dan satuannya (box, pieces, kapsul, botol, etc.)
Order merupakan permintaan dari administrasi gudang apabila stok barang yang ada di gudang habis
Barang Masuk merupakan pemenuhan / pemberian order dari gudang dengan jumlah nya


## Table :
User (id, user_name, email, password)
Jenis Barang (id_jenis_barang, jenis_barang, satuan)
Barang (id_barang, id_jenis_barang, barang, stock)
Order (id, id_barang, tanggal order, jumlah order, status)
Barang Masuk (id, id_order, jumlah masuk)
