using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WpfApplication2.test
{
    public class MainService : INotifyPropertyChanged
    {
        public MainService()
        {
            workStop = false;
            workThread = new Thread(Process);
            workThread.SetApartmentState(ApartmentState.STA);

            dateTime = new Date();
            eventGenerater = new EventGenerater();
        }

        public void Run()
        {
            workThread.Start();
        }

        public void Quit()
        {
            workStop = true;
            workThread.Join();
        }

        public void Process()
        {
            while(!workStop)
            {
                List<Event> eventList = eventGenerater.Generate();

                for(int i=0; i<eventList.Count; i++)
                {
                    EventBox eventBox = new EventBox(eventList[i]);
                    eventBox.Do();

                    eventList.AddRange(eventBox.GetTiggerEvent());
                }

                Thread.Sleep(1000);

                dateTime.Increase();
                NotifyPropertyChanged("date");
            }
        }

        public string date
        {
            get
            {
                return dateTime.year.ToString() + "年" + dateTime.month + "月" + dateTime.day + "日";
            }
        }

        private void NotifyPropertyChanged(string strPropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(strPropertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private Date dateTime;
        private EventGenerater eventGenerater;
        private Thread workThread;
        private bool workStop;
    }
}
