//1)) Criar uma função que exibe "Olá, mundo!" no console.
function saudacao(){
    console.log('Olá, mundo!');
}

saudacao();

//2)) Criar uma função que recebe um nome como parâmetro e exibe "Olá, [nome]!" no console.
let nome = 'Joao';

function saudar(){
    console.log(`Olá, ${nome}`);
}

//3)) Criar uma função que recebe um número como parâmetro e retorna o dobro desse número.
let num = 5;

function dobrar(num){
    let dobro = num * 2;

    return dobro;
}

console.log(dobrar(num))

//4)) Criar uma função que recebe três números como parâmetros e retorna a média deles.
let num1 = 5;
let num2 = 5;
let num3 = 5;

function calculaMedia(num1, num2, num3){
    let media = (num1 + num2 + num3) / 3;
    return media;
}

console.log(`A média é ${calculaMedia(num1, num2, num3)}`);

//5)) Criar uma função que recebe dois números como parâmetros e retorna o maior deles.
let numero1 = 5;
let numero2 = 10;

function calculaMaior(num1, num2){
    let maior = Math.max(num1, num2);
    return maior;
}
console.log(`O maior número é ${calculaMaior(numero1, numero2)}`);

//6)) Criar uma função que recebe um número como parâmetro e retorna o resultado da multiplicação desse número por ele mesmo
let numero = 5;

function quadrado(num){
    let quadrado = num * num;

    return quadrado;
}

console.log(`O quadrado é ${quadrado(numero)}`);
