using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;

 public class Points : MonoBehaviour {
    public Text pointsText;
    public Text recPointsText;
   
   

    public float points;
    private float recPoints;
    private void Start()
    {
        
    }


    void Update()
    {
        if (Player.lose == false)
        {
            pointsText.text = "" + points;
            recPointsText.text = "" + recPoints;
            recPoints = PlayerPrefs.GetFloat("savepoints");
        }
        if (points > recPoints)
        {
            PlayerPrefs.SetFloat("savepoints", points);
            PlayerPrefs.Save();
        }
       
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bomb" && Player.lose == false)
        {
            points += 1;
        }
       
    }
   
}
