alert('Boas vindas ao jogo do número secreto');
let numeroSecreto = 5;
console.log(numeroSecreto);
let numeroTentado = prompt('Escolha um número entre 1 e 10');

// se chute for igual ao numero secreto
if(numeroTentado == numeroSecreto){
    alert(`Acertou o numero secreto ${numeroSecreto}`);
}else{
    alert('você errou ;(');
}
