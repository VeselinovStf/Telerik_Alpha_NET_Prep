function filterByAge([filterAge, 
    firstPersonName, 
    firstPersonAge,
    secondPersonName,
    secondPersonAge]) {
    
        let firstPerson = {
            name: firstPersonName,
            age: Number(firstPersonAge)
        };

        let secondPerson = {
            name: secondPersonName,
            age: Number(secondPersonAge)
        } 

        if (firstPerson.age > filterAge) {
            console.log(firstPerson)
        }
        if (secondPerson.age > filterAge) {
            console.log(secondPerson)
        }
};