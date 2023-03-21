/* 	there will be 4 different possible compositions that can be created for each difficulty 
	varying in length because some difficulties have fewer rudiments for each tempo 
	i.e., 4 different views per difficulty 
	ideally, we want to choose the 'longest' composition 
	so the view that has the most rows 
	or, the max value of: 
	select count(rudiment_id) from ______ where tempo = _____ 
	^^^ fill in the blank for table name and each tempo 
	
	This should be the extent of what needs to happen in SQL. 
	The rest of the computations can/will take place within Visual Studio in another language. 
*/
	
	
	
	
	




/* create a table that separates the array data in the rudiments table */
create table unnested as 
	select rudiment_id, name, unnest(tempi) as tempo, unnest(difficulties) as diff, rhythm_id, category 
	from rudiments;
/* test to make sure it works */
select * from unnested;






	
	
	
/* table of rudiments with difficulty 4 */
create table hard as 
	select rudiment_id, name, tempo 
	from unnested 
	where diff=4;
	
/* test, tempo in ascending order */
select * from hard order by tempo;

/* create view of rudiments for tempo that has the most rudiments associated with it */
create view hard_120 as 
	select * 
	from hard 
	where tempo=120;
	
/* other views for hard level that have fewer rudiments */
create view hard_100 as 
	select * 
	from hard 
	where tempo=100;
create view hard_140 as 
	select * 
	from hard 
	where tempo=140;
create view hard_160 as 
	select * 
	from hard 
	where tempo = 160;
	
	
	
	

	
	
	
	
/* table of rudiments with difficulty 3 */
create table medium_hard as 
	select rudiment_id, name, tempo 
	from unnested 
	where diff=3;
	
/* test, tempo in ascending order */
select * from medium_hard order by tempo;

/* create view of rudiments for tempo that has the most rudiments associated with it */
create view medium_hard_100 as 
	select * 
	from medium_hard 
	where tempo=100;
	
/* other views for medium_hard level that have fewer rudiments */
create view medium_hard_120 as 
	select * 
	from medium_hard 
	where tempo=120;
create view medium_hard_140 as 
	select * 
	from medium_hard 
	where tempo=140;
create view medium_hard_160 as 
	select * 
	from medium_hard 
	where tempo = 160;
	
	
	
	
	
	
	
	
	
/* table of rudiments with difficulty 2 */
create table medium_easy as 
	select rudiment_id, name, tempo 
	from unnested 
	where diff=2;
	
/* test, tempo in ascending order */
select * from medium_easy order by tempo;

/* create view of rudiments for tempo that has the most rudiments associated with it */
create view medium_easy_100 as 
	select * 
	from medium_easy
	where tempo=100;
	
/* other views for medium_easy level that have fewer rudiments */
create view medium_easy_120 as 
	select * 
	from medium_easy
	where tempo=120;
create view medium_easy_140 as 
	select * 
	from medium_easy 
	where tempo=140;
create view medium_easy_160 as 
	select * 
	from medium_easy 
	where tempo = 160;
	
	
	
	
	
	
	
	
	
/* table of rudiments with difficulty 1 */
create table easy as 
	select rudiment_id, name, tempo 
	from unnested 
	where diff=1;
	
/* test, tempo in ascending order */
select * from easy order by tempo;

/* create view of rudiments for tempo that has the most rudiments associated with it */
create view easy_100 as 
	select * 
	from easy
	where tempo=100;
	
/* other views for easy level that have fewer rudiments */
create view easy_120 as 
	select * 
	from easy
	where tempo=120;
create view easy_140 as 
	select * 
	from easy 
	where tempo=140;
create view easy_160 as 
	select * 
	from easy 
	where tempo = 160;