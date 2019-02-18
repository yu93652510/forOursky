The difficulty is the array.length function is start from 1, but the indicator of the array (e.g. i & j) in the forloop counts from 0.
To solve the problem, I introduce a (arr1Length-1) while check the false case
