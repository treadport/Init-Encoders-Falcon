using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System;
using System.Threading;
using CTRE.Phoenix.MotorControl;
using CTRE.Phoenix.MotorControl.CAN;

namespace Init_Encoders_Falcon
{
    public class Program
    {
        public static void Main()
        {
            TalonFX _talon = new TalonFX(11); //CHANGE: this is the motor's ID number

            _talon.ConfigSelectedFeedbackSensor(FeedbackDevice.IntegratedSensor,
                                                0,
                                                30);

            /* loop forever */
            while (true)
            {
                
                /* wait a bit */
                System.Threading.Thread.Sleep(100);
            }
        }
    }
}
