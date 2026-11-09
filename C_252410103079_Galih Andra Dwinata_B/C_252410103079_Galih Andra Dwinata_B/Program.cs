using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Agen
{
    string idAgen;
    string namaAgen;
    string stokAgen;

    public void TampilInfo(string IdAgen, string NamaAgen, string StokAgen)
    {
        IdAgen = idAgen;
        NamaAgen = namaAgen;
        StokAgen = stokAgen;

        Console.WriteLine($"");
    }
}

public abstract class ProdukGalon
{   
    public string idProduk {  get; private set; }
    public string namaProduk {  get; private set; }
    public int stokGudang
    {
        get
        {
            return stokGudang;
        }
        private set
        {
            stokGudang = value;

            if (value > 0)
            {
                Console.WriteLine($"Stok awal: {value}");
            }
            else
            {
                Console.WriteLine("Stok harus lebih dari 0");
            }
        }
    }
    public void KurangiStok(int jumlah)
    {
        Console.WriteLine();
    }

    public virtual void HitungBiaya(int jumlah)
    {
        Console.WriteLine();
    }
}

public class GalonAkua : ProdukGalon
{
    public string idProduk;
    public string namaProduk;
}

public class GalonBerkeran : ProdukGalon
{

} 

interface DapatDidistribusikan
{
    public void KirimPaket()
    {
        Console.WriteLine();
    }
}

public class DistribusiGalon
{
    
}

class Program
{
    public void Main(string[] args)
    {
        Agen agen = new Agen()
    }
}


