﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Stat
{
    [SerializeField]
    private ShieldBarScript bar;

    [SerializeField]
    private float maxVal;

    [SerializeField]
    private float currentVal;

    public float CurrentVal 
    {
        get
        {
            return currentVal;
        }

        set
        {
            this.currentVal = value;
            bar.Value = currentVal;
        }
    }

    public float MaxVal
    {
        get
        {
            return maxVal;
        }

        set
        {
            this.maxVal = value;
            bar.MaxValue = maxVal ;
        }
    }

    public void Initialize()
    {
        this.MaxVal = maxVal;
        this.CurrentVal = currentVal;
    }
}
