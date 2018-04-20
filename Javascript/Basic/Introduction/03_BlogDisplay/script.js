//Test on displaying data with javascript
// Yes is bad, messy and whrong! But this is first try

var actualPost1 = [
    Author = "Pesho",
    Header = "My First Post",
    Content = "Some text here to display new Pesho's Constent ",   
];

var allPosts = [actualPost1];

for(var i = 0; i < allPosts.length; i+= 1){
    initializePost(allPosts[i]);
}



function initializePost(post){
    var htmlDoc = document.getElementsByTagName('body');
    var text = "<h1>Post Author: " + post[0] + "</h1>" 
    + "<h4>" + post[1] + "</h4>" 
    + "<p>" + post[2] + "</p>" ;
   
    htmlDoc[0].innerHTML = text;
    
    
}