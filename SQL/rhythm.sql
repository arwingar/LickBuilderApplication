/* rhythm table */
CREATE TABLE rhythm (
	rhythm_ID INT NOT NULL,
	rhythm_name TEXT NOT NULL, 
	difficulty INT,
	PRIMARY KEY (rhythm_ID)
);

/* 	populate table 
	difficulty level based on creator's opinion */
INSERT INTO rhythm VALUES(1, 'Quarter Note', 1);
INSERT INTO rhythm VALUES(2, 'Eighth Note', 1);
INSERT INTO rhythm VALUES(3, 'Triplet', 2);
INSERT INTO rhythm VALUES(4, 'Sixteenth Note', 3);
INSERT INTO rhythm VALUES(5, 'Sextuplet', 4);
INSERT INTO rhythm VALUES(6, '32nd Note', 4);




/* 	show all elements in the rhythm table */
SELECT *
FROM rhythm;