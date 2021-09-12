using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EightBall2 : MonoBehaviour
{
    string[] the_options = {"It is Certain", "It is decidedly so", "Without a doubt", "Yes definitely", 
                        "You may rely on it", "As I see it, yes", "Most likely", "Outlook good", "Yes",
                         "Signs point to yes", "Reply hazy, try again", "Ask again later", "Better not tell you now",
                         "Cannot predict now", "Concentrate and ask again", "Don't count on it", "My reply is no",
                         "My sources say no", "Outlook not so good", "Very dountful"};
    // Start is called before the first frame update

    [SerializeField]
    AudioSource success;

    void Start()
    {
        
    }

    public void Roll(){
        int position = Random.Range(0, 20);
        gameObject.GetComponent<TextMeshPro>().text = the_options[position];
        success.Play();
    }
}
