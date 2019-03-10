﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace BehaviorTree
{
    public interface Node
    {
        Result Execute(BehaviorTree tree);
        bool IsConditional();
        List<Node> Children();
    }
}

