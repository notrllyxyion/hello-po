using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ImpGUI : MonoBehaviour
{
    public Texture2D buttonImage;
    public Vector2 positionBoxOne;
    public Vector2 sizeBoxOne;
    public Vector2 positionBoxTwo;
    public Vector2 sizeBoxTwo;


    /*
        private void OnGUI()
        {


            GUI.Box(new Rect(100, 122, 900, 1000), "Start");
            if (GUI.Button(new Rect(30, 40, 100, 50), "Start Class"))
            {
                print("Start Class");
            }

            if (GUI.Button(new Rect(position, size), buttonImage))
            {

                print("displaying image");
            }

            GUI.Box(new Rect(position, size), buttonImage);
        }*/

    private void OnGUI()
    {
        

       

        GUI.Box(new Rect(14, 31.52f, 187.49f, 29.23f), "");
        if (GUI.Button(new Rect(14, 31.52f, 187.49f, 29.23f), "Left"))
        {
            positionBoxOne.x -= 0.5f;
        }

        GUI.Box(new Rect(14.86f, 607.63f, 187.69f, 101.1f), "");
        if (GUI.Button(new Rect(21.4f, 623.2f, 169.1f, 61.5f), "up")) 
        {
            positionBoxOne.y -= 0.5f;
        }

        
        GUI.Box(new Rect(1179, 586.22F, 287, 139.3F), "");
        if (GUI.Button(new Rect(1172, 619.5F, 292, 43.8F), "down")) 
        {
            positionBoxOne.y += 0.5f;
        }

        GUI.Box(new Rect(1188.8f, 2.42f, 278.7f, 129.2f), "");
        if(GUI.Button(new Rect(1206, 36.8f, 254.4f, 43.8f), "right")) 
        {
            positionBoxOne.x += 0.5f;
        }

        GUI.Box(new Rect (positionBoxOne,sizeBoxOne), buttonImage);
    }
}
