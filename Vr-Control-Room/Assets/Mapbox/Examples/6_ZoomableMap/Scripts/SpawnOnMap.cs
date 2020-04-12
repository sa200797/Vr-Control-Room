namespace Mapbox.Examples
{
	using UnityEngine;
	using Mapbox.Utils;
	using Mapbox.Unity.Map;
	using Mapbox.Unity.MeshGeneration.Factories;
	using Mapbox.Unity.Utilities;
	using System.Collections.Generic;

	public class SpawnOnMap : MonoBehaviour
	{
		[SerializeField]
		AbstractMap _map;

		[SerializeField]
		[Geocode]
		string[] _locationStrings;
		Vector2d[] _locations;

		[SerializeField]
		float _spawnScale = 100f;

		[SerializeField]
		GameObject _markerPrefab;

		List<GameObject> _spawnedObjects;


		public KeralaFacility keralaFacility;

		public int value;

		double log;
		double lat;


		public int[] id;




		private void Awake()
		{
			keralaFacility = GameObject.Find("Manager").GetComponent<KeralaFacility>();






		}

		void Start()
		{









			//_locations = new Vector2d[_locationStrings.Length];
			_spawnedObjects = new List<GameObject>();


			//for (int i = 0; i < _locationStrings.Length; i++)
			for (int i = 0; i < _locationStrings.Length; i++)
			{

				//var locationString = _locationStrings[i];
				//_locations[i] = Conversions.StringToLatLon(locationString);


				//var points = _locationStrings[i];
				//	_locations[i] = Conversions.StringToLatLon(points);



				//var instance = Instantiate(_markerPrefab);
				//instance.transform.localPosition = _map.GeoToWorldPosition(_locations[i], true);
				//instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
				//_spawnedObjects.Add(instance);


			}

		}

		public void Map_Data()
		{
			Debug.Log(_locationStrings.Length + "??????} } }}}");


			for (int i = 0; i < _locationStrings.Length; i++)
			{
				log = keralaFacility.facRoot.results[i].location.longitude;
				lat = keralaFacility.facRoot.results[i].location.latitude;

				var points = new Vector2d(log, lat).ToString();

				
				//var points = lat +", " + log ;

				Debug.Log("?????::----" + log + "," + lat);

				Debug.Log("points---" + points);


				_locationStrings[i] = points;

				_locations[i] = Conversions.StringToLatLon(points);

				//var locationString = _locationStrings[i];

				//if (locationString != null)
				//{

				//	_locationStrings[i] = points;
				//}


			


				var instance = Instantiate(_markerPrefab);
				instance.transform.localPosition = _map.GeoToWorldPosition(_locations[i], true);
				instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
				_spawnedObjects.Add(instance);

			}
		}


		public void map_Id()
		{

		}

		private void Update()
		{
			int count = _spawnedObjects.Count;
			for (int i = 0; i < count; i++)
			{
				var spawnedObject = _spawnedObjects[i];
				var location = _locations[i];
				spawnedObject.transform.localPosition = _map.GeoToWorldPosition(location, true);
				spawnedObject.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);

			}


			if (value != keralaFacility.facRoot.results.Length)
			{
				value = keralaFacility.facRoot.results.Length;
				_locationStrings = new string[value];

				Map_Data();
			}

			//Map_Data();
		}
	}
}

