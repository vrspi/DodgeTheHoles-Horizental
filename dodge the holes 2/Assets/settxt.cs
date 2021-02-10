using UnityEngine;
using TMPro;


public class settxt : MonoBehaviour
{
    public Texture texture;
    public Texture texture1;
    public Texture texture2;
    public Texture texture3;
    public Texture texture4;
    public Texture texture5;
    public Texture texture6;
    public Texture texture7;
    public Texture texture8;
    public Texture texture9;
    public Texture texture10;
    public Texture texture11;
    public Texture texture12;
    public Texture texture13;
    
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("skin") == 1)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture1);

        }
        if (PlayerPrefs.GetInt("skin") == 2)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture2);

        }
        if (PlayerPrefs.GetInt("skin") == 3)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture3);

        }
        if (PlayerPrefs.GetInt("skin") == 4)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture4);

        }
        if (PlayerPrefs.GetInt("skin") == 6)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture6);

        }
        if (PlayerPrefs.GetInt("skin") == 7)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture7);

        }
        if (PlayerPrefs.GetInt("skin") == 8)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture8);

        }
        if (PlayerPrefs.GetInt("skin") == 9)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture9);

        }
        if (PlayerPrefs.GetInt("skin") == 10)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture10);

        }
        if (PlayerPrefs.GetInt("skin") == 11)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture11);

        }
        if (PlayerPrefs.GetInt("skin") == 12)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture12);

        }
        if (PlayerPrefs.GetInt("skin") == 13)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture13);

        }
        if (PlayerPrefs.GetInt("skin") == 14)
        {
            GameObject.Find("Sphere").GetComponent<Renderer>().material.SetTexture("Texture2D_3429602E", texture);

        }


    }


    public void settexture()

    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/kora/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 14);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/kora/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
              GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/kora/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/kora/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("kora", 1);
            PlayerPrefs.SetInt("skin", 14);

        }

    }
    public void settexture1()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/wm/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 1);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/wm/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
             GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/wm/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/wm/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("wm", 1);
            PlayerPrefs.SetInt("skin", 1);

        }
    }
    public void settexture2()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/rb/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 2);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/rb/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
            GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/rb/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/rb/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("rb", 1);
            PlayerPrefs.SetInt("skin", 2);

        }
    }
    public void settexture3()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/db7/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 3);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/db7/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
             GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/db7/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/db7/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("db7", 1);
            PlayerPrefs.SetInt("skin", 3);

        }
    }
    public void settexture4()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/cristale/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 4);
            Debug.Log("ya hesra");

        }
        else if(int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/cristale/Text (TMP)").GetComponent<TMP_Text>().text)<=int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))
        {
             GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/cristale/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/cristale/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("cristale", 1);
            PlayerPrefs.SetInt("skin", 4);

        }
    }
    public void settexture5()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/bow/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 5);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/bow/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
            GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/bow/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/bow/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("bow", 1);
            PlayerPrefs.SetInt("skin", 5);

        }
    }
    public void settexture6()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/basket/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 6);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/basket/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
            GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/basket/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/basket/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("basket", 1);
            PlayerPrefs.SetInt("skin", 6);

        }
    }
    public void settexture7()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/bb/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 7);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/bb/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
            GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/bb/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/bb/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("bb", 1);
            PlayerPrefs.SetInt("skin", 7);

        }
    }
    public void settexture8()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/coco/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 8);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/coco/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
            GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/coco/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/coco/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("coco", 1);
            PlayerPrefs.SetInt("skin", 8);

        }
    }
    public void settexture9()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/poki/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 9);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/poki/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
            GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/poki/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/poki/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("poki", 1);
            PlayerPrefs.SetInt("skin", 9);

        }
    }
    public void settexture10()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/santa/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 10);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/santa/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
            GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/santa/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/santa/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("santa", 1);
            PlayerPrefs.SetInt("skin", 10);

        }
    }
    public void settexture11()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/snow/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 11);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/snow/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
            GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/snow/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/snow/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("snow", 1);
            PlayerPrefs.SetInt("skin", 11);

        }
    }
    public void settexture12()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/tenis/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin", 12);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/tenis/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
            GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/tenis/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/tenis/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("tenis",1);
            PlayerPrefs.SetInt("skin",12);

        }
    }
    public void settexture13()
    {
        if (GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/tomatte/Text (TMP)").GetComponent<TMP_Text>().text == "Owned")
        {
            PlayerPrefs.SetInt("skin",13);
            Debug.Log("ya hesra");

        }
        else if (int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/tomatte/Text (TMP)").GetComponent<TMP_Text>().text) <= int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text))

        {
           GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text = (int.Parse(GameObject.Find("Canvas/SHOP/TotalCoins").GetComponent<TMP_Text>().text) - int.Parse(GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/tomatte/Text (TMP)").GetComponent<TMP_Text>().text)).ToString();
            PlayerPrefs.SetString("ow", "Owned");
            GameObject.Find("Canvas/SHOP/Scroll View/Viewport/Content/tomatte/Text (TMP)").GetComponent<TMP_Text>().text = PlayerPrefs.GetString("ow");
            Debug.Log("ayaaaa rkheef");
            PlayerPrefs.SetInt("tomatte",1);
            PlayerPrefs.SetInt("skin", 5);
           
        }
    }
    
}
