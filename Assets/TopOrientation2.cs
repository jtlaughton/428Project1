using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopOrientation2 : MonoBehaviour
{
    enum TheStates {
        FACEDUP,
        FACEDDOWN
    }

    TheStates current;

    [SerializeField]
    EightBall2 the_eight_ball;

    // Start is called before the first frame update
    void Start()
    {
        current = TheStates.FACEDUP;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.up);

        if(transform.up.y < -0.5f && current == TheStates.FACEDUP){
            current = TheStates.FACEDDOWN;
        }
        else if(transform.up.y > 0.5f && current == TheStates.FACEDDOWN){
            current = TheStates.FACEDUP;
            the_eight_ball.Roll();
        }
    }
}
