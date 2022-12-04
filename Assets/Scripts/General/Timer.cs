
using System;
using UnityEngine;

public class Timer : MonoBehaviour
{
    
    public enum TimerState
    {
        Running,
        Stopped
    }

    public TimerState CurrentTimerState { get; private set; }
    public float time { get; private set; }
    private void Start()
    {
        CurrentTimerState = TimerState.Stopped;
    }

   private void Update()
    {
        if (CurrentTimerState == TimerState.Running) time += Time.deltaTime;
    }

   public void StartTimer()
   {
       CurrentTimerState = TimerState.Running;
   }

   public void StopTimer()
   {
       CurrentTimerState = TimerState.Stopped;
   }

   public void ResetTimer()
   {
       time = 0;
   }
}
