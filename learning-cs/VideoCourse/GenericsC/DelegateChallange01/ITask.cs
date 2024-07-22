namespace DelegateChallange01;

public interface ITask<TResult>
{
    public TResult Perform();
}