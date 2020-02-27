using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeoutImage : MonoBehaviour
{

    public bool fadeToWhite = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (fadeToWhite) {
            Image im = GetComponent<Image>();
            Color tmp = im.color;
            tmp.a += 0.5f * Time.deltaTime;
            if (tmp.a >= 0.99f) {
                tmp.a = 1.0f;
                fadeToWhite = false;
            }
            im.color = tmp;

        }
    }

    public void StartFadeout() {
        // GameObject whiteFadeoutImage = GameObject.Find("white_fadeout");
        fadeToWhite = true;
    }
}
