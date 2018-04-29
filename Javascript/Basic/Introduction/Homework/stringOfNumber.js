function stringOfNumber(params) {
    let result = "";
    for (let i = 1; i <= Number(params); i++) {
        const element = String(i);
        result += element
    }

    console.log(result);
}