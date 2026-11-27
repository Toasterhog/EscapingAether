public abstract class PlayerState : State
{
    protected PlayerCore core;
    public override void SetCore(Core _core) => core ??= (PlayerCore)_core;
    //protected float time;
}