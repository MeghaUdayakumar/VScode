using System;

namespace project
{
     public class OpenChat
    {
        public  Chat Chat { get; set; }
        public  Status Status { get; set;}

        public Contact Contact {get; set;}

    }
    public class AccountSetting{
        public string Username { get; set; }
        public int PhoneNumber { get; set; }

        public void login(){}
        
        }

    public interface IMessagList{
        void TextMessage();
        void ProfileImage();
        void Videos();
        void audio();
        void documents();

    }
    public class Chat 
    {
        public string ChatName{get; set;}
        public string ChatProfileImage { get; set; }
        public string ChatMessages { get; set; }
        public DateTime Time { get; set; }
         
    }
        

    public class SingleChat : IMessagList{
        public void audio()
        {
            
        }

        public void documents()
        {
          
        }

        public void ProfileImage()
        {
           
        }

        public void SendMessage(){}



        public void TextMessage()
        {
            
        }

        public void Videos()
        {
            
        }
        public void Location(){}
       


    }
    public class Status{
       public string NameofPerson { get; set; }
       public string StatusImages { get; set; }
       }

    public class Contact{
        public string PersonName { get; set; }
        public int PersonPhoneNo { get; set; }
        public string About { get; set; }
        
        }
        public class Setting {
        public string Notification{get; set;}
        private String Help { get; set; }
        
        }
        public class Help{
            public string FAQ { get; set; }
            public string ContactUs { get; set; }
            public string PrivacyPolicy { get; set; }
        }
        public class FAQ{
            public string FAQurl { get; set; }
        }
        public class ContactUs{
            public string ContactUrl { get; set; }
        }    
            
        
            
}
        
        
    

