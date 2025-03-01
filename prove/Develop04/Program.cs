using System;

class Program
{
    static void Main(string[] args)
    {
        int _option;
        do{
        Activity activity = new Activity("Amanda");
        activity.Option();
        _option = activity.GetOption();
        if (_option == 1)
        {
            //start breathing activity
            BreatheActivity breatheActivity = new BreatheActivity("Breathing Activity");
            breatheActivity.Welcome();
            breatheActivity.GetTime();
            breatheActivity.GetReady();
            breatheActivity.Breathe();
            breatheActivity.Goodbye();



            
        }
        if (_option == 2)
        {
            //start reflecting activity
            ReflectActivity reflectActivity = new ReflectActivity("Reflecting Activity");
            reflectActivity.Welcome();
            reflectActivity.GetTime();
            reflectActivity.GetReady();
            reflectActivity.Reflect();
            reflectActivity.Goodbye();

        }
        if (_option == 3)
        {
            //Start listing activity
            ListActivity listActivity = new ListActivity("Listing Activity");
            listActivity.Welcome();
            listActivity.GetTime();
            listActivity.GetReady();
            listActivity.Listing();
            listActivity.Goodbye();


        }
        if (_option == 4)
        {
            //Start guiding activity
            GuidedActivity guidedActivity = new GuidedActivity("Guided Activity"); 
            guidedActivity.Welcome();
            guidedActivity.GetTime();
            guidedActivity.GetReady();
            guidedActivity.Guide();
            guidedActivity.Goodbye();
        }
        }while(_option != 5);

        
    }
}