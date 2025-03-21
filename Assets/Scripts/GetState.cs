using TMPro;
using Unity.Behavior;
using UnityEngine;

public class GetState : MonoBehaviour
{
    // Get the current value of a Behaviour agent and assingt it to a textMeshPro text

    private BehaviorGraphAgent agent;
    private BlackboardVariable <StatesEnemy> state;
    private BlackboardVariable<float> HP;
    private string textValue;
    public TextMeshProUGUI text;
    void Start()
    {
        agent = GetComponent<BehaviorGraphAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.BlackboardReference.GetVariable("New StatesEnemy", out state);
        agent.BlackboardReference.GetVariable("CurrentHp", out HP);
        textValue = ($"{state.Value.ToString()} Enemy HP:  {HP.Value.ToString()}");
        text.text = textValue;

    }
}
