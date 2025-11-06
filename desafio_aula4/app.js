//1)Crie um programa que utilize o console.log para exibir uma mensagem de boas-vindas.
mensagem = "Boas vindas ao mundo da programação! Hello World!";
console.log(mensagem);

//2)Crie uma variável chamada "nome" e atribua a ela o seu nome. Em seguida, utilize o console.log para exibir a mensagem "Olá, [seu nome]!" no console do navegador.
nome = "João Vitor";
console.log(`Olá, ${nome}`);

//3)Crie uma variável chamada "nome" e atribua a ela o seu nome. Em seguida, utilize o alert para exibir a mensagem "Olá, [seu nome]!" .
nome = "João Vitor";
alert(`Olá, ${nome}`);

//4)Utilize o prompt e faça a seguinte pergunta: Qual a linguagem de programação que você mais gosta?. Em seguida, armazene a resposta em uma variável e mostre no console do navegador.
linguagem = prompt("Qual a linguagem de programação que você mais gosta?");
console.log(`A linguaguem que você mais gosta é ${linguagem}`);

//5)Crie uma variável chamada "valor1" e outra chamada "valor2", atribuindo a elas valores numéricos de sua escolha. Em seguida, realize a soma desses dois valores e armazene o resultado em uma terceira variável chamada "resultado". Utilize o console.log para mostrar a mensagem "A soma de [valor1] e [valor2] é igual a [resultado]." no console.
function soma() {
    let valor1 = 5;
    let valor2 = 5;
    let resultado = valor1 + valor2;
    console.log(`A soma do ${valor1} e ${valor2} é igual a ${resultado}.`)
}
soma();
//6)Crie uma variável chamada "valor1" e outra chamada "valor2", atribuindo a elas valores numéricos de sua escolha. Em seguida, realize a subtração desses dois valores e armazene o resultado em uma terceira variável chamada "resultado". Utilize o console.log para mostrar a mensagem "A diferença entre [valor1] e [valor2] é igual a [resultado]." no console.
function subtracao(){
    let valor1 = 5;
    let valor2 = 5;
    let resultado = valor1 - valor2;
    console.log(`A diferença entre ${valor1} e ${valor2} é igual a ${resultado}.`)
}
subtracao()
//7)Peça ao usuário para inserir sua idade com prompt. Com base na idade inserida, utilize um if para verificar se a pessoa é maior ou menor de idade, exibindo uma mensagem apropriada no console.
idade = +prompt("Qual a sua idade?");
if(idade>18){
    console.log("Você é maior de idade!");
}else{
    console.log("Você é menor de idade!");
}

//8)Crie uma variável "numero" e peça um valor com prompt verifique se é positivo, negativo ou zero. Use if-else para imprimir a respectiva mensagem.
numero = +prompt("Digite um número!");
if(numero===0){
    console.log('O número é zero');
}
else if(numero>0){
    console.log('O número é positivo');
}
else{
    console.log('O número é negativo');
}

//9)Use um loop while para imprimir os números de 1 a 10 no console.
let i = 0;
while(i<=10){
    console.log(i);
    i+=1;
}

//10)Crie uma variável "nota" e atribua um valor numérico a ela. Use if-else para determinar se a nota é maior ou igual a 7 e exiba "Aprovado" ou "Reprovado" no console.
let nota = +prompt('Qual sua nota?');
if(nota>=7){
    console.log('Aprovado!');
}
else{
    console.log('Reprovado');
}
//11)Use o Math.random para gerar qualquer número aleatório e exiba esse número no console.
let aleatorio = Math.random() * 100;
console.log(`O número aleatório é ${aleatorio}`);

//12)Use o Math.random para gerar um número inteiro entre 1 e 10 e exiba esse número no console.
let aleatorio2 = Math.floor(Math.random() * 10) + 1;
console.log(`O número aleatório entre 1 e 10 é ${aleatorio2}`);

//13)Use o Math.random para gerar um número inteiro entre 1 e 1000 e exiba esse número no console.
let aleatorio3 = Math.floor(Math.random() * 1000) + 1;
console.log(`O número aleatório entre 1 e 1000 é ${aleatorio3}`);
