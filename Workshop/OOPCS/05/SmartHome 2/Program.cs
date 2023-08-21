using System.Collections.Generic;
using SmartHome;

Random rand = new Random();

// create lamps
SmartLamp[] lamps = new SmartLamp[] {
  new SmartLamp("living_room_lamp"),
  new SmartLamp("master_room_lamp"),
  new SmartLamp("study_room_lamp")
};

int times;

// simulate using lamp
foreach (SmartLamp lamp in lamps) {
	times = rand.Next(8, 21);

	for (int i = 0; i < times; i++) {
		// simulate use by TURNING ON and OFF
		lamp.TurnOn();
		lamp.TurnOff();
	}
}

// create fridge object
SmartFridge fridge = new SmartFridge("fridge");

// simulate using fridge
times = rand.Next(15, 25);
for (int i = 0; i < times; i++) {
	// simulate use by OPENING and CLOSING
	fridge.Open();
	fridge.Close();
}

Dictionary<string, uint> dict = new Dictionary<string, uint>() {
	{ "Lamp", 15 },
	{ "Fridge", 20 }
};

/******************************************
 * checking the health of appliances
 *****************************************/ 
HealthChecker checker = new HealthChecker(dict);

foreach (SmartLamp lamp in lamps)
	checker.CheckHealth(lamp);
checker.CheckHealth(fridge);





