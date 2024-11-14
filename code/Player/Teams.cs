namespace astral_base.SCPRP;

public static class Teams
{
	public static Dictionary<string, Team> Jobs { get; } = new();

	// On Start load all jobs
	static Teams()
	{
		Log.Info( "Loading groups..." );
		Jobs.Clear();
        
		foreach ( var job in ResourceLibrary.GetAll<Team>() )
		{
			Log.Info( $"Loading job: {job.Name}" );
			Jobs[job.Name] = job;
		}
	}
	
	// Get default job when player spawns
	public static Team Default()
	{
		return ResourceLibrary.Get<Team>( "gameplay/jobs/citizen.team" );
	}
}
