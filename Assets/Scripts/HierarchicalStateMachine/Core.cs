using UnityEngine;

public abstract class Core : MonoBehaviour
{
    public State Root;

    void Start()
    {
        Debug.Log("start executed on Core");
        OnStart();
        Root.Init(this);
        Root.Enter();
    }

    protected abstract void OnStart();
    void Update()
    {
        Root.Process();
    }
}

