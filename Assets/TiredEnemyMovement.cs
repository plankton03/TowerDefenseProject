using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiredEnemyMovement : EnemyMovement
{
    public float waitTime;
    public float moveTime;

    private float moveTimeCounter;

    private bool isTired = false;
    // Start is called before the first frame update
    void Start()
    {

    }





    IEnumerator Break()
    {
        yield return new WaitForSeconds(waitTime);
    }

    protected override IEnumerator Moving()
    {

        while (true)
        {
            moveTimeCounter = moveTime;

            while (!isTired)
            {
                agent.SetDestination(goal.position);

                CheckArrival();

                //havaset bashe delta time = tield return null
                moveTimeCounter -= Time.deltaTime;

                if (moveTimeCounter <= Mathf.Epsilon)
                {
                    isTired = true;
                }
                yield return null;
            }

            agent.ResetPath();

            yield return new WaitForSeconds(waitTime);

            isTired = false;
        }



        //IEnumerator moving = base.Moving();
        //while (moving.MoveNext())
        //    yield return moving.Current;

    }


    // Update is called once per frame
    void Update()
    {

    }
}
