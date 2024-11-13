﻿namespace FirstGame
{
    public interface IEngine
    {
        void Start();
        void Stop();
        bool IsRunning();
        float CalculateFuelConsumption(float distance);
    }
}