alert('Boas vindas ao jogo do número secreto');
let numeroSecreto = parseInt(Math.random() * 100) + 1;
console.log(numeroSecreto);
let numeroTentado;
let tentativas = 0;

while (numeroTentado != numeroSecreto) {
    numeroTentado = prompt('Escolha um número entre 1 e 100');
    // se chute for igual ao numero secreto
    if (numeroTentado == numeroSecreto) {
        break;
    } else {
        if(numeroTentado > numeroSecreto) {
            alert(`O número secreto é menor que ${numetoTentado}`);
        } else {
            alert(`O número secreto é maior que ${numeroTentado}`);
        }
        tentativas+=1;
    }
}

let palavraTentativa = tentativas > 1 ? 'tentativas' : 'tentativa';
alert(`Isso aí! Você descobriu o número secreto em ${tentativas} ${palavraTentativa}`);



