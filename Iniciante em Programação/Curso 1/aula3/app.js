alert('Boas vindas ao jogo do número secreto');
let numeroSecreto = 5;
console.log(numeroSecreto);
let numeroTentado;
let tentativas = 0;
while (numeroTentado != numeroSecreto) {
    numeroTentado = prompt('Escolha um número entre 1 e 10');
    tentativas+=1;
    // se chute for igual ao numero secreto
    if (numeroTentado == numeroSecreto) {
        alert(`Acertou o numero secreto ${numeroSecreto} com ${tentativas} tentativas`);
    } else {
        if(numeroTentado > numeroSecreto) {
            alert('O número secreto é menor');
        } else {
            alert('O número secreto é maior');
        }
    }
}



