function exibeTextoNaTela(tag, texto){
    let elemento = document.querySelector(tag);
    elemento.innerHTML = texto;
}

exibeTextoNaTela('h1', 'Jogo do Nª Secreto');
exibeTextoNaTela('p', 'Escolha um número entre 1 a 10');

function numeroAleatorio(){
    return Math.floor(Math.random() * 10 + 1);
}

let numeroSecreto = numeroAleatorio();

function verificarChute(){
    let chute = document.querySelector('input').value;
    
    if(chute === numeroSecreto){
        exibeTextoNaTela('h1', 'Acertoooou!!');
        exibeTextoNaTela('p', 'Você descobriu o número secreto!!');
    } else if(chute > numeroSecreto){
        exibeTextoNaTela('h1', 'Errouuuu!!');
        exibeTextoNaTela('p', 'O número secreto é menor que o seu chute.');
    } else {
        exibeTextoNaTela('h1', 'Errouuuu!!');
        exibeTextoNaTela('p', 'O número secreto é maior que o seu chute.');
    }
}
