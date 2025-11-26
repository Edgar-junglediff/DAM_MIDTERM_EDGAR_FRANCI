using UnityEngine;

public class TRIGGERPUNTO : MonoBehaviour
{
    public Collider2D collide2D;
    public bool isRight1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GAMEMANAGER gameManager = FindFirstObjectByType<GAMEMANAGER>();

        
        

       gameManager.Point(isRight1);
            
        
        
    }





}
