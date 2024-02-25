using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PointCounter : MonoBehaviour
{
    public static PointCounter Instance;
    public TMP_Text pointText;
    public int currentPoints = 0;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        pointText.text = "Points: " + currentPoints.ToString();
    }

    public void IncreasePoints(int v)
    {
        currentPoints += v;
        pointText.text = "Points: " + currentPoints.ToString();
    }

}
