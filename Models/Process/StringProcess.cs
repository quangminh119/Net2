namespace Net2Minh.Models.Process
{
    public class StringProcess
    {
        public string RemoveRemainingWhiteSpace(string strInput)
        {
            string strResult = "";
            //viet code de xu ly theo yeu cau cua bai toan
            //xoa bo cac khoang trang o dau va cuoi chuoi
            strInput = strInput.Trim();
            //xoa bo cac khoang trang con thua trong chuoi 
            //int index = strInput.IndexOf("  ");
            while(strInput.IndexOf("  ")>0)
            {
                strInput = strInput.Replace("  "," ");
            }
            strResult = strInput;
            //tra ve du lieu sau khi xu ly 
            return strInput;
        }
        //public kieu_du_lieu_tra_ve Ten_phuong_thuc (tham_so)
        public string LowerToUpper (string strInput)
        {
            string strResult = "";
            strInput = strInput.ToUpper();
            strResult = strInput;
            return strInput;
        }
        public string UpperToLower (string strInput)
        {
            string strResult = "";
            strInput = strInput.ToLower();
            strResult = strInput;
            return strInput;
        }
        public string CapitalizeOneFirstCharacter (string strInput)
        {
            string strResult = "";
            string str1 = strInput.Substring(0,1);
            string str2 = strInput.Substring(1);
            str1 = str1.ToUpper();
            str2 = str2.ToLower();
            strResult = str1 + str2;
            return strInput;
        }
        public string RemoveVietnameseAccents(string strInput)
        {
            string strResult = "";
            string arr1 = new string ("á", "à", "ả", "ã", "ạ", "â", "ấ", "ầ", "ẩ", "ẫ", "ậ", "ă", "ắ", "ằ", "ẳ", "ẵ", "ặ",  
    "đ",  
    "é","è","ẻ","ẽ","ẹ","ê","ế","ề","ể","ễ","ệ",  
    "í","ì","ỉ","ĩ","ị",  
    "ó","ò","ỏ","õ","ọ","ô","ố","ồ","ổ","ỗ","ộ","ơ","ớ","ờ","ở","ỡ","ợ",  
    "ú","ù","ủ","ũ","ụ","ư","ứ","ừ","ử","ữ","ự",  
    "ý","ỳ","ỷ","ỹ","ỵ",);
            string arr2 = new string("a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a", "a",  
    "d",  
    "e","e","e","e","e","e","e","e","e","e","e",  
    "i","i","i","i","i",  
    "o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o","o",  
    "u","u","u","u","u","u","u","u","u","u","u",  
    "y","y","y","y","y");
    for(int i = 0; i<arr1.Length; i++)
    {
        strInput = strInput.Replace(arr1[i], arr2[i]);
        strInput = strInput.Replace(arr1[i].ToUpper(), arr2[i].ToUpper());

    }
            return strInput;
        }
    }
}