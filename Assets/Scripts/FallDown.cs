using UnityEngine;

public class FallDown : MonoBehaviour {
    [SerializeField]
    private float fallSpeed = 2f;
    

   
    void Update () {
        if (transform.position.y < -6f)
            Destroy(gameObject);
        fallSpeed *= 1.03f;
        transform.position -= new Vector3(0,fallSpeed * Time.deltaTime,0);
    }
    
}
