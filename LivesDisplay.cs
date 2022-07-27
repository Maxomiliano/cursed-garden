using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LivesDisplay: MonoBehaviour
{
    [SerializeField] float baseLives = 3;
    [SerializeField] int damage = 1;
    Text livesText;
    float lives;

    // Start is called before the first frame update
    void Start()
    {
        lives = baseLives - PlayerPrefsController.GetDifficulty();
        livesText = GetComponent<Text>();
        UpdateDisplay();
        Debug.Log("Difficulty setting currently is " + PlayerPrefsController.GetDifficulty());
    }

    private void UpdateDisplay()
    {
        livesText.text = lives.ToString();
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeLife()
    {       
         lives -= damage;
         UpdateDisplay();

        if(lives <=0)
        {
            FindObjectOfType<LevelController>().HandleLoseCondition();
        }



    }


}
