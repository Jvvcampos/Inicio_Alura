//1)Altere o conteúdo da tag h1 com document.querySelector e atribua o seguinte texto: Hora do Desafio.
let titulo = document.querySelector('h1');
titulo.innerHTML = 'Hora do desafio';

//2)Crie uma função que exiba no console a mensagem O botão foi clicado sempre que o botão Console for pressionado.
function clicaConsole(){
    console.log('O botão foi clicado');
}

//3)Crie uma função que exiba um alerta com a mensagem: Eu amo JS, sempre que o botão Alerta for pressionado.
function clicaAlerta(){
    alert('Eu amo JS!');
}

//4)Crie uma função que é executada quando o botão prompt é clicado, perguntando o nome de uma cidade do Brasil. Em seguida, exiba um alerta com a mensagem concatenando a resposta com o texto: Estive em {cidade} e lembrei de você.
function clicaPrompt(){
    let cidade = prompt('Qual o nome da cidade que você está?');
    alert(`Estive em ${cidade} e me lembrei de você`);
}

//5))Ao clicar no botão soma, peça 2 números inteiros e exiba o resultado da soma em um alerta.
function clicaSoma(){
    let num1 = +prompt('Me dê o valor do número 1: ');
    let num2 = +prompt('Me dê o valor do número 2: ');
    let soma = num1 + num2;
    alert(`A soma do ${num1} e o do ${num2} é igual à ${soma}`);
}
