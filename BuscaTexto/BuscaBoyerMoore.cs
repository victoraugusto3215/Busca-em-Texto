using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscaTexto {
    class BuscaBoyerMoore {
        // Buscar a primeira ocorrência de uma substring p (padrão) dentro de uma string t (texto),
        // a partir de uma posição inicial index.

        static int[] skip = new int[256]; // Vetor usado para armazenar quantos caracteres podem ser pulados ao encontrar uma diferença
        public static void initSkip(String p) {
            int j, m = p.Length;   // Inicializa o vetor skip com o valor padrão m (tamanho do padrão).
            for (j = 0; j < 256; j++)
                skip[j] = m;
            for (j = 0; j < m; j++)
                skip[p[j]] = m - j - 1;
        }

        public static int BMSearch(String p, String t, int index) {
            // Busca o padrão p dentro do texto t, começando a partir de index.
            int i, j, a, m = p.Length, n = t.Length;
            i = m - 1 + index;
            j = m - 1;
            initSkip(p);
            while (j >= 0) {
                if (i >= n)
                    return -1;
                while (t[i] != p[j]) {
                    a = skip[t[i]];
                    i += (m - j > a) ? (m - j) : a;
                    if (i >= n)
                        return -1; //Se i (posição no texto) passou do final, não encontrou → retorna -1.
                    j = m - 1;
                }
                i--;
                j--;
            }
            return i + 1;
        }
    }
}
