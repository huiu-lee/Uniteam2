using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SwipeMenu : MonoBehaviour
{
    public GameObject scrollbar;
    private float scroll_pos = 0;
    float[] pos;
    public GameObject gameStartBtn;
    // public Button gameStartBtn_;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        pos = new float[transform.childCount];
        float distance = 1f / (pos.Length - 1f);
        for (int i = 0; i < pos.Length; i++)
        {
            pos[i] = distance * i;
        }

        if (Input.GetMouseButton(0))
        {
            scroll_pos = scrollbar.GetComponent<Scrollbar>().value;
        }
        else
        {
            for (int i = 0; i < pos.Length; i++)
            {
                if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
                {
                    scrollbar.GetComponent<Scrollbar>().value = Mathf.Lerp(scrollbar.GetComponent<Scrollbar>().value, pos[i], 0.1f);
                }
            }
        }


        for (int i = 0; i < pos.Length; i++)
        {
            if (scroll_pos < pos[i] + (distance / 2) && scroll_pos > pos[i] - (distance / 2))
            {
                // Debug.LogWarning("Current Selected Level" + i);
                transform.GetChild(i).localScale = Vector2.Lerp(transform.GetChild(i).localScale, new Vector2(1.2f, 1.2f), 0.1f);
                for (int j = 0; j < pos.Length; j++)
                {
                    if (j != i)
                    {
                        transform.GetChild(j).localScale = Vector2.Lerp(transform.GetChild(j).localScale, new Vector2(0.8f, 0.8f), 0.1f);
                    }
                }
                // if (i == 0)
                // {
                //     gameStartBtn.SetActive(true);
                //     // gameStartBtn_.onClick.AddListener(LoadScene0);
                // }
                // else if (i == 1)
                // {
                //     gameStartBtn.SetActive(true);
                //     // gameStartBtn_.onClick.AddListener(LoadScene1);
                // }
                // else if (i == 2)
                // {
                //     gameStartBtn.SetActive(true);
                //     // gameStartBtn_.onClick.AddListener(LoadScene2);
                // }
                // else if (i == 3)
                // {
                //     gameStartBtn.SetActive(true);
                //     // gameStartBtn_.onClick.AddListener(LoadScene3);
                // }
                // else
                // {
                //     gameStartBtn.SetActive(false);
                // }
            }
        }

    }

    // public void LoadScene0()
    // {
    //     SceneManager.LoadScene("Chapter0.0.0");
    // }
    // public void LoadScene1()
    // {
    //     SceneManager.LoadScene("Chapter1.0.0");
    // }
    // public void LoadScene2()
    // {
    //     SceneManager.LoadScene("Chapter2.0.0");
    // }
    // public void LoadScene3()
    // {
    //     SceneManager.LoadScene("Chapter3.0.0");
    // }
}
