namespace Mapbox.Examples
{
	using UnityEngine;
	using Mapbox.Utils;
	using Mapbox.Unity.Map;
	using Mapbox.Unity.MeshGeneration.Factories;
	using Mapbox.Unity.Utilities;
	using System.Collections.Generic;

	public class MapObj : MonoBehaviour
	{
		[SerializeField]
		AbstractMap _map;

		[SerializeField]
		[Geocode]
		string[] _locationStrings;
		Vector2d[] _locations;

		[SerializeField]
		float _spawnScale = 1f;

		[SerializeField]
		GameObject _markerPrefab;

		List<GameObject> _spawnedObjects;

		public KeralaFacility keralaFacility;

		public int value;

		double log;
		double lat;

		public int[] id;

		 int hos_id;

		private void Awake()
		{
			keralaFacility = GameObject.Find("Manager").GetComponent<KeralaFacility>();
		}

		void Start()
		{
			_spawnedObjects = new List<GameObject>();
		}

		public void Map_Data()
		{


			_locations = new Vector2d[_locationStrings.Length];

			id = new int[_locationStrings.Length];

			for (int i = 0; i < _locationStrings.Length; i++)
			{
				log = keralaFacility.facRoot.results[i].location.longitude;
				lat = keralaFacility.facRoot.results[i].location.latitude;

				_locationStrings[i] = new Vector2d(log, lat).ToString();
			}

			for (int i = 0; i < _locationStrings.Length; i++)
			{
				var locationString = _locationStrings[i];
				_locations[i] = Conversions.StringToLatLon(locationString);

				var instance = Instantiate(_markerPrefab);
				instance.transform.localPosition = _map.GeoToWorldPosition(_locations[i], true);
				instance.transform.localScale = new Vector3(_spawnScale, _spawnScale, _spawnScale);
				_spawnedObjects.Add(instance);

				for(int j =0; j < _spawnedObjects.Count; j++)
				{
					hos_id = keralaFacility.facRoot.results[j].id;
					id[j] = hos_id;

					_spawnedObjects[j].name = id[j].ToString();
				}
			}
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

			
		}
	}
}

