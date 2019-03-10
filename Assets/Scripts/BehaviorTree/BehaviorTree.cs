﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//https://designagame.eu/2015/05/simple-behaviour-trees-for-your-game-in-javascript-and-c/
//https://hub.packtpub.com/building-your-own-basic-behavior-tree-tutorial/

namespace BehaviorTree
{
    public class BehaviorTree
    {
        public enum NodeState
        {
            FAILURE,
            SUCCESS,
            RUNNING,
            IN_QUEUE,
            IGNORE,
            COMPUTING,
            WAITING
        };

        private Node root;
        private int numberOfLoops;
        private int numberOfRuns = 0;
        public bool Completed = false;

        public Dictionary<Node, NodeState> NodeAndState = new Dictionary<Node, NodeState>();

        private Node currentNode = null;

        public BehaviorTree(Node root, int numberOfLoops)
        {
            this.root = root;
            this.currentNode = root;
            this.numberOfLoops = numberOfLoops;
        }


    }
}

/* OLD STUFF
    [System.Serializable]
    public abstract class Node
    {
        public string name;

        public delegate NodeState returnNode();

        protected NodeState currentNodeState;

        public NodeState NodeState
        {
            get { return currentNodeState; }
        }

        public Node() { }

        public Node(string nodeName)
        {
            name = nodeName;
        }

        public abstract NodeStates Evaluate();
    }

    public class Selector : Node
    {
        protected List<Node> node_list = new List<Node>();

        public Selector(string name, List<Node> nodes)
        {
            node_list = nodes;
        }

        public override NodeStates Evaluate()
        {
            foreach (Node node in node_list)
            {
                switch (node.Evaluate())
                {
                    case NodeStates.FAILURE:
                        continue;
                    case NodeStates.SUCCESS:
                        currentNodeState = NodeStates.SUCCESS;
                        return currentNodeState;
                    case NodeStates.RUNNING:
                        currentNodeState = NodeStates.RUNNING;
                        return currentNodeState;
                    default:
                        continue;
                }
            }
            currentNodeState = NodeStates.FAILURE;
            return currentNodeState;
        }
    }

    // Decorator type repeater node for behavior tree written for enemy moves
    // with turn counts...not sure if needed, recheck later
    public class Repeater : Node
    {
        protected Node child;

        public Repeater(Node node)
        {
            child = node;
        }

        public override NodeStates Evaluate()
        { 
            NodeStates ret = child.NodeState;
            if (ret != NodeStates.RUNNING)
            {
                child = null;
            }
            return NodeStates.SUCCESS;
        }
    }

    public class EnemySkipTurn : Node
    {
    
    }

    public class EnemyMove1 : Node
    {


        public override Evaluate()
        {
            EnemyObject en = current;
            return NodeStates.SUCCESS
        }
    }

    public class EnemyMove2 : Node
    {
        public override Evaluate()
        {
            EnemyObject en = current
            return NodeStates.SUCCESS
        }
    }

    public class EnemyMove3 : Node
    {
        public override Evaluate()
        {
            EnemyObject en = current
            return NodeStates.SUCCESS
        }
    }

    public class EnemyMove4 : Node
    {
        public override Evaluate()
        {
            EnemyObject en = current
            return NodeStates.SUCCESS
        }
    }
    

    public class BehaviorTree : MonoBehaviour
    {
        Node behaviorTree;

        // Start is called before the first frame update
        void Start()
        {
            //behaviorTree = createBehaviorTree();    
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        // WIP need context to connect branches
        Node createBehaviorTrees()
        {
            List<Node> Moveset1 = <new EnemyMove1(), new EnemyMove2()>
            List<Node> Moveset2 = <new EnemyMove1(), new EnemyMove2(), new EnemyMove3()>
            List<Node> Moveset3 = <new EnemyMove1(), new EnemyMove2(), new EnemyMove3(), new EnemyMove4()>

            Selector endMoveset = new Selector("endMoveset", Moveset3);
            Selector middleMoveset = new Selector("middleMoveset", Moveset2);
            Selector startMoveset = new Selector("startMoveset", Moveset1)    
        
        }
       
     }
*/
