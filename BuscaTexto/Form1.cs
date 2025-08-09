using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace BuscaTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CleanText()
        {
            texto.Clear(); //limpa o texto
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CleanText(); //limpa o texto
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this,
               "Busca em Texto - 2025/1\n\nDesenvolvido por:\n72300574 - Victor Augusto Dias Mendes do Valle\n 72301112 - Gustavo Henrique Pereira \n\nProf. Virgílio Borges de Oliveira\n Prof. Roselene Henrique Pereira Costa\n\nAlgoritmos e Estruturas de Dados II\nFaculdade COTEMIG\nSomente para fins didáticos.",
               "Sobre o trabalho...",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK) //se o usuário selecionar um arquivo e clicar no botão abrir
                {
                    CleanText(); //limpa o texto antes de abrir o arquivo
                    StreamReader stream = new StreamReader(openFileDialog.FileName); //abre o arquivo selecionado
                    texto.Text = stream.ReadToEnd(); //le o arquivo e passa o conteúdo para o texto
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Abrir Arquivo", MessageBoxButtons.OK, MessageBoxIcon.Error); //se ocorrer algum erro ao abrir um arquivo, mostrar erro ao usuário
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Algoritmo
        private void SelectText(int comeco, string padrao) // Seleciona o Texto
        {
            try
            {
                texto.Focus(); 
                texto.Select(comeco, padrao.Length); //selecionando no texto
                texto.SelectionBackColor = Color.Green; //colorindo o fundo
                if (cbx_localizarSubstituir.Checked) //se a opção de localizar e substituir estiver selecionada, irá substituir o texto marcado pela string informada
                    texto.Text = texto.Text.Replace(texto.SelectedText, txt_substituir.Text); //substituindo no texto
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Selecionar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void forçaBrutaToolStripMenuItem_Click(object sender, EventArgs e) //algoritmo Força Bruta
        {
            try
            {
                texto.Focus();
                texto.SelectAll(); //removendo a seleção anterior
                texto.SelectionBackColor = texto.BackColor;
                texto.Select(0, 0);

                string padrao = Interaction.InputBox("Digite o padrão que deseja pesquisar", "Pesquisa - Força Bruta"); //input do usuário com o padrão desejado para a pesquisa
                if (padrao == "")
                    throw new Exception("Insira um padrão para pesquisar!");

                int SelectStart; //índice do começo da seleção
                if (cbx_caseSensitive.Checked) //se a opção de diferenciar maiúsculas de minúsculas estiver habilitada
                {
                    SelectStart = BuscaForcaBruta.forcaBruta(padrao, texto.Text, 0); // pesquisa case sensitive do inicio do texto e retornando o indice inicial do padrao
                    while (SelectStart != -1) //enquanto a pesquisa achar o padrão no texto, continuar a busca
                    {
                        SelectText(SelectStart, padrao); //selecionando no texto
                        SelectStart = BuscaForcaBruta.forcaBruta(padrao, texto.Text, SelectStart + padrao.Length); //pesquisa case sensitive começando do final da última pesquisa e retornando o índice inicial do padrão
                    }
                }
                else
                {   //caso esteja desabilitada
                    padrao = padrao.ToUpper(); //passando O texto para letras maiúsculO
                    string UpperText = texto.Text.ToUpper();
                    SelectStart = BuscaForcaBruta.forcaBruta(padrao, UpperText, 0); //pesquisa case sensitive no inicio do texto e retornando o índice inicial do padrão
                    while (SelectStart != -1) //enquanto a pesquisa achar o padrão no texto, continuar a busca
                    {
                        SelectText(SelectStart, padrao); //selecionando no texto
                        SelectStart = BuscaForcaBruta.forcaBruta(padrao, UpperText, SelectStart + padrao.Length); //pesquisa case sensitive no inicio do texto e retornando o índice inicial do padrão
                    }
                }
                if (texto.SelectedText == "" && !cbx_localizarSubstituir.Checked) //se após a pesquisa nenhum texto estiver selecionado e a opção de localizar e substituir estiver desabilitada, o padrão não está no texto
                    throw new Exception($"Não foi possível encontrar '{padrao}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Pesquisar - Força Bruta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rabinKarpToolStripMenuItem_Click(object sender, EventArgs e) //algoritmo Rabin Karp
        {
            try
            {
                texto.Focus(); 
                texto.SelectAll(); //removendo a seleção anterior
                texto.SelectionBackColor = texto.BackColor;
                texto.Select(0, 0);

                string padrao = Interaction.InputBox("Digite o padrão que deseja pesquisar", "Rabin Karp"); //input do usuário com o padrão desejado para a pesquisa
                if (padrao == "")
                    throw new Exception("Insira um padrão para pesquisar!");

                int SelectStart; //índice do começo da seleção
                if (cbx_caseSensitive.Checked) //se a opção de diferenciar maiúsculas de minúsculas estiver habilitada
                {
                    SelectStart = BuscaRabinKarp.RKSearch(padrao, texto.Text, 0); // pesquisa case sensitive do inicio do texto e retornando o indice inicial do padrao
                    while (SelectStart != -1) //enquanto a pesquisa achar o padrão no texto, continuar a busca
                    {
                        SelectText(SelectStart, padrao); //selecionando no texto
                        SelectStart = BuscaRabinKarp.RKSearch(padrao, texto.Text, SelectStart + padrao.Length); //pesquisa case sensitive começando do final da última pesquisa e retornando o índice inicial do padrão
                    }
                }
                else
                {   //caso esteja desabilitada
                    padrao = padrao.ToUpper();// passando o texto para maisculo
                    string UpperText = texto.Text.ToUpper();
                    SelectStart = BuscaRabinKarp.RKSearch(padrao, UpperText, 0); // pesquisa case sensitive do inicio do texto e retornando o indice inicial do padrao
                    while (SelectStart != -1) //enquanto a pesquisa achar o padrão no texto, continuar a busca
                    {
                        SelectText(SelectStart, padrao); //selecionando no texto
                        SelectStart = BuscaRabinKarp.RKSearch(padrao, UpperText, SelectStart + padrao.Length); //pesquisa case sensitive começando do final da última pesquisa e retornando o índice inicial do padrão
                    }
                }
                if (texto.SelectedText == "" && !cbx_localizarSubstituir.Checked) //se após a pesquisa nenhum texto estiver selecionado e a opção de localizar e substituir estiver desabilitada, o padrão não está no texto
                    throw new Exception($"Não foi possível encontrar '{padrao}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Pesquisar - Rabin Karp", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kMPToolStripMenuItem_Click(object sender, EventArgs e) //algoritmo KMP
        {
            try
            {
                texto.Focus(); 
                texto.SelectAll(); //removendo a seleção anterior
                texto.SelectionBackColor = texto.BackColor;
                texto.Select(0, 0);

                string padrao = Interaction.InputBox("Digite o padrão que deseja pesquisar", "KMP"); //input do usuário com o padrão desejado para a pesquisa
                if (padrao == "")
                    throw new Exception("Insira um padrão para pesquisar!");

                int SelectStart; //índice do começo da seleção

                if (cbx_caseSensitive.Checked) //se a opção de diferenciar maiúsculas de minúsculas estiver habilitada
                {
                    SelectStart = BuscaKMP.KMPSearch(padrao, texto.Text, 0); // pesquisa case sensitive do inicio do texto e retornando o indice inicial do padrao
                    while (SelectStart != -1) //enquanto a pesquisa achar o padrão no texto, continuar a busca
                    {
                        SelectText(SelectStart, padrao); //selecionando no texto
                        SelectStart = BuscaKMP.KMPSearch(padrao, texto.Text, SelectStart + padrao.Length); //pesquisa case sensitive começando do final da última pesquisa e retornando o índice inicial do padrão
                    }
                }
                else
                {   //caso esteja desabilitada
                    padrao = padrao.ToUpper();// passando o texto para maisculo
                    string UpperText = texto.Text.ToUpper();
                    SelectStart = BuscaKMP.KMPSearch(padrao, UpperText, 0); // pesquisa case sensitive do inicio do texto e retornando o indice inicial do padrao
                    while (SelectStart != -1) //enquanto a pesquisa achar o padrão no texto, continuar a busca
                    {
                        SelectText(SelectStart, padrao); //selecionando no texto
                        SelectStart = BuscaKMP.KMPSearch(padrao, UpperText, SelectStart + padrao.Length); //pesquisa case sensitive começando do final da última pesquisa e retornando o índice inicial do padrão
                    }
                }
                if (texto.SelectedText == "" && !cbx_localizarSubstituir.Checked) //se após a pesquisa nenhum texto estiver selecionado e a opção de localizar e substituir estiver desabilitada, o padrão não está no texto
                    throw new Exception($"Não foi possível encontrar '{padrao}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Pesquisar - KMP", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void boyerMooreToolStripMenuItem_Click(object sender, EventArgs e) //algoritmo Boyer Moore
        {
            try
            {
                texto.Focus(); 
                texto.SelectAll(); //removendo a seleção anterior
                texto.SelectionBackColor = texto.BackColor;
                texto.Select(0, 0);

                string padrao = Interaction.InputBox("Digite o padrão que deseja pesquisar", "Boyer Moore"); //input do usuário com o padrão desejado para a pesquisa
                if (padrao == "")
                    throw new Exception("Insira um padrão para pesquisar!");

                int SelectStart; //índice do começo da seleção

                if (cbx_caseSensitive.Checked) //se a opção de diferenciar maiúsculas de minúsculas estiver habilitada
                {
                    SelectStart = BuscaBoyerMoore.BMSearch(padrao, texto.Text, 0); // pesquisa case sensitive do inicio do texto e retornando o indice inicial do padrao
                    while (SelectStart != -1) //enquanto a pesquisa achar o padrão no texto, continuar a busca
                    {
                        SelectText(SelectStart, padrao); //selecionando no texto
                        SelectStart = BuscaBoyerMoore.BMSearch(padrao, texto.Text, SelectStart + padrao.Length); //pesquisa case sensitive começando do final da última pesquisa e retornando o índice inicial do padrão
                    }
                }
                else
                {   //caso esteja desabilitada
                    padrao = padrao.ToUpper();// passando o texto para maisculo
                    string UpperText = texto.Text.ToUpper();
                    SelectStart = BuscaBoyerMoore.BMSearch(padrao, UpperText, 0); // pesquisa case sensitive do inicio do texto e retornando o indice inicial do padrao
                    while (SelectStart != -1) //enquanto a pesquisa achar o padrão no texto, continuar a busca
                    {
                        SelectText(SelectStart, padrao); //selecionando no texto
                        SelectStart = BuscaBoyerMoore.BMSearch(padrao, UpperText, SelectStart + padrao.Length); //pesquisa case sensitive começando do final da última pesquisa e retornando o índice inicial do padrão
                    }
                }
                if (texto.SelectedText == "" && !cbx_localizarSubstituir.Checked) //se após a pesquisa nenhum texto estiver selecionado e a opção de localizar e substituir estiver desabilitada, o padrão não está no texto
                    throw new Exception($"Não foi possível encontrar '{padrao}'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro ao Pesquisar - Boyer Moore", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbx_localizarSubstituir_CheckedChanged(object sender, EventArgs e)
        {
            lbl_substituir.Visible = cbx_localizarSubstituir.Checked; //se a opção de localizar e substituir estiver ativa, irá aparecer o textbox para o usuário digitar a string que será inserida
            txt_substituir.Visible = cbx_localizarSubstituir.Checked;
        }
    }
}