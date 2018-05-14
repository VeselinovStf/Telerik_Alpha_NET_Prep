//Write a JS function that stores the name and age of two persons in objects and then filters them by minimum age

function createPerson(name, age) {
    let person = {
        name: name,
        age: Number(age)
    };

    return person;
}

function filterByAge(filterValuee,
    firstName,
    firstAge,
    secondName,
    secondAge) {

    let firstPerson = createPerson(firstName, firstAge);
    let secondPerson = createPerson(secondName, secondAge);

    if (firstPerson.age >= filterValuee) {
        console.log(firstPerson)
    }
    else if (secondPerson.age >= filterValuee) {
        console.log(secondPerson);
    }
    
}

filterByAge(12, 'Ivan', 15, 'Asen', 9);