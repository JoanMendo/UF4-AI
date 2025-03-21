using Unity.Behavior;
using UnityEngine;

public class DamageEnemy : MonoBehaviour, IDamage
{
    private BehaviorGraphAgent agent;
    private BlackboardVariable<float> CurrentHp;

    void Start()
    {
        // Obtener la referencia al BehaviorGraphAgent en el objeto
        agent = GetComponent<BehaviorGraphAgent>();
    }

    void Update()
    {
        // Obtener la variable CurrentHp del Blackboard
        agent.BlackboardReference.GetVariable("CurrentHp", out CurrentHp);

        // Detectar clic en el personaje
        if (Input.GetMouseButtonDown(0)) // 0 es el botón izquierdo del ratón
        {
            // Realizar un raycast para verificar si se hizo clic en el personaje
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Verificar si el clic fue sobre el mismo objeto que tiene este script
                if (hit.collider.gameObject == gameObject)
                {
                   
                    TakeDamage(10f);
                }
            }
        }
    }

    public void TakeDamage(float damage)
    {
        // Restar 10 al valor de CurrentHp
        CurrentHp.Value -= damage;

        // Actualizar el valor del Blackboard
        agent.BlackboardReference.SetVariableValue("CurrentHp", CurrentHp.Value);

    }
}
