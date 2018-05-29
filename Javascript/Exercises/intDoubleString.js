const getGets = (arr) => {
    let index = 0;

    return () => {
        const toReturn = arr[index];
        index += 1;
        return toReturn;
    };
};
// this is the test
const test = [
  'real',
  '-2',
  'Q',
  'p'
]

const gets = this.gets || getGets(test);
const print = this.print || console.log;

const typeInput = gets();

switch (typeInput) {
    case "integer":
        print(+gets()+1);
        break;
    case "real":
        print((+gets()+1).toFixed(2));
        break;
        case "text":
        print(gets()+"*");
        break;
    default:
        break;
}
