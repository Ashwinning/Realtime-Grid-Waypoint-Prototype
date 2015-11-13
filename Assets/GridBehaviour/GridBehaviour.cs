using UnityEngine;
using System.Collections;

public class GridBehaviour : MonoBehaviour
{

		int _unit;
		/// <summary>
		/// Get or set the unit of the grid.
		/// Int.
		/// </summary>
		/// <value>The unit.</value>
		public int unit
		{
			get
			{
				return this._unit;
			}
			set
			{
				this._unit = value;
			}
		}

		GameObject _wayPoint;
		/// <summary>
		/// Gets or sets the way point.
		/// Waypoint gameobject is used to debug 
		/// the properties of a waypoint.
		/// </summary>
		/// <value>The way point.</value>
		public GameObject wayPoint
		{
			get
			{
				return this._wayPoint;
			}
			set
			{
				this._wayPoint = value;
			}
		}
	

}
