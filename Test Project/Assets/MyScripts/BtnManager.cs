using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BtnManager : MonoBehaviour
{
    [SerializeField]
    GameObject matchStats, achieve;
    [SerializeField] Button btn_ach, btn_match;

    private Color dis = new Color(0.5f, 0.5f, 0.5f, 1f), 
                            an = new Color(0.8f, 0.8f, 0.7f, 1f),
                            img_100 = new Color(1, 1, 1, 1),
                            img_0 = new Color(1, 1, 1, 0);

    // Start is called before the first frame update
    void Start()
    {
        matchStats.SetActive(false);
        achieve.SetActive(false);

        btn_ach.image.color = img_0;
        btn_ach.GetComponentInChildren<TMP_Text>().color = dis;
        btn_match.image.color = img_0;
        btn_match.GetComponentInChildren<TMP_Text>().color = dis;

    }

    public void OnAchievementsClick()
    {
        matchStats.SetActive(false);
        achieve.SetActive(true);

        btn_ach.image.color = img_100;
        btn_ach.GetComponentInChildren<TMP_Text>().color = an;

        btn_match.image.color = img_0;
        btn_match.GetComponentInChildren<TMP_Text>().color = dis;
        //btn.GetComponentInChildren<TMP_Text>().fontStyle = FontStyle.Bold; 

    }

    public void OnOverviewClick()
    {
        achieve.SetActive(false);
        matchStats.SetActive(true);

        btn_match.image.color = img_100;
        btn_match.GetComponentInChildren<TMP_Text>().color = an;

        btn_ach.image.color = img_0;
        btn_ach.GetComponentInChildren<TMP_Text>().color = dis;

    }


}
