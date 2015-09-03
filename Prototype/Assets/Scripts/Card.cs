using UnityEngine;
using System.Collections.Generic;

public class Card : MonoBehaviour
{
    public string m_name    = "";
    public string m_cArea   = "";
    public string m_nArea   = "";
    
    void MoveCard(string from, string to)
    {
        if (to != from)
        {
            to = to.ToLower();
            List<GameObject> temp = null;
            if (TableManager.instance.m_table.TryGetValue(to, out temp))
            {
                TableManager.instance.m_table[to].Add(gameObject);
                TableManager.instance.m_table[from].Remove(gameObject);
                m_cArea = to;
            }
            else
            {
                print("ERROR, PATH " + from.ToUpper() + " DOES NOT EXIST");
            }
        }
    }

    void Update()
    {
        MoveCard(m_cArea, m_nArea);
        transform.position = (Vector3)GetType().GetField("TableManager.instance." + m_cArea).GetValue(this);
    }
}
