//the script encounters a scoping issue. The below is the solution

function createArrayOfFunctions(y) {
  var arr = [];
  for(var i = 0; i<y; i++)(function(i){
    arr[i] = function(x) { return x + i; }
  })(i);
  return arr;
}
