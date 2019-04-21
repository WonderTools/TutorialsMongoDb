### Day 3

During this day be will take a closer look into the MongoDB Queries.

**PS : We will be using the AirTravel DB for performing all the below mentioned operations**


#### Comparison Operator

Name  | Description
------------ | -------------
 $eq   | Matches values that are equal to a specified value.
$gt   | Matches values that are greater than a specified value
$gte | Matches values that are greater than or equal to a specified value.
$in | Matches any of the values specified in an array.

Task
1. Find all the passenger who's Age is equal to 25.
2. Find all the passenger who's Age is greater than 25.
3. Find all the passenger who's Age is greater than or equal to 25.
4. Find all passenger who's Food preference is "Indian-Veg" & "Chinese"

*There are many more operation, please refer mongoDB documentation, link at the end of this chapter*

#### Logical Operator

Name  | Description
------------ | -------------
 $and   | Joins query clauses with a logical AND returns all documents that match the conditions of both clauses.
$not   | Inverts the effect of a query expression and returns documents that do not match the query expression.
 $nor   | Joins query clauses with a logical NOR returns all documents that fail to match both clauses.
$or   | Joins query clauses with a logical OR returns all documents that match the conditions of either clause.




#### Elements

Name  | Description
------------ | -------------
 $exist   | Matches documents that have the specified field.
$type   | Selects documents if a field is of the specified type.

Task
1. Find the number of documents for which the user have given the airline's rating.

#### Evaluation

Name  | Description
------------ | -------------
 $expr   | Allows use of aggregation expressions within the query language.


#### Array

Name  | Description
------------ | -------------
 $all   | Matches arrays that contain all elements specified in the query.
$elemMatch   | Selects documents if element in the array field matches all the specified $elemMatch conditions.
$size | Selects documents if the array field is a specified size.


[Query Operator documentation](https://docs.mongodb.com/manual/reference/operator/query/)
