<Query Kind="Statements">
  <Connection>
    <ID>8792626c-a41e-41f4-bd84-62c52ffb2f36</ID>
    <NamingServiceVersion>2</NamingServiceVersion>
    <Persist>true</Persist>
    <Server>.</Server>
    <DeferDatabasePopulation>true</DeferDatabasePopulation>
    <Database>Chinook2018</Database>
  </Connection>
</Query>

// Statement IDE

// You can have multiple queries written in this IDE environment
// you can execute a query individually by highlighting the desired query first
// BY DEFAULT executing the file in this environment will execute
// ALL queries (statements) top to bottom

// IMPORTANT: Query syntax
// queries in this environment MUST be written using the
// C# language grammar for a statement. This means that
// each statement must end in a semi-colon
// Results MUST be placed in a receiving variable
// to display the results, use the LinqPad method .Dump()

// It appears that Method syntax
// does NOT need a semi-colon on the query if run individually
// does NOT need results placed in a receiving variable
// does need the .Dump() method to display results

// Find all albums released in 2000
// Display the entire album record

// Query
var paramyear = 1990; // imagine this is a parameter on a method sign
var results = from x in Albums
				where x.ReleaseYear == paramyear
				select x;
results.Dump(); // imagine this is the return statement in a method

// Method
Albums
	.Where(a => a.ReleaseYear == 2000)
	.Select(a => a)
	.Dump();