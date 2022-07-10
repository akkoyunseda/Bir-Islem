using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rand = new Random();
        int r1, r2, r3, r4, r5, r6;
        int hedef, sonuc, carpim;

        // Sayı getir butonuna tıklandığında
        private void btngetir_Click(object sender, EventArgs e)
        {
            label19.Text = "";

            label18.Visible = false;

            textBox8.Text = "";

            

            textBox1.Text = Convert.ToString(rand.Next(1, 9));
            textBox2.Text = Convert.ToString(rand.Next(1, 9));
            textBox3.Text = Convert.ToString(rand.Next(1, 9));
            textBox4.Text = Convert.ToString(rand.Next(1, 9));
            textBox5.Text = Convert.ToString(rand.Next(1, 9));
            textBox6.Text = Convert.ToString(rand.Next(1, 9) * 10);
            textBox7.Text = Convert.ToString(rand.Next(100, 999));

            r1 = Convert.ToInt32(textBox1.Text);
            r2 = Convert.ToInt32(textBox2.Text);
            r3 = Convert.ToInt32(textBox3.Text);
            r4 = Convert.ToInt32(textBox4.Text);
            r5 = Convert.ToInt32(textBox5.Text);
            r6 = Convert.ToInt32(textBox6.Text);

            hedef = Convert.ToInt32(textBox7.Text);


        }



        public int kalan_bul(int [] dizi, int kalan)
        {
            int bul_kalan = 0;
            
            

            //verilen sayılardan kalan sayıyı bulma
            for (int i = 0; i < 6; i++)
            {
                if (dizi[i] == kalan)
                {
                    kalan = dizi[i] ;
                    bul_kalan = 1;
                    
                }
                if (bul_kalan == 1) break;
            }

            

            //toplama işlemi ile kalan sayıyı bulma
            if(bul_kalan != 1)
            {
                for (int i = 0; i < 6; i++)
                {


                    for (int j = 0; j < 6; j++)
                    {
                        if ((dizi[i] + dizi[j]) == kalan)
                        {
                            kalan = (dizi[i] + dizi[j]);
                            bul_kalan = 1;
                            label19.Text += Convert.ToString(dizi[i]) + " + " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(kalan) + "\n";

                        }
                        if (bul_kalan == 1) break;
                    }
                    if (bul_kalan == 1) break;
                }
            }


            //Çıkarma işlemi le kalan sayıyı bulma
            if (bul_kalan != 1)
            {
                for (int i = 0; i < 6; i++)
                {


                    for (int j = 0; j < 6; j++)
                    {
                        if ((dizi[i] - dizi[j]) == kalan)
                        {
                            kalan = (dizi[i] - dizi[j]);
                            label19.Text += Convert.ToString(dizi[i]) + " - " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(kalan) + "\n";

                            bul_kalan = 1;

                        }
                        if (bul_kalan == 1) break;
                    }
                    if (bul_kalan == 1) break;
                }
            }


            //çarpma işlemi ile kalan sayıyı bulma
            if (bul_kalan != 1)
            {
                for (int i = 0; i < 6; i++)
                {


                    for (int j = 0; j < 6; j++)
                    {
                        if ((dizi[i] * dizi[j]) == kalan)
                        {
                            kalan = (dizi[i] * dizi[j]);
                            bul_kalan = 1;
                            label19.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + 
                            " = " + Convert.ToString(kalan) + "\n";

                            
                          
                        }
                        if (bul_kalan == 1) break;
                    }
                    if (bul_kalan == 1) break;
                }
            }

           
            //bölme işlemi ile kalan değeri bulma
            if (bul_kalan != 1)
            {
                for (int i = 0; i < 6; i++)
                {


                    for (int j = 0; j < 6; j++)
                    {
                        if ((dizi[i] / dizi[j]) == kalan)
                        {
                            kalan =  (dizi[i] / dizi[j]);
                            label19.Text += Convert.ToString(dizi[i]) + " / " + Convert.ToString(dizi[j]) + 
                                " = " + Convert.ToString(kalan) + "\n";
                            bul_kalan = 1;
                           
                        }
                        if (bul_kalan == 1) break;
                    }
                    if (bul_kalan == 1) break;

                }
            }

            //üç sayı ile kalan elde etme işlemi
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {

                        if (dizi[i] + dizi[j] + dizi[k] == kalan)
                        {
                            kalan = dizi[i] + dizi[j] + dizi[k];
                            bul_kalan = 1;
                            label19.Text += Convert.ToString(dizi[i]) + " + " + Convert.ToString(dizi[j]) + 
                            " + " + Convert.ToString(dizi[k]) + " = " + Convert.ToString(kalan) + "\n";


                        }
                        if (bul_kalan == 1) break;

                        if (dizi[i] + dizi[j] - dizi[k] == kalan && bul_kalan != 1)
                        {
                            kalan = dizi[i] + dizi[j] - dizi[k];
                            bul_kalan = 1;
                            label19.Text += Convert.ToString(dizi[i]) + " + " + Convert.ToString(dizi[j]) + 
                            " - " + Convert.ToString(dizi[k]) + " = " + Convert.ToString(kalan) + "\n";


                        }
                        if (bul_kalan == 1) break;
                        if (dizi[i] * dizi[j] * dizi[k] == kalan && bul_kalan != 1)
                        {
                            kalan = dizi[i] * dizi[j] * dizi[k];
                            bul_kalan = 1;
                            label19.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + 
                            " * " + Convert.ToString(dizi[k]) + " = " + Convert.ToString(kalan) + "\n";


                        }
                        if (bul_kalan == 1) break;
                        if (dizi[i] * dizi[j] + dizi[k] == kalan && bul_kalan != 1)
                        {
                            kalan = dizi[i] * dizi[j] + dizi[k];
                            bul_kalan = 1;
                            label19.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + 
                            " + " + Convert.ToString(dizi[k]) + " = " + Convert.ToString(kalan) + "\n";


                        }
                        if (bul_kalan == 1) break;
                        if (dizi[i] * dizi[j] - dizi[k] == kalan && bul_kalan != 1)
                        {
                            kalan = dizi[i] * dizi[j] - dizi[k];
                            bul_kalan = 1;
                            label19.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + 
                            " - " + Convert.ToString(dizi[k]) + " = " + Convert.ToString(kalan) + "\n";


                        }

                        if (bul_kalan == 1) break;

                    }

                    if (bul_kalan == 1) break;
                }

                if (bul_kalan == 1) break;
            }


            if (bul_kalan == 1)
            {
                return kalan;
            }
            else
            {
                return kalan = 0;
            }




        }
        
       
       
        
        ///Hesapla butonuna basıldığında
        private void button1_Click(object sender, EventArgs e)
        {
            label18.Visible = false;

            int bul = 0;

            sonuc= 0;

            if (
                 textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" &&
                 textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && 
                 textBox7.Text != "" && Convert.ToInt32(textBox6.Text) > 9 && 
                 Convert.ToInt32(textBox6.Text) < 100 && Convert.ToInt32(textBox6.Text) % 10 == 0 &&
                 Convert.ToInt32(textBox7.Text) > 99 && Convert.ToInt32(textBox7.Text) < 1000
               )
            {
                r1 = Convert.ToInt32(textBox1.Text);
                r2 = Convert.ToInt32(textBox2.Text);
                r3 = Convert.ToInt32(textBox3.Text);
                r4 = Convert.ToInt32(textBox4.Text);
                r5 = Convert.ToInt32(textBox5.Text);
                r6 = Convert.ToInt32(textBox6.Text);
                hedef = Convert.ToInt32(textBox7.Text);

                carpim = r1 * r2 * r3 * r4 * r5 * r6;

                if(carpim < hedef)
                {
                    MessageBox.Show("Hedef bulunamaz!");
                    
                }



                //sayıları diziye aktarama işlemi

                int[] dizi = { r1, r2, r3, r4, r5, r6, hedef };

                int temp;


                //bubble sort ile dizi sıralanması

                for (int i = 1; i < 7; i++)
                {
                    for (int j = 0; j < 7 - i; j++)
                    {
                        if (dizi[j] > dizi[j + 1])
                        {
                            temp = dizi[j];
                            dizi[j] = dizi[j + 1];
                            dizi[j + 1] = temp;
                        }
                        
                    }
                }


                int bolum = hedef / r6;
               
                
                label19.Text = "İŞLEMLER \n **************************\n";
                label19.Text += Convert.ToString(hedef) + " / " + Convert.ToString(r6) + " = " + Convert.ToString(bolum)+ "\n";

                int kalan = hedef % r6;

                label19.Text += Convert.ToString(hedef) + " % " + Convert.ToString(r6) + " = " + Convert.ToString(kalan) + "\n";
                label19.Text += "**************************\n";

                bul = 0;
               

                for (int i = 0; i < 6; i++)
                {
                    if (dizi[i] == bolum)
                    {
                        sonuc = dizi[i] * r6;

                        label19.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(r6) + " = " + Convert.ToString(sonuc) + "\n";
                        bul = 1;
                        break;
                    }

                }

                //toplama işemi ile bölüm değerini bulma 

                if (bul != 1)
                {
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if ((dizi[i] + dizi[j]) == bolum)
                            {
                                sonuc = r6 * (dizi[i] + dizi[j]);

                                bul = 1;

                                label19.Text += Convert.ToString(r6) + " * " + Convert.ToString(dizi[i]) + 
                                    " + " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(sonuc) + "\n";

                            }
                            if (bul == 1) break;
                        }
                        if (bul == 1) break;
                    }
                }

                // çıkarma işemi ile bölüm değerini bulma

                if (bul != 1)
                {
                    for (int i = 0; i < 6; i++)
                    {


                        for (int j = 0; j < 6; j++)
                        {
                            if ((dizi[i] - dizi[j]) == bolum)
                            {
                                sonuc = r6 * (dizi[i] - dizi[j]);
                                label19.Text += Convert.ToString(r6) + " * " + Convert.ToString(dizi[i]) + 
                                    " - " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(sonuc) + "\n";


                                bul = 1;
                            }
                            if (bul == 1) break;
                        }
                        if (bul == 1) break;

                    }
                }


                //çarpma işlemi ile bölüm değerini bulma 

                if (bul != 1)
                 {
                    for (int i = 0; i < 6; i++)
                    {
                            for (int j = 0; j < 6; j++)
                            {
                                if ((dizi[i]*dizi[j])== bolum)
                                {
                                    sonuc = r6 * (dizi[i] * dizi[j]);
                                    bul = 1;
                                    label19.Text += Convert.ToString(r6) + " * " + Convert.ToString(dizi[i])+ 
                                    " * " + Convert.ToString(dizi[j]) + " = " + Convert.ToString(sonuc) + "\n";
                                                             
                                }
                            if (bul == 1) break;
                        }
                        if (bul == 1) break;

                    }
                 }

                
                //bölme işlemi ile bölüm değerini bulma 
                if (bul != 1)
                {
                    for (int i = 0; i < 6; i++)
                    {


                        for (int j = 0; j < 6; j++)
                        {
                            if ((dizi[i] / dizi[j]) == bolum)
                            {
                                sonuc = r6 * (dizi[i] / dizi[j]);
                                label19.Text += Convert.ToString(r6) + " * " + Convert.ToString(dizi[i]) + 
                                    " / "  + Convert.ToString(dizi[j]) + " = " + Convert.ToString(sonuc) + "\n";

                               
                                bul = 1;
                              
                            }
                            if (bul == 1) break;
                        }
                        if (bul == 1) break;
                    }
                }

                //üç sayıyla işlem yaparak bölüm değerini bulma
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        for (int z = 0; z < 6; z++)
                        {
                            if (dizi[i] + dizi[j] + dizi[z] == bolum)
                            {
                                sonuc =r6* (dizi[i] + dizi[j] + dizi[z]);
                                bul = 1;
                                label19.Text += Convert.ToString(dizi[i]) + " + " + Convert.ToString(dizi[j]) + 
                                    " + " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(bolum) + "\n";

                                
                            }
                            if (bul == 1) break;
                            if (dizi[i] + dizi[j] - dizi[z] == bolum && bul !=1)
                            {
                                sonuc = r6*(dizi[i] + dizi[j] - dizi[z]);
                                bul = 1;
                                label19.Text += Convert.ToString(dizi[i]) + " + " + Convert.ToString(dizi[j]) + 
                                    " - " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(bolum) + "\n";

                            }
                            if (bul == 1) break;
                            if (dizi[i] * dizi[j] + dizi[z] == bolum && bul != 1)
                            {
                                sonuc = r6 * (dizi[i] * dizi[j] + dizi[z]);
                                bul = 1;
                                label19.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + 
                                    " + " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(bolum) + "\n";

                               
                            }
                            if (bul == 1) break;
                            if (dizi[i] * dizi[j] - dizi[z] == bolum && bul != 1)
                            {
                                sonuc = r6 * (dizi[i] * dizi[j] - dizi[z]);
                                bul = 1;
                                label19.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + 
                                    " - " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(bolum) + "\n";

                                
                            }
                            if (bul == 1) break;
                            if (dizi[i] * dizi[j] * dizi[z] == bolum && bul != 1)
                            {
                                sonuc = r6 * (dizi[i] * dizi[j] * dizi[z]);
                                bul = 1;
                                label19.Text += Convert.ToString(dizi[i]) + " * " + Convert.ToString(dizi[j]) + 
                                    " * " + Convert.ToString(dizi[z]) + " = " + Convert.ToString(bolum) + "\n";

                                
                            }

                            if (bul == 1) break;

                        }

                        if (bul == 1) break;
                    }

                    if (bul == 1) break;
                }


                //kalan fonksiyonu
                if (kalan!=0)
                {
                    int ilksonuc = sonuc;
                    sonuc = sonuc+ kalan_bul(dizi, kalan);
                    label19.Text += Convert.ToString(ilksonuc) + " + " + Convert.ToString(kalan_bul(dizi, kalan)) +  " = " + Convert.ToString(sonuc) + "\n";

                }


                textBox8.Text = Convert.ToString(sonuc);
            }
            else
                MessageBox.Show("Hatalı işlem!");
            
        }
    }
}
