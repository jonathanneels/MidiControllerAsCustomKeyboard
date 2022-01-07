  using System.Threading;

namespace MidiControllerToPcTest
{
 
    public static   class instanceCheck
    {

        public static bool IsOkToContinueInstance()
        {

            var appName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;//REF:https://www.c-sharpcorner.com/UploadFile/f9f215/how-to-restrict-the-application-to-just-one-instance/
            bool createdNew;

            Mutex mutex  = new Mutex(true, appName, out createdNew);

            
                return createdNew;
            
        }
    }
}
