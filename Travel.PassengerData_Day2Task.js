
   
   db.passengerData.insertMany([
   {
		firstName: "Krishna", 
		LastName: "Gupta", 
	    Age: 26 ,
		phone: "1234567909",
		travelHistory: [{
		   BookingID:"AGS1453", 
		   BookingDate:"02-01-2018", 
		   From:"Bangalore", 
		   Destination:"Delhi", 
		   TravelDate:"03-02-2018" }
		   ],
		foodPreferences: ["Chinese", "Indian-NonVeg", "Indian-Veg"],
		travelFrequency: [{
			"ToFro" : "Bangalore-Delhi",
			"Frequency" : 5
		},
		{
			"ToFro" : "Delhi-Bangalore",
			"Frequency" : 3
		},
		{
			"ToFro" : "Bangalore-Lucknow",
			"Frequency" : 1
		}
		]
	},
	{
		firstName: "Shailesh", 
		LastName: "Kumar", 
		Age: 29 , 
		phone: 77829478234,
		travelHistory: [{
			BookingID:"AGS1657", 
			BookingDate:"02-01-2018", 
			From:"Bangalore", 
			Destination:"Chennai", 
			TravelDate:"03-02-2018" }
			],
		foodPreferences: [ "Indian-NonVeg", "Indian-Veg"]
	},
	{
		firstName: "Devbrat", 
		LastName: "Singh", 
		phone: 78645204982,
		travelHistory: [{
			BookingID:"AGS1780", 
			BookingDate:"02-01-2018", 
			From:"Bangalore", 
			Destination:"Bhopal", 
			TravelDate:"03-02-2018" }
			],
		foodPreferences: [  "Indian-Veg", "Indian-NonVeg"]
	},
	{
		firstName: "Shubham", 
		LastName: "Tyagi", 
		Age: 24 , 
		phone: "78924347823",
		travelHistory: [{
			BookingID:"ATS1234", 
			BookingDate:"02-01-2018", 
			From:"Delhi", 
			Destination:"Bangalore", 
			TravelDate:"03-02-2018" }
			],
		travelFrequency: [{
			"ToFro" : "Bangalore-Delhi",
			"Frequency" : 4
		},
		{
			"ToFro" : "Delhi-Bangalore",
			"Frequency" : 5
		}]
	}
])
