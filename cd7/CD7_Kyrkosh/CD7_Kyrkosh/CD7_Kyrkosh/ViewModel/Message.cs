using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace CD7_Kyrkosh.ViewModel
{
    public class Message
    {
        String text;
        BitmapImage image;

        public Message(string text, BitmapImage image)
        {
            this.text = text;
            this.image = image;
        }

        public Message()
        {
           
        }

        public Message(Message message)
        {
            this.text = message.text;
            this.image = message.image;
        }

        public string Text { get => text; set => text = value; }
        public BitmapImage Image { get => image; set => image = value; }
    }
}
