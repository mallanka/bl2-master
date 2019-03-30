using System;

namespace ConsoleApp7
{
    public class Practice
    {
        /// <summary>
        /// B2-P1/1. TypeConvert. Преобразование типов используя явное, неявное преобразование и класс Convert.
        /// </summary>
        public static void B2_P1_1_TypeConvert()
        {
            //CONVERSION (explicit, implicit, TypeConverter)

            //1. CHAR CONVERSION 
            char sex = 'М';//to string
            string sexString = Convert.ToString(sex);//"M"
            char place = '3';//to int
            int placeInt = (int)Char.GetNumericValue(place);//3
            char hasFingerPrints = '0';//to boolean
            bool hasFingerPrintsBool = Convert.ToBoolean((int)Char.GetNumericValue(hasFingerPrints));//False

            //2. STRING CONVERSION           
            string hasPhotoString = "True";//to bolean
            bool hasPhotoStringBool = Convert.ToBoolean(hasPhotoString);//True
            string flatNumber = "34";//to int
            int flatNumberInt = Convert.ToInt32(flatNumber);//34
            string visaPriceString = "34,23";//to float
            float visaPriceStringFloat = Convert.ToSingle(visaPriceString);//34,23
            string photoPriceString = "7.23";//to float
            float photoPriceStringFloat = Convert.ToSingle(photoPriceString, System.Globalization.CultureInfo.InvariantCulture);//7,23

            //3. BOOL CONVERSION
            bool hasFree2Pages = false;//to string, to char, to int
            string hasFree2PagesString = Convert.ToString(hasFree2Pages);//"False"
            char hasFree2PagesChar = Convert.ToChar(Convert.ToInt32(hasFree2Pages));//' ' WhiteSpace
            int hasFree2PagesInt = Convert.ToInt32(hasFree2Pages);//0

            //4. DECIMAL CONVERSION
            double visaPrice = 60;//to int, to string
            int visaPriceInt = (int)visaPrice;//60
            string DecimalVisaPriceString = Convert.ToString(visaPrice);//"60"
            double finterPrintsPrice = 55.2;//to int, to string
            int finterPrintsPriceInt = (int)finterPrintsPrice;//55
            string finterPrintsPriceString = Convert.ToString(finterPrintsPrice);//"55,2"

            //4. INT CONVERSION
            int birthYear = 2000;//to string, to double, to char
            string birthYearString = Convert.ToString(birthYear);//"2000"
            double birthYearDouble = birthYear;//2000
            char birthYearChar = (char)birthYear;//'?'
            int hasPhotoInt = 1;//to boolean
            bool hasPhotoBool = Convert.ToBoolean(hasPhotoInt);//True
        }
    }
}
