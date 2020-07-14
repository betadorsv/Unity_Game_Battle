using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    public int score=0;
    public Text scoretext;
    PlayerHealth playerHealth;

    void Start()
    {
        setscoretext();
        
   
    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Coin"))
        {
            score += 10;
            col.gameObject.SetActive(false);
            setscoretext();
            FindObjectOfType<AudioManager>().Play("DingCoin");
        }
        
        
    }




    void setscoretext()
    {
        scoretext.text = score.ToString();
    }
}
