## Day 2

During this session we will mainly focus on the CRUD operation in MongoDB.

### CRUD operations

* Create --> insertOne(data, options); insertMany(data, options)
* Read --> find(filter, options); findOne(filter, options)
* Update --> updateOne(filter, data, options); updateMany(filter, data, options); replaceOne(filter, data, options)
* Delete --> deleteOne((filter, options); deleteMany(filter, options)

### Understanding Projection, Embedded Document & Arrays
**Projection** means selecting only the necessary data rather than selecting whole of the data of a document.

Note: This data transformation is happening on the MongoDB server and not on the client side, so that you don't get the unneccesay data and don't impact the bandwidth.

E.g.

```
db.collection.find(query, projection)
```

**Embedded Document**  are documents with schemas of their own that are part of other documents.

E.g.
```
{
    "departureAirport": "BLR",
    "arrivalAirport": "DLI",
    "aircraft": "Airbus A320",
    "distance": 1850,
	  "Status": {
			"description": "on-time",
			"lastUpdated": "1 hour ago"}
  }
```
Note: Up to 100 level of nesting. Over all document size should be below 16 MB.


**Arrays**, MongoDB can have an array or array of embedded documents

E.g.
```
{ 
    item: "journal", 
    qty: 25, 
    tags: ["blank", "red"], 
    dim_cm: [ 14, 21 ] 
}
```
```
{ 
  item: "journal", 
  instock: [ 
    { warehouse: "A", qty: 5 }, 
    { warehouse: "C", qty: 15 } 
    ] 
}
```
 
### Task
1. Create a AirTravel database and create a passenger data collection
2. Insert 3 passenger records with one past air travel history
3. Update 1 passenger record with new age, new surname & history entry.
4. Find 1 passenger with age above 25 years( or a value of your choice)
5. Delete all passenger who's travel history has "DELHI" airport.

*Note: Please retain this database as we will be using it in the next session*
