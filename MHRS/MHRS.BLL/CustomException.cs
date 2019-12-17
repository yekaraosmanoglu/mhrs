using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS.BLL
{
    class SameNameException : Exception
    {
        public override string Message
        {
            get
            {
                return "Bu Ad ve Soyad sistemde mevcut!";
            }
        }
    }

    class SameUserNameException : Exception
    {
        public override string Message
        {
            get
            {
                return "Bu Kullanıcı Adı daha önce alınmış!";
            }
        }
    }

    class PasswordCharacterException : Exception
    {
        public override string Message
        {
            get
            {
                return "Şifrede yasaklı karakter kullanılamaz!";
            }
        }
    }

    class PasswordLenghtException : Exception
    {
        public override string Message
        {
            get
            {
                return "Şifre en az 8, en fazla 16 karakter olmalı!";
            }
        }
    }

    class PastAppointmentException : Exception
    {
        public override string Message
        {
            get
            {
                return "Sadece gelecek tarihli randevu alınabilir!";
            }
        }
    }

    class FullAppointmentException : Exception
    {
        public override string Message
        {
            get
            {
                return "Seçilen randevu dolu!";
            }
        }
    }

    class ErrorMailException : Exception
    {
        public override string Message
        {
            get
            {
                return "Lütfen geçerli bir mail adresi giriniz!";
            }
        }
    }

    class ErrorLenghtMailException : Exception
    {
        public override string Message
        {
            get
            {
                return "Mail adresi en az 8 karakter uzunluğunda olmalıdır!";
            }

        }
    }

    class NameLenghtControlException : Exception
    {
        public override string Message
        {
            get
            {
                return "Ad kısmı boş geçilemez!";
            }
        }
    }
    class SurnameLenghtControlException : Exception
    {
        public override string Message
        {
            get
            {
                return "Soyad kısmı boş geçilemez!";
            }
        }
    }

    class WeekendAppointmentException : Exception
    {
        public override string Message
        {
            get
            {
                return "Haftasonu için randevu alamazsınız!";
            }
        }
    }
}
