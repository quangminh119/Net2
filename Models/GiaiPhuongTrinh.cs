namespace Net2Minh.Models
{
    public class GiaiPhuongTrinh
    {
        //phuong thuc giai phuong trinh bac1 
        public string GiaiPhuongTrinhBacNhat(string heSoa, string heSob)
        {
            double a,b,x;
            string Thongbao;
            a = Convert.ToDouble(heSoa);
            b = Convert.ToDouble(heSob);
            if(a==0)
            {
                if(b !=0)
                {
                    Thongbao = "phuong trinh vo nghiem";
                }
                else{
                    Thongbao = "phuong trinh vo nghiem";
                }
            }
            else{
                x = -b/a;
                Thongbao = "Phuong trinh co nghiem x = " +x ;
            }
            
        }

        // phuong thuc giai phuong trinh bac2
    }
}