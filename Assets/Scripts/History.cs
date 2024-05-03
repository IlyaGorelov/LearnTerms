
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class History : MonoBehaviour
{
    public static int count;
    [SerializeField] GameObject InstantiateObject;
    [HideInInspector] public List<GameObject> HistoryTerms = new();
    [SerializeField] Transform transform;
    [SerializeField] Transform parent;
    private float offset = 0;

    private void Start()
    {
        if (PlayerPrefs.HasKey("Count"))
            count = PlayerPrefs.GetInt("Count");
        else count = 0;
        CreateHistoryAuto();
    }

    private void CreateHistoryAuto()
    {
       
        print(count);
        for (int i = 0; i < count; ++i)
        {
            GameObject temp = Instantiate(InstantiateObject, transform);
            temp.transform.position = new Vector2(transform.position.x, transform.position.y - offset);
            HistoryTerms.Add(temp);
            temp.transform.SetParent(parent);
        }
    }

    public void AddToHistory()
    {
        GameObject temp = Instantiate(InstantiateObject, transform);
        temp.transform.position = new Vector2(transform.position.x, transform.position.y - offset);
        HistoryTerms.Add(temp);
        temp.transform.SetParent(parent);
    }

}
