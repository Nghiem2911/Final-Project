function asyncFunction(callback) {
    console.log("Starbucks");
    setTimeout(() => {
       callback();
    }, 1000);
    console.log("Highlands");
 }
 
 let printEnd = function() {
    console.log("KOI");
 }
 
 asyncFunction(printEnd)

 