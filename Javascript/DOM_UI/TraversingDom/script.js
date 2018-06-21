function traverseElements(element, ident){
    let spaces = '';

    for (let i = 0; i < ident; i++) {
        spaces+= ' ';      
    }
    if (element.tagName) {
        console.log(spaces + element.tagName);  
    }
    

    for (let index = 0; index < element.childNodes.length; index++) {
        traverseElements(element.childNodes[index], ident +1 );
    }
}

traverseElements(document.body, 0);