/* 	rudiments table 
	information used to fill this table comes from vicfirth.zildjian.com */
CREATE TABLE rudiments (
	rudiment_ID INT NOT NULL, 
	name TEXT NOT NULL, 
	tempi INT ARRAY[4],
	difficulties INT ARRAY[4],
	rhythm_ID INT,
	category TEXT, 
	PRIMARY KEY (rudiment_ID),
	FOREIGN KEY (rhythm_ID) REFERENCES rhythm (rhythm_ID) 
);

/* 	populate rudiments table 
	difficulty level based on creator's opinion */
/*	roll rudiments */
INSERT INTO rudiments VALUES(1, 'Single Stroke Roll', ARRAY[100,120], ARRAY[3,4], 6, 'Roll');
INSERT INTO rudiments VALUES(2, 'Single Stroke Four', ARRAY[100,120,140,160], ARRAY[3,3,4,4], 5, 'Roll');
INSERT INTO rudiments VALUES(3, 'Single Stroke Seven', ARRAY[100,120], ARRAY[4,4], 5, 'Roll');
INSERT INTO rudiments VALUES(4, 'Multiple Bounce Roll', ARRAY[100,120,140,160], ARRAY[1,1,2,2], 1, 'Roll');
INSERT INTO rudiments VALUES(5, 'Triple Stroke Roll', ARRAY[100,120], ARRAY[3,4], 5, 'Roll');
INSERT INTO rudiments VALUES(6, 'Double Stroke Roll', ARRAY[100,120,140,160], ARRAY[1,1,1,2], 2, 'Roll');
INSERT INTO rudiments VALUES(7, 'Five Stroke Roll', ARRAY[100,120,140,160], ARRAY[1,1,2,3], 2, 'Roll');
INSERT INTO rudiments VALUES(8, 'Five Stroke Roll Triple', ARRAY[100,120,140,160], ARRAY[2,2,3,4], 3, 'Roll');
INSERT INTO rudiments VALUES(9, 'Six Stroke Roll', ARRAY[100,120,140,160], ARRAY[1,1,2,3], 2, 'Roll');
INSERT INTO rudiments VALUES(10, 'Seven Stroke Roll', ARRAY[100,120,140,160], ARRAY[1,2,3,4], 1, 'Roll');
INSERT INTO rudiments VALUES(11, 'Seven Stroke Roll Triple', ARRAY[100], ARRAY[4], 3, 'Roll');
INSERT INTO rudiments VALUES(12, 'Nine Stroke Roll', ARRAY[100,120], ARRAY[3,4], 1, 'Roll');
INSERT INTO rudiments VALUES(13, 'Ten Stroke Roll', ARRAY[100,120,140,160], ARRAY[2,3,3,4], 2, 'Roll');
INSERT INTO rudiments VALUES(14, 'Eleven Stroke Roll', ARRAY[100,120,140,160], ARRAY[2,2,3,3], 2, 'Roll');
INSERT INTO rudiments VALUES(15, 'Thirteen Stroke Roll', ARRAY[100,120], ARRAY[3,4], 1, 'Roll');
INSERT INTO rudiments VALUES(16, 'Fifteen Stroke Roll', ARRAY[100,120], ARRAY[3,4], 2, 'Roll');
INSERT INTO rudiments VALUES(17, 'Seventeen Stroke Roll', ARRAY[100,120], ARRAY[3,4], 1, 'Roll');
/*	paradiddle rudiments */
INSERT INTO rudiments VALUES(18, 'Single Paradiddle', ARRAY[100,120,140,160], ARRAY[2,2,3,3], 4, 'Paradiddle');
INSERT INTO rudiments VALUES(19, 'Double Paradiddle', ARRAY[100,120,140,160], ARRAY[2,3,3,4], 4, 'Paradiddle');
INSERT INTO rudiments VALUES(20, 'Triple Paradiddle', ARRAY[100,120,140,160], ARRAY[2,2,3,3], 4, 'Paradiddle');
INSERT INTO rudiments VALUES(21, 'Paradiddle-Diddle', ARRAY[100,120,140,160], ARRAY[2,3,4,4], 4, 'Paradiddle');
/*	flam rudiments */
INSERT INTO rudiments VALUES(22, 'Flam', ARRAY[100,120,140,160], ARRAY[1,1,1,1], 1, 'Flam');
INSERT INTO rudiments VALUES(23, 'Flam Accent', ARRAY[100,120,140,160], ARRAY[2,3,3,4], 3, 'Flam');
INSERT INTO rudiments VALUES(24, 'Flam Tap', ARRAY[100,120], ARRAY[3,4], 4, 'Flam');
INSERT INTO rudiments VALUES(25, 'Flamacue', ARRAY[100,120], ARRAY[3,4], 4, 'Flam');
INSERT INTO rudiments VALUES(26, 'Flam Paradiddle', ARRAY[100,120,140], ARRAY[3,4,4], 4, 'Flam');
INSERT INTO rudiments VALUES(27, 'Flammed Mill', ARRAY[100,120,140], ARRAY[3,3,4], 4, 'Flam');
INSERT INTO rudiments VALUES(28, 'Flam Paradiddle-Diddle', ARRAY[100,120], ARRAY[3,4], 4, 'Flam');
INSERT INTO rudiments VALUES(29, 'Patafla-fla', ARRAY[100,120,140], ARRAY[3,4,4], 4, 'Flam');
INSERT INTO rudiments VALUES(30, 'Swiss Army Triplet', ARRAY[100,120,140,160], ARRAY[2,3,3,4], 3, 'Flam');
INSERT INTO rudiments VALUES(31, 'Inverted Flam Tap', ARRAY[100], ARRAY[4], 4, 'Flam');
INSERT INTO rudiments VALUES(32, 'Flam Drag', ARRAY[100,120,140,160], ARRAY[2,3,4,4], 3, 'Flam');
/* 	drag rudiments */
INSERT INTO rudiments VALUES(33, 'Drag', ARRAY[100,120,140,160], ARRAY[1,1,1,1], 1, 'Drag');
INSERT INTO rudiments VALUES(34, 'Single Drag Tap Triplet', ARRAY[100,120,140,160], ARRAY[1,2,3,4], 3, 'Drag');
INSERT INTO rudiments VALUES(35, 'Single Drag Tap', ARRAY[100,120], ARRAY[3,4], 4, 'Drag');
INSERT INTO rudiments VALUES(36, 'Double Drag Tap', ARRAY[100], ARRAY[4], 4, 'Drag');
INSERT INTO rudiments VALUES(37, 'Lesson 25', ARRAY[100,120,140,160], ARRAY[1,1,2,3], 2, 'Drag');
INSERT INTO rudiments VALUES(38, 'Single Dragadiddle', ARRAY[100,120], ARRAY[3,4], 4, 'Drag');
INSERT INTO rudiments VALUES(39, 'Drag Paradiddle 1', ARRAY[100,120], ARRAY[3,4], 4, 'Drag');
INSERT INTO rudiments VALUES(40, 'Drag Paradiddle 2', ARRAY[100], ARRAY[4], 4, 'Drag');
INSERT INTO rudiments VALUES(41, 'Single Ratamacue', ARRAY[100,120,140,160], ARRAY[2,2,3,4], 5, 'Drag');
INSERT INTO rudiments VALUES(42, 'Double Ratamacue', ARRAY[100,120,140,160], ARRAY[3,3,4,4], 5, 'Drag');
INSERT INTO rudiments VALUES(43, 'Triple Ratamcue', ARRAY[100,120,140,160], ARRAY[2,2,3,4], 5, 'Drag');




/* 	show all values in the rudiments table */
SELECT * FROM rudiments;

/* 	show the rudiment name and category for all 16th note rudiments */
SELECT ru.name, ru.category 
FROM rudiments ru, rhythm rh 
WHERE ru.rhythm_ID = rh.rhythm_ID 
AND rh.rhythm_ID = 4;