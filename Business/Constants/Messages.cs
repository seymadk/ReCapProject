using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string CarInserted = "Araba eklendi";
        public static string MaintennanceTime = "Araba bakımda";
        public static string CarListed = "Arabalar listelendi";
        public static string CarNameAlreadyExist = "Bu isimde zaten bir araba var";
        public static string CarImagesLimitedExceded = "Araba resimleri 5 ten fazla olamaz";
        public static string CarImagesInserted = "Araba resimleri eklendi";
        public static string CarImagesNotLoaded = "Araba resimleri yüklenemedi";
        public static string CarImagesListed = "Araba resimleri listelendi";
        public static string CarImagesUpdated = "Araba resimleri güncellendi";
        public static string CarImagesDeleted = "Araba resmi silindi";
    }
}
