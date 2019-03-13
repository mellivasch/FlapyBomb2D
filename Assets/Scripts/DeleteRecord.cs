using UnityEngine;



public class DeleteRecord : MonoBehaviour {
    

   
    private void OnMouseDown()
    {
        PlayerPrefs.DeleteAll();
        Debug.Log("Deleted");
    }
}
