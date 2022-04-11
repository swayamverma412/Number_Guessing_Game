using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Samplescene : MonoBehaviour
{
   public Text guessText;
    int min_guess = 1;
    int max_guess = 2000;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
      guess = Random.Range(min_guess,max_guess);
      guessText.text = guess.ToString();
    }


    public void onPressHigher()
    {
        min_guess = guess;
        guess = Random.Range(min_guess,max_guess);
        guessText.text = guess.ToString();


    }

    public void onPressLOwer()
    {
        max_guess = guess;
        guess = Random.Range(min_guess,max_guess);
        guessText.text = guess.ToString();



    }

}