using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class GameEvents
{
    public static event EventHandler DialogInitiated;
    public static event EventHandler DialogFinished;

    public static void InvokeDialogIntiated()
    {
        DialogInitiated(null, EventArgs.Empty);
    }
    public static void InvokeDialogFinish()
    {
        DialogFinish(null, EventArgs.Empty);
    }
}
