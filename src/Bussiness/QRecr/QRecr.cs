using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;

namespace Bussiness.QRecr
{
    public class QRecr : IQRecr
    {
        private byte[] QRimage;
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
        public virtual QRecr Data(byte[] src)
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
        public byte[] Encode()
        {
            Validation();
            //code here
            return QRimage;
        }
    }
}
