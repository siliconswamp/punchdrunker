﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefenseEnemy : EnemyObject
{
    public DefenseEnemy(int hp, int st, int p, int t, int sp) : base(hp, st, p, t, sp)
    {
        enemyMove1 = ScratchSurface;
        enemyMove2 = Synthesize;
        enemyMove3 = RightHook;
        enemyMove4 = Cornered;
    }

    void ScratchSurface()
    {
        //WIP
    }

    void Synthesize()
    {
        //WIP
    }

    void RightHook()
    {
        //WIP
    }

    void Cornered()
    {
        //WIP
    }
}