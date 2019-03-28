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
            string sexString = Convert.ToString(sex);
            char place = '3';//to int
            int placeInt = (int)Char.GetNumericValue(place);
            char hasFingerPrints = '0';//to boolean
            bool hasFingerPrintsBool = Convert.ToBoolean((int)Char.GetNumericValue(hasFingerPrints));

            //2. STRING CONVERSION           
            string hasPhotoString = "True";//to bolean
            bool hasPhotoStringBool = Convert.ToBoolean(hasPhotoString);
            string flatNumber = "34";//to int
            int flatNumberInt = Convert.ToInt32(flatNumber);
            string visaPriceString = "34,23";//to float
            float visaPriceStringFloat = (float)(Convert.ToDouble(visaPriceString));
            string photoPriceString = "7.23";//to float
            float photoPriceStringFloat = (float)(Convert.ToDouble(photoPriceString, System.Globalization.CultureInfo.InvariantCulture));

            //3. BOOL CONVERSION
            bool hasFree2Pages = false;//to string, to char, to int
            string hasFree2PagesString = Convert.ToString(hasFree2Pages);
            int hasFree2PagesInt = Convert.ToInt32(hasFree2Pages);
            char hasFree2PagesChar = Convert.ToChar(hasFree2PagesInt);

            //4. DECIMAL CONVERSION
            double visaPrice = 60;//to int, to string
            int visaPriceInt = (int)visaPrice;
            string DecimalVisaPriceString = Convert.ToString(visaPrice);
            double finterPrintsPrice = 55.2;//to int, to string
            int finterPrintsPriceInt = (int)finterPrintsPrice;
            string finterPrintsPriceString = Convert.ToString(finterPrintsPrice);

            //4. INT CONVERSION
            int birthYear = 2000;//to string, to double, to char
            string birthYearString = Convert.ToString(birthYear);
            double birthYearDouble = birthYear;
            char birthYearChar = (char)birthYear;
            int hasPhotoInt = 1;//to boolean
            bool hasPhotoBool = Convert.ToBoolean(hasPhotoInt);
        }
    }
}
