using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace deneme
{
    public class metod
    {
        string prsnltakip = "Server=localhost;DATABASE=prsnltakip;UID=root;PWD=''";
        public int KullaniciKontrol(  string kad, string ksifre)
            
        {
            
            int sonuc = 0;
            using (var con= new MySqlConnection(prsnltakip)) 
            {
                using (var cmd= new MySqlCommand($"SELECT kullaniciadi, sifre FROM kullanici  WHERE kullaniciadi='{kad}'AND sifre='{ksifre}'",con))
                {
                    try
                    {
                        cmd.Connection.Open();
                        MySqlDataReader dtr= cmd.ExecuteReader();
                        if (dtr.Read()) 
                        {
                           
                            string d_k = dtr["kullaniciadi"].ToString();
                            string d_s = dtr["sifre"].ToString();
                            if(d_k==kad && d_s==ksifre)
                            {
                                sonuc = 1;
                            }
                            else
                            {
                                sonuc = 0;
                            }
                        }
                        
                    }
                    catch
                    {

                        sonuc = 0;
                    }
                }
            }
            return sonuc;
        }  
    }
}

public class metod2
{
    string prsnltakip = "Server=localhost;DATABASE=prsnltakip;UID=root;PWD=''";
    public int KullaniciKontrol(string kad, string ksifre)

    {

        int sonuc = 0;
        using (var con = new MySqlConnection(prsnltakip))
        {
            using (var cmd = new MySqlCommand($"SELECT kullaniciadi, sifre FROM yonetici  WHERE kullaniciadi='{kad}'AND sifre='{ksifre}'", con))
            {
                try
                {
                    cmd.Connection.Open();
                    MySqlDataReader dtr = cmd.ExecuteReader();
                    if (dtr.Read())
                    {
                        string d_k = dtr["kullaniciadi"].ToString();
                        string d_s = dtr["sifre"].ToString();
                        if (d_k == kad && d_s == ksifre)
                        {
                            sonuc = 1;
                        }
                        else
                        {
                            sonuc = 0;
                        }
                    }

                }
                catch
                {

                    sonuc = 0;
                }
            }
        }
        return sonuc;
    }
}


