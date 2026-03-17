/*
Você está criando um sistema de tarefas agendadas. O sistema deve executar diferentes tipos de tarefas, 
como fazer backup, enviar relatórios e limpar arquivos temporários. Cada tarefa precisa seguir uma estrutura 
comum com um método chamado Executar().

- Crie uma classe abstrata chamada TarefaAgendada com um método abstrato Executar(). 
- Depois, crie três classes que herdam dela: BackupTarefa, RelatorioTarefa e LimpezaTarefa. Cada uma deve sobrescrever o método Executar com uma lógica própria.
- Por fim, crie uma lista de TarefaAgendada com diferentes tipos de tarefas e percorra essa lista, executando cada uma.
*/
using AgendaTask.Model;

List<TarefaAgendada> tarefas = new List<TarefaAgendada>
{
    new BackupTarefa(),
    new LimpezaTarefa(),
    new RelatorioTarefa()
};

foreach(var tarefa in tarefas)
{
    tarefa.Executar();
}