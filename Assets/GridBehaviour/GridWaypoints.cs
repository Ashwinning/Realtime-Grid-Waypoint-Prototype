using UnityEngine;
using System.Collections;

public class GridWaypoints : GridBehaviour 
{
	/// <summary>
	/// Creates the waypoints.
	/// Takes two inputs 0 from and to
	/// </summary>
	/// <param name="from">From.</param>
	/// <param name="to">To.</param>
	public void CreateWaypoints(Vector3 from, Vector3 to)
	{

	}

	void CreatePoint(Vector3 pos)
	{
		Instantiate(wayPoint)
	}

}
