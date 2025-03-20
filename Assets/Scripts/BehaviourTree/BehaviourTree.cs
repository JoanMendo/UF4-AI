using UnityEngine;

public class BehaviourTree : MonoBehaviour
{
   public NodoBase nodoRaiz;

    // Update is called once per frame
    void Update()
    {
        if(nodoRaiz != null)
        {
            nodoRaiz.ExecuteNode();
        }
    }
}
