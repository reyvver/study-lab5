using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayableZone : MonoBehaviour
{
    public SpriteRenderer sp;
    
    private void Awake()
    {
       var  screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
       Debug.Log(new Vector2(Screen.width, Screen.height));
       Debug.Log(screenBounds);
 
        screenBounds.x -= sp.sprite.bounds.size.x/2;
        screenBounds.y-= sp.sprite.bounds.size.y/2;
        Debug.Log(screenBounds);

    }
}
