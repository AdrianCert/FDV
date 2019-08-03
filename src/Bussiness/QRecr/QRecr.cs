using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using QRCoder;

namespace Bussiness.QRecr
{
    public class QRecr : IQRecr
    {
        private Bitmap QRimage;
        private string QRdata;
        private readonly Type ContextType;
        public QRecr(Type type)
        {
            ContextType = type;
        }
        public enum Type
        {
            Encode,
            Decode
        }
        private void Validation()
        {
            if(ContextType == Type.Decode)
            {
                if (QRimage == null)// check if this sintax is corect
                {
                    throw new ArgumentException("The context are missing");
                }
            }
            else
            {
                if (QRdata == null)// check if this sintax is corect
                {
                    throw new ArgumentException("The context are missing");
                }
            }
        }
        public virtual QRecr Data(string txt)
        {
            QRdata = txt;
            return this;
        }
        public virtual QRecr Data(Bitmap src)
        {
            QRimage = src;
            return this;
        }
        public string Decode()
        {
            Validation();
            //code here
            return QRdata;
        }
        public Bitmap Encode()
        {
            Validation();
            QRCodeGenerator generator;
            QRCodeData data;
            QRCode code;
            generator = new QRCodeGenerator();
            data = generator.CreateQrCode(QRdata,QRCodeGenerator.ECCLevel.M);
            code = new QRCode(data);
            QRimage = code.GetGraphic(20);
            return QRimage;
        }
    }
}
