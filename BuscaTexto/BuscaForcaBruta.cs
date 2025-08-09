using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaTexto {
    class BuscaForcaBruta {
        //Buscar a primeira ocorrência do padrão p dentro do texto t, a partir de uma posição index.
        //O caractere '?' no padrão pode combinar com qualquer caractere no texto.
        public static int forcaBruta(String p, String t, int index) {
            int i, j, aux;
            int m = p.Length;
            int n = t.Length;

            //Começa a busca no índice index, e percorre o texto até o fim.
            for (i = index; i < n; i++) {
                aux = i;
                for (j = 0; j < m && aux < n; j++) {
                    if (p[j] != '?' && t[aux] != p[j])
                        break;
                    aux++;
                }
                if (j == m)
                    return i;
            }
            return -1;
        }
    }
}
