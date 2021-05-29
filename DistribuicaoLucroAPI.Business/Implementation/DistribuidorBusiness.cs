using DistribuicaoLucorAPI.Models;
using DistribuicaoLucorAPI.Models.Interface;
using DistribuicaoLucroAPI.Business.Interface;
using DistribuicaoLucrosAPI.DataAccess;
using DistribuicaoLucrosAPI.DataAccess.Interfaces;
using DistribuicaoLucrosAPI.DataAccess.Repositories;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace DistribuicaoLucroAPI.Business.Implementation
{
    public class DistribuidorBusiness //: IDistribuidorBusiness
    {


        private readonly DataContext dataContext;
        private readonly FuncionarioRepository funcionarioRepository;

        public DistribuidorBusiness(DataContext context)
        {
            dataContext = context;
            funcionarioRepository = new FuncionarioRepository(context);
        }



        public async Task<DistribuicaoResponse> EfetuaDistribuicao(decimal valorLucroDistribuir)
        {
            CultureInfo culturaBrasileira = new CultureInfo("pt-BR");
            DistribuicaoResponse distribuicaoResponse = new DistribuicaoResponse();
            distribuicaoResponse.participacoes = new List<Participacao>();

            try
            {

                distribuicaoResponse.total_disponibilizado = valorLucroDistribuir.ToString("C");

                var funcionarios = await funcionarioRepository.SelecionarTodosFuncionarios();
                decimal saldoDistribuido = 0;
                int qtdeFuncionarios = 0;

                foreach (var funcionario in funcionarios)
                {

                    //if ((valorLucroDistribuir - saldoDistribuido) <= 0)
                    //{
                    //    break;
                    //}


                    Participacao participacao = new Participacao();

                    //decimal salarioBrutoFormatadoSB = funcionario.salario_bruto.Replace("R$", "").Replace(" ", "").Replace(".", "").Replace(",", ".");

                    decimal salarioBrutoFormatadoSB = decimal.Parse(funcionario.salario_bruto, NumberStyles.Currency, culturaBrasileira);

                    int diasDeContratacao = DateTime.Now.Subtract(Convert.ToDateTime(funcionario.data_de_admissao)).Days;
                    decimal valorBonus = 0;
                    decimal calculoParte1SalarioVsPesoTempoAdmissao = 0;
                    decimal calculoParte2SalarioVsPesoAreaAtuacao = 0;
                    PesoTempoAdimissaoBusiness pesoTempoAdimissaoPTA = new PesoTempoAdimissaoBusiness(diasDeContratacao);
                    PesoAreaAtuacaoBusiness pesoAreaAtuacaoPAA = new PesoAreaAtuacaoBusiness();
                    PesoFaixaSalarialBusiness pesoFaixaSalarialPFS = new PesoFaixaSalarialBusiness(salarioBrutoFormatadoSB);

                    calculoParte1SalarioVsPesoTempoAdmissao = salarioBrutoFormatadoSB * pesoTempoAdimissaoPTA.pesoTempoAdimissao;
                    calculoParte2SalarioVsPesoAreaAtuacao = salarioBrutoFormatadoSB * pesoAreaAtuacaoPAA.PesoAreaAtuacao[funcionario.area];
                    valorBonus = (calculoParte1SalarioVsPesoTempoAdmissao + calculoParte2SalarioVsPesoAreaAtuacao) / pesoFaixaSalarialPFS.pesoPorFaixaSalarial;

                    saldoDistribuido += valorBonus;

                    //valorLucroDistribuir += valorBonus;

                    participacao.matricula = funcionario.matricula;
                    participacao.nome = funcionario.nome;
                    participacao.valor_da_participacao = valorBonus.ToString("C");
                    distribuicaoResponse.participacoes.Add(participacao);

                    qtdeFuncionarios++;
                    distribuicaoResponse.total_de_funcionarios = qtdeFuncionarios.ToString();

                    distribuicaoResponse.total_distribuido = saldoDistribuido.ToString("C");

                    distribuicaoResponse.saldo_total_disponibilizado = (valorLucroDistribuir - saldoDistribuido).ToString("C");

                }


                return distribuicaoResponse;

            }
            catch (Exception ex)
            {
                throw;
            }



        }
    }
}
