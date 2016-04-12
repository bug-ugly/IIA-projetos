using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GreedySearch : SearchAlgorithm
{

    private List<SearchNode> openList = new List<SearchNode>();
    private HashSet<object> closedSet = new HashSet<object>();


    void Start()
    {
        problem = GameObject.Find("Map").GetComponent<Map>().GetProblem();
        SearchNode start = new SearchNode(problem.GetStartState(), 0);
        openList.Add(start);

    }

    protected override void Step()
    {

        if (openList.Count > 0)
        {


            SearchNode cur_node = openList[0];
            openList.RemoveAt(0);




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
                    if (!closedSet.Contains(suc.state))
                    {
                        List<Vector2> crates = GameObject.Find("Map").GetComponent<Map>().GetCrates();

                        float f = crates.Count;
                        float h = f - (suc.cost + cur_node.g);

                        SearchNode new_node = new SearchNode(suc.state, suc.cost + cur_node.g, h, suc.action, cur_node);

                        openList.Add(new_node);
                        openList.Sort((x, y) => x.g.CompareTo(y.g));
                    }
                }
            }
        }
        else
        {
            finished = true;
            running = false;
        }
    }
}

