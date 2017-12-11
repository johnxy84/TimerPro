using System;

namespace TimerPro.Interfaces
{
    public interface IHelper
    {
        bool BackButtonPress();

        void SendMessage(string message);

        void SendConfirmation(string title, string message, Action<bool> action, string yes, string no);


    }
}