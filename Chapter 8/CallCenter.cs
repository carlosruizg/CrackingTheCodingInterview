
public abstract class Employee
{
	private HashSet<int> _casesThatCanHandle;
	public bool Available {get; private set;} = true
	public string Name {get; private set;}

	protected Employee(List<int> casesToHandle)
	{
		foreach(var caseId in casesToHandle)
		{
			if(_casesThatCanHandle.Contains(caseId) == false)
				_casesThatCanHandle.Add(caseId);
		}
	}

	public virtual bool CanHandleCase(int caseId)
	{
		return _casesThatCanHandle.Contains(caseId);
	}	

	public void StartCall()
	{
		Available = false;
	}

	public void FinishCall()
	{
		Available = true;
	}
}

public class Respondent : Employee
{
	public Respondent(string name, List<int> caseIds) : base(caseIds)
	{

	}
}

public class Manager : Employee
{
	public Manager(string name, List<int> caseIds) : base(caseIds)
	{

	}
}

public class Director : Employee
{
	public Director(string name)
	{

	}

	public override bool CanHandleCase(int caseId)
	{
		return true;
	}
}

public class CallCenter
{
	private List<Respondent> respondent;
	private List<Manager> managers;
	private List<Director> directors;

	public CallCenter(List<Respondent> resp, List<Manager> man, List<Director> dir)
	{
		this.respondent = resp;
		this.managers = man;
		this.directors = dir;
	}

	public void DispatchCall(int caseId)
	{
		GetEmployeeForCase(caseId).Call(caseId);
	}

	private Employee GetEmployeeForCase(int caseId)
	{
		var r = respondent.FirstOrDefault(r => r.CanHandleCase(caseId));
		if(r != null)
			return r;

		var m = manager.FirstOrDefault(m => m.CanHandleCase(caseId) && m.Available);
		if(m != null)
			return m;

		return directors.First(d => d.CanHandleCase(caseId));
	}
}