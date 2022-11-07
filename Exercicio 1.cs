Console.WriteLine("Por favor, introduza quanto você ganha por hora");
string renda_por_hora_input = Console.ReadLine();
bool conversao_renda_sucesso = float.TryParse(renda_por_hora_input, out float renda_por_hora);
if (!conversao_renda_sucesso) Console.WriteLine("Por favor, coloque um número válido");

Console.WriteLine("Por favor, introduza a quantidade de horas trabalhadas");
string horas_trabalhadas_input = Console.ReadLine();
bool conversao_horas_trabalhadas = float.TryParse(horas_trabalhadas_input, out float horas_trabalhadas);
if (!conversao_horas_trabalhadas) Console.WriteLine("Por favor, coloque um número válido");

float salario_bruto = renda_por_hora * horas_trabalhadas;

double deducao_ir = salario_bruto * 0.11;

double deducao_inss = salario_bruto * 0.08;

double deducao_sindicato = salario_bruto * 0.05;

double deducao_total = deducao_inss + deducao_ir + deducao_sindicato;

double salario_liquido = salario_bruto - deducao_total;

Console.WriteLine(@$" 
Seu salario bruto é R${salario_bruto}.

Foram deduzidos:
-R${deducao_ir} de Imposto de Renda.
-R${deducao_inss} de INSS.
-R${deducao_sindicato} do sindicato.

{deducao_ir} + {deducao_inss} + {deducao_sindicato} = {deducao_total}

Dedução total: R${deducao_total}.

Seu salário líquido é de R${salario_liquido}.
" );

