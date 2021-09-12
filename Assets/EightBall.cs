using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EightBall : MonoBehaviour
{
    string[] the_options = {"Hell Yeah", "Totaly", "Bet", "Totes", "Get Back To Me", "Not Sure Man", "Maybe?", "Nah", "Better Luck Next Time", "Nope"};
    // Start is called before the first frame update

    [SerializeField]
    AudioSource success;

    void Start()
    {
        
    }

    public void Roll(){
        int position = Random.Range(0, 10);
        gameObject.GetComponent<TextMeshPro>().text = the_options[position];
        success.Play();
    }
}
