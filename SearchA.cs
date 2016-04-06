using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SearchA : SearchAlgorithm
{

    private Queue<SearchNode> openQueue = new Queue<SearchNode>();
    private Queue<SearchNode> frontier;
    private HashSet<object> explored = new HashSet<object>(); // empty set

    void Start()
    {
        problem = GameObject.Find("Map").GetComponent<Map>().GetProblem();
        SearchNode start = new SearchNode(problem.GetStartState(), 0);
        //start.TotalCost = start.PathCost + Heuristic(start);

        //Priority queue ordered byTotalCost, with node as the only element
        //frontier = new PriorityQueue<double, Path<start>>();
        //frontier.Enqueue(0, new SearchA(start));
        openQueue.Enqueue(start);
    }
 

    protected override void Step()
    {

        if (openQueue.Count != 0)
        {
            SearchNode cur_node = openQueue.Dequeue();
            explored.Add(cur_node.state);

            if (problem.IsGoal(cur_node.state))
            {
                solution = cur_node;
                finished = true;
                running = false;
            }
            else {
                Successor[] sucessors = problem.GetSuccessors(cur_node.state);
                foreach (Successor suc in sucessors)
                {
                    if (!explored.Contains(suc.state))
                    {
                        SearchNode new_node = new SearchNode(suc.state, suc.cost + cur_node.g, suc.action, cur_node);
                        if (problem.IsGoal(suc.state))
                        {
                            solution = new_node;
                            finished = true;
                            running = false;
                        }
                            openQueue.Enqueue(new_node);
                    }
                }
            }
        }
    }
}

