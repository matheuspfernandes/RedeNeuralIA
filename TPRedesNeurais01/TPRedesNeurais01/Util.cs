﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPRedesNeurais01
{
    public static class Util
    {
        public static List<Aluno> InitilizeAlunos()
        {

            List<Aluno> LDA = new List<Aluno>();

            #region [Preenchendo alunos]
            Aluno a = new Aluno(18,  2,   4,   0,   11,  11); LDA.Add(a);
            a = new Aluno(18, 2, 4, 0, 11, 11); LDA.Add(a);
            a = new Aluno(17, 2, 2, 9, 11, 11); LDA.Add(a);
            a = new Aluno(15, 2, 6, 12, 13, 12); LDA.Add(a);
            a = new Aluno(15, 3, 0, 14, 14, 14); LDA.Add(a);
            a = new Aluno(16, 2, 0, 11, 13, 13); LDA.Add(a);
            a = new Aluno(16, 2, 6, 12, 12, 13); LDA.Add(a);
            a = new Aluno(16, 2, 0, 13, 12, 13); LDA.Add(a);
            a = new Aluno(17, 2, 2, 10, 13, 13); LDA.Add(a);
            a = new Aluno(15, 2, 0, 15, 16, 17); LDA.Add(a);
            a = new Aluno(15, 2, 0, 12, 12, 13); LDA.Add(a);
            a = new Aluno(15, 2, 2, 14, 14, 14); LDA.Add(a);
            a = new Aluno(15, 3, 0, 10, 12, 13); LDA.Add(a);
            a = new Aluno(15, 1, 0, 12, 13, 12); LDA.Add(a);
            a = new Aluno(15, 2, 0, 12, 12, 13); LDA.Add(a);
            a = new Aluno(15, 3, 0, 14, 14, 15); LDA.Add(a);
            a = new Aluno(16, 1, 6, 17, 17, 17); LDA.Add(a);
            a = new Aluno(16, 3, 10, 13, 13, 14); LDA.Add(a);
            a = new Aluno(16, 2, 2, 13, 14, 14); LDA.Add(a);
            a = new Aluno(17, 1, 2, 8, 8, 7); LDA.Add(a);
            a = new Aluno(16, 1, 6, 12, 12, 12); LDA.Add(a);
            a = new Aluno(15, 2, 0, 12, 13, 14); LDA.Add(a);
            a = new Aluno(15, 1, 0, 11, 12, 12); LDA.Add(a);
            a = new Aluno(16, 2, 0, 12, 13, 14); LDA.Add(a);
            a = new Aluno(16, 2, 2, 10, 10, 10); LDA.Add(a);
            a = new Aluno(15, 3, 2, 10, 11, 10); LDA.Add(a);
            a = new Aluno(16, 1, 6, 10, 11, 12); LDA.Add(a);
            a = new Aluno(15, 1, 8, 11, 12, 12); LDA.Add(a);
            a = new Aluno(15, 1, 0, 11, 11, 11); LDA.Add(a);
            a = new Aluno(16, 2, 2, 12, 12, 13); LDA.Add(a);
            a = new Aluno(16, 2, 4, 12, 11, 12); LDA.Add(a);
            a = new Aluno(15, 2, 0, 10, 11, 11); LDA.Add(a);
            a = new Aluno(15, 2, 2, 15, 15, 15); LDA.Add(a);
            a = new Aluno(15, 2, 0, 13, 14, 15); LDA.Add(a);
            a = new Aluno(15, 2, 0, 13, 12, 12); LDA.Add(a);
            a = new Aluno(16, 1, 4, 12, 12, 12); LDA.Add(a);
            a = new Aluno(15, 1, 4, 11, 11, 11); LDA.Add(a);
            a = new Aluno(15, 3, 0, 14, 14, 14); LDA.Add(a);
            a = new Aluno(16, 3, 4, 13, 13, 13); LDA.Add(a);
            a = new Aluno(15, 3, 2, 11, 12, 12); LDA.Add(a);
            a = new Aluno(15, 1, 8, 14, 13, 12); LDA.Add(a);
            a = new Aluno(16, 2, 16, 11, 11, 10); LDA.Add(a);
            a = new Aluno(15, 1, 8, 10, 11, 11); LDA.Add(a);
            a = new Aluno(15, 2, 0, 14, 15, 15); LDA.Add(a);
            a = new Aluno(15, 1, 0, 9, 10, 10); LDA.Add(a);
            a = new Aluno(16, 2, 14, 10, 11, 11); LDA.Add(a);
            a = new Aluno(15, 2, 4, 10, 11, 11); LDA.Add(a);
            a = new Aluno(16, 2, 6, 13, 12, 13); LDA.Add(a);
            a = new Aluno(16, 4, 2, 17, 17, 17); LDA.Add(a);
            a = new Aluno(15, 2, 4, 11, 12, 13); LDA.Add(a);
            a = new Aluno(15, 2, 2, 13, 12, 12); LDA.Add(a);
            a = new Aluno(16, 2, 0, 14, 13, 13); LDA.Add(a);
            a = new Aluno(15, 2, 0, 16, 14, 16); LDA.Add(a);
            a = new Aluno(15, 1, 4, 10, 9, 9); LDA.Add(a);
            a = new Aluno(15, 1, 0, 13, 12, 12); LDA.Add(a);
            a = new Aluno(15, 1, 0, 13, 12, 13); LDA.Add(a);
            a = new Aluno(16, 2, 2, 12, 13, 12); LDA.Add(a);
            a = new Aluno(15, 2, 0, 15, 14, 15); LDA.Add(a);
            a = new Aluno(15, 2, 8, 15, 15, 16); LDA.Add(a);
            a = new Aluno(15, 2, 0, 14, 13, 14); LDA.Add(a);
            a = new Aluno(16, 2, 2, 16, 15, 16); LDA.Add(a);
            a = new Aluno(16, 2, 0, 17, 16, 16); LDA.Add(a);
            a = new Aluno(16, 1, 0, 10, 10, 16); LDA.Add(a);
            a = new Aluno(16, 2, 0, 13, 13, 10); LDA.Add(a);
            a = new Aluno(16, 3, 0, 14, 13, 13); LDA.Add(a);
            a = new Aluno(15, 2, 0, 13, 12, 12); LDA.Add(a);
            a = new Aluno(16, 2, 2, 16, 15, 16); LDA.Add(a);
            a = new Aluno(15, 4, 0, 11, 12, 12); LDA.Add(a);
            a = new Aluno(16, 4, 0, 10, 9, 10); LDA.Add(a);
            a = new Aluno(15, 2, 0, 11, 10, 11); LDA.Add(a);
            a = new Aluno(15, 4, 6, 15, 15, 15); LDA.Add(a);
            a = new Aluno(16, 4, 2, 13, 11, 11); LDA.Add(a);
            a = new Aluno(15, 4, 0, 11, 9, 10); LDA.Add(a);
            a = new Aluno(15, 2, 2, 13, 11, 11); LDA.Add(a);
            a = new Aluno(16, 1, 0, 13, 13, 14); LDA.Add(a);
            a = new Aluno(16, 2, 4, 11, 11, 11); LDA.Add(a);
            a = new Aluno(15, 2, 0, 11, 11, 11); LDA.Add(a);
            a = new Aluno(15, 4, 0, 12, 11, 11); LDA.Add(a);
            a = new Aluno(16, 4, 1, 13, 13, 13); LDA.Add(a);
            a = new Aluno(17, 1, 0, 9, 9, 10); LDA.Add(a);
            a = new Aluno(16, 2, 14, 12, 11, 11); LDA.Add(a);
            a = new Aluno(15, 1, 0, 11, 11, 12); LDA.Add(a);
            a = new Aluno(15, 3, 2, 10, 9, 9); LDA.Add(a);
            a = new Aluno(15, 2, 4, 12, 11, 11); LDA.Add(a);
            a = new Aluno(15, 2, 2, 13, 12, 13); LDA.Add(a);
            a = new Aluno(15, 2, 2, 13, 12, 12); LDA.Add(a);
            a = new Aluno(15, 2, 4, 12, 11, 12); LDA.Add(a);
            a = new Aluno(16, 2, 6, 13, 11, 11); LDA.Add(a);
            a = new Aluno(15, 3, 4, 15, 15, 15); LDA.Add(a);
            a = new Aluno(16, 2, 6, 12, 10, 11); LDA.Add(a);
            a = new Aluno(16, 2, 6, 9, 9, 10); LDA.Add(a);
            a = new Aluno(16, 3, 2, 9, 11, 11); LDA.Add(a);
            a = new Aluno(15, 1, 6, 14, 13, 13); LDA.Add(a);
            a = new Aluno(16, 2, 0, 12, 13, 12); LDA.Add(a);
            a = new Aluno(16, 2, 2, 13, 14, 14); LDA.Add(a);
            a = new Aluno(15, 4, 2, 11, 12, 12); LDA.Add(a);
            a = new Aluno(15, 4, 4, 13, 13, 13); LDA.Add(a);
            a = new Aluno(16, 1, 6, 9, 11, 11); LDA.Add(a);
            a = new Aluno(16, 2, 0, 13, 12, 12); LDA.Add(a);
            a = new Aluno(16, 1, 4, 12, 13, 13); LDA.Add(a);
            a = new Aluno(16, 3, 2, 12, 13, 13); LDA.Add(a);
            a = new Aluno(16, 1, 12, 9, 9, 8); LDA.Add(a);
            a = new Aluno(16, 3, 0, 16, 16, 16); LDA.Add(a);
            a = new Aluno(15, 1, 2, 12, 13, 12); LDA.Add(a);
            a = new Aluno(15, 2, 16, 11, 10, 10); LDA.Add(a);
            a = new Aluno(15, 2, 0, 16, 16, 16); LDA.Add(a);
            a = new Aluno(15, 4, 10, 10, 10, 10); LDA.Add(a);
            a = new Aluno(15, 4, 4, 10, 10, 10); LDA.Add(a);
            a = new Aluno(16, 3, 4, 13, 14, 14); LDA.Add(a);
            a = new Aluno(15, 4, 8, 12, 10, 11); LDA.Add(a);
            a = new Aluno(16, 3, 2, 15, 15, 14); LDA.Add(a);
            a = new Aluno(15, 1, 4, 13, 14, 14); LDA.Add(a);
            a = new Aluno(16, 3, 4, 11, 11, 11); LDA.Add(a);
            a = new Aluno(16, 2, 12, 8, 10, 10); LDA.Add(a);
            a = new Aluno(15, 1, 10, 18, 17, 18); LDA.Add(a);
            a = new Aluno(15, 2, 4, 10, 9, 10); LDA.Add(a);
            a = new Aluno(16, 2, 6, 16, 14, 14); LDA.Add(a);
            a = new Aluno(15, 2, 4, 16, 15, 16); LDA.Add(a);
            a = new Aluno(16, 1, 6, 14, 14, 15); LDA.Add(a);
            a = new Aluno(17, 2, 14, 12, 11, 11); LDA.Add(a);
            a = new Aluno(15, 1, 2, 14, 13, 14); LDA.Add(a);
            a = new Aluno(15, 2, 0, 14, 14, 14); LDA.Add(a);
            a = new Aluno(15, 4, 6, 14, 13, 13); LDA.Add(a);
            a = new Aluno(16, 2, 2, 14, 12, 13); LDA.Add(a);
            a = new Aluno(16, 1, 4, 12, 13, 13); LDA.Add(a);
            a = new Aluno(16, 2, 0, 12, 11, 11); LDA.Add(a);
            a = new Aluno(15, 1, 2, 9, 9, 9); LDA.Add(a);
            a = new Aluno(15, 2, 0, 10, 11, 11); LDA.Add(a);
            a = new Aluno(19, 2, 0, 9, 10, 11); LDA.Add(a);
            a = new Aluno(16, 1, 8, 14, 14, 15); LDA.Add(a);
            a = new Aluno(16, 3, 4, 13, 12, 13); LDA.Add(a);
            a = new Aluno(15, 3, 0, 10, 11, 12); LDA.Add(a);
            a = new Aluno(18, 2, 10, 10, 9, 8); LDA.Add(a);
            a = new Aluno(17, 1, 8, 11, 10, 11); LDA.Add(a);
            a = new Aluno(15, 1, 6, 11, 12, 13); LDA.Add(a);
            a = new Aluno(17, 1, 2, 13, 12, 12); LDA.Add(a);
            a = new Aluno(16, 1, 12, 15, 13, 14); LDA.Add(a);
            a = new Aluno(16, 1, 4, 9, 9, 11); LDA.Add(a);
            a = new Aluno(16, 1, 12, 13, 11, 11); LDA.Add(a);
            a = new Aluno(15, 2, 2, 12, 11, 11); LDA.Add(a);
            a = new Aluno(15, 3, 4, 13, 14, 15); LDA.Add(a);
            a = new Aluno(17, 2, 2, 10, 9, 10); LDA.Add(a);
            a = new Aluno(16, 2, 0, 14, 13, 13); LDA.Add(a);
            a = new Aluno(18, 1, 2, 11, 11, 12); LDA.Add(a);
            a = new Aluno(18, 3, 10, 12, 11, 11); LDA.Add(a);
            a = new Aluno(16, 1, 8, 12, 11, 11); LDA.Add(a);
            a = new Aluno(16, 1, 4, 9, 9, 10); LDA.Add(a);
            a = new Aluno(16, 2, 0, 10, 10, 10); LDA.Add(a);
            a = new Aluno(15, 1, 6, 13, 14, 14); LDA.Add(a);
            a = new Aluno(15, 1, 2, 8, 9, 9); LDA.Add(a);
            a = new Aluno(15, 4, 6, 9, 11, 11); LDA.Add(a);
            a = new Aluno(15, 2, 24, 9, 8, 9); LDA.Add(a);
            a = new Aluno(16, 3, 0, 15, 13, 13); LDA.Add(a);
            a = new Aluno(16, 1, 4, 12, 11, 11); LDA.Add(a);
            a = new Aluno(15, 3, 2, 13, 13, 13); LDA.Add(a);
            a = new Aluno(16, 1, 4, 10, 11, 11); LDA.Add(a);
            a = new Aluno(17, 1, 22, 9, 7, 6); LDA.Add(a);
            a = new Aluno(15, 2, 0, 12, 12, 12); LDA.Add(a);
            a = new Aluno(15, 1, 0, 11, 10, 10); LDA.Add(a);
            a = new Aluno(15, 2, 2, 11, 11, 11); LDA.Add(a);
            a = new Aluno(15, 2, 6, 13, 12, 13); LDA.Add(a);
            a = new Aluno(15, 2, 6, 11, 11, 11); LDA.Add(a);
            a = new Aluno(16, 1, 16, 9, 9, 8); LDA.Add(a);
            a = new Aluno(15, 1, 0, 12, 11, 11); LDA.Add(a);
            a = new Aluno(18, 1, 0, 11, 9, 0); LDA.Add(a);
            a = new Aluno(16, 1, 6, 9, 10, 10); LDA.Add(a);
            a = new Aluno(15, 3, 2, 13, 13, 13); LDA.Add(a);
            a = new Aluno(19, 1, 6, 11, 9, 11); LDA.Add(a);
            a = new Aluno(17, 1, 0, 13, 13, 13); LDA.Add(a);
            a = new Aluno(15, 2, 0, 7, 8, 8); LDA.Add(a);
            a = new Aluno(17, 1, 14, 9, 8, 10); LDA.Add(a);
            a = new Aluno(18, 1, 6, 11, 10, 11); LDA.Add(a);
            a = new Aluno(16, 1, 4, 12, 10, 11); LDA.Add(a);
            a = new Aluno(16, 2, 0, 10, 10, 1); LDA.Add(a);
            a = new Aluno(16, 1, 0, 9, 8, 10); LDA.Add(a);
            a = new Aluno(17, 1, 8, 8, 8, 9); LDA.Add(a);
            a = new Aluno(17, 2, 4, 7, 6, 8); LDA.Add(a);
            a = new Aluno(15, 1, 2, 8, 9, 10); LDA.Add(a);
            a = new Aluno(16, 1, 2, 9, 8, 8); LDA.Add(a);
            a = new Aluno(17, 2, 0, 8, 8, 8); LDA.Add(a);
            a = new Aluno(17, 1, 10, 8, 7, 8); LDA.Add(a);
            a = new Aluno(16, 2, 0, 9, 10, 11); LDA.Add(a);
            a = new Aluno(16, 2, 0, 17, 17, 18); LDA.Add(a);
            a = new Aluno(16, 2, 0, 12, 12, 13); LDA.Add(a);
            a = new Aluno(16, 2, 0, 16, 16, 17); LDA.Add(a);
            a = new Aluno(16, 1, 4, 9, 9, 10); LDA.Add(a);
            a = new Aluno(16, 2, 0, 16, 17, 18); LDA.Add(a);
            a = new Aluno(17, 2, 0, 11, 9, 10); LDA.Add(a);
            a = new Aluno(16, 2, 0, 14, 13, 13); LDA.Add(a);
            a = new Aluno(16, 2, 0, 14, 14, 15); LDA.Add(a);
            a = new Aluno(17, 2, 0, 10, 11, 11); LDA.Add(a);
            a = new Aluno(16, 2, 0, 13, 12, 14); LDA.Add(a);
            a = new Aluno(17, 2, 4, 11, 9, 10); LDA.Add(a);
            a = new Aluno(16, 1, 8, 10, 9, 11); LDA.Add(a);
            a = new Aluno(17, 2, 4, 11, 11, 13); LDA.Add(a);
            a = new Aluno(16, 2, 4, 11, 10, 11); LDA.Add(a);
            a = new Aluno(16, 2, 0, 11, 12, 13); LDA.Add(a);
            a = new Aluno(17, 2, 0, 17, 18, 17); LDA.Add(a);
            a = new Aluno(17, 2, 32, 14, 13, 14); LDA.Add(a);
            a = new Aluno(16, 2, 8, 14, 15, 16); LDA.Add(a);
            a = new Aluno(17, 2, 6, 11, 13, 14); LDA.Add(a);
            a = new Aluno(16, 1, 0, 10, 9, 11); LDA.Add(a);
            a = new Aluno(16, 2, 0, 13, 14, 16); LDA.Add(a);
            a = new Aluno(17, 2, 10, 12, 13, 14); LDA.Add(a);
            a = new Aluno(17, 2, 6, 9, 9, 10); LDA.Add(a);
            a = new Aluno(16, 2, 6, 12, 12, 13); LDA.Add(a);
            a = new Aluno(17, 2, 0, 12, 11, 12); LDA.Add(a);
            a = new Aluno(17, 2, 16, 10, 11, 12); LDA.Add(a);
            a = new Aluno(16, 1, 0, 11, 10, 10); LDA.Add(a);
            a = new Aluno(16, 1, 0, 13, 12, 12); LDA.Add(a);
            a = new Aluno(17, 2, 8, 14, 15, 16); LDA.Add(a);
            a = new Aluno(17, 1, 4, 13, 13, 14); LDA.Add(a);
            a = new Aluno(16, 1, 16, 10, 11, 12); LDA.Add(a);
            a = new Aluno(17, 1, 30, 14, 15, 16); LDA.Add(a);
            a = new Aluno(16, 2, 0, 11, 10, 11); LDA.Add(a);
            a = new Aluno(16, 2, 2, 14, 14, 15); LDA.Add(a);
            a = new Aluno(16, 2, 4, 11, 12, 12); LDA.Add(a);
            a = new Aluno(17, 2, 0, 14, 15, 15); LDA.Add(a);
            a = new Aluno(17, 1, 21, 13, 13, 13); LDA.Add(a);
            a = new Aluno(16, 4, 6, 13, 13, 13); LDA.Add(a);
            a = new Aluno(17, 3, 14, 8, 9, 8); LDA.Add(a);
            a = new Aluno(16, 2, 2, 11, 11, 12); LDA.Add(a);
            a = new Aluno(16, 2, 4, 14, 15, 15); LDA.Add(a);
            a = new Aluno(16, 1, 2, 12, 13, 13); LDA.Add(a);
            a = new Aluno(17, 3, 0, 11, 12, 12); LDA.Add(a);
            a = new Aluno(19, 4, 4, 12, 12, 12); LDA.Add(a);
            a = new Aluno(17, 2, 15, 13, 12, 12); LDA.Add(a);
            a = new Aluno(16, 2, 0, 13, 13, 13); LDA.Add(a);
            a = new Aluno(18, 2, 10, 12, 11, 11); LDA.Add(a);
            a = new Aluno(17, 1, 6, 12, 11, 11); LDA.Add(a);
            a = new Aluno(17, 2, 2, 14, 16, 15); LDA.Add(a);
            a = new Aluno(17, 2, 16, 11, 9, 10); LDA.Add(a);
            a = new Aluno(18, 2, 10, 10, 10, 10); LDA.Add(a);
            a = new Aluno(17, 1, 4, 12, 13, 13); LDA.Add(a);
            a = new Aluno(17, 3, 0, 12, 12, 13); LDA.Add(a);
            a = new Aluno(17, 2, 0, 11, 10, 11); LDA.Add(a);
            a = new Aluno(17, 3, 12, 12, 12, 12); LDA.Add(a);
            a = new Aluno(16, 2, 0, 13, 13, 14); LDA.Add(a);
            a = new Aluno(18, 2, 9, 10, 9, 10); LDA.Add(a);
            a = new Aluno(16, 3, 4, 15, 16, 16); LDA.Add(a);
            a = new Aluno(18, 2, 4, 8, 8, 8); LDA.Add(a);
            a = new Aluno(17, 2, 2, 17, 18, 17); LDA.Add(a);
            a = new Aluno(17, 2, 0, 10, 11, 11); LDA.Add(a);
            a = new Aluno(18, 2, 2, 9, 10, 11); LDA.Add(a);
            a = new Aluno(17, 3, 0, 15, 15, 16); LDA.Add(a);
            a = new Aluno(17, 2, 0, 14, 12, 12); LDA.Add(a);
            a = new Aluno(17, 2, 0, 12, 13, 13); LDA.Add(a);
            a = new Aluno(17, 2, 0, 13, 13, 13); LDA.Add(a);
            a = new Aluno(16, 2, 0, 13, 13, 14); LDA.Add(a);
            a = new Aluno(16, 2, 2, 9, 9, 9); LDA.Add(a);
            a = new Aluno(16, 3, 0, 12, 12, 12); LDA.Add(a);
            a = new Aluno(17, 2, 0, 16, 16, 16); LDA.Add(a);
            a = new Aluno(16, 1, 4, 9, 10, 10); LDA.Add(a);
            a = new Aluno(16, 2, 0, 14, 13, 13); LDA.Add(a);
            a = new Aluno(18, 2, 18, 10, 10, 10); LDA.Add(a);
            a = new Aluno(18, 2, 16, 9, 8, 10); LDA.Add(a);
            a = new Aluno(18, 1, 14, 8, 7, 7); LDA.Add(a);
            a = new Aluno(18, 1, 26, 7, 8, 8); LDA.Add(a);
            a = new Aluno(17, 1, 6, 10, 8, 9); LDA.Add(a);
            a = new Aluno(17, 2, 4, 14, 14, 15); LDA.Add(a);
            a = new Aluno(17, 3, 10, 11, 10, 10); LDA.Add(a);
            a = new Aluno(16, 1, 4, 12, 11, 11); LDA.Add(a);
            a = new Aluno(17, 2, 2, 13, 13, 13); LDA.Add(a);
            a = new Aluno(17, 1, 14, 9, 9, 8); LDA.Add(a);
            a = new Aluno(18, 2, 16, 8, 7, 8); LDA.Add(a);
            a = new Aluno(17, 1, 8, 11, 9, 10); LDA.Add(a);
            a = new Aluno(17, 3, 4, 15, 14, 15); LDA.Add(a);
            a = new Aluno(17, 2, 4, 15, 14, 14); LDA.Add(a);
            a = new Aluno(17, 2, 8, 15, 15, 15); LDA.Add(a);
            a = new Aluno(17, 2, 0, 12, 12, 12); LDA.Add(a);
            a = new Aluno(16, 1, 7, 14, 14, 15); LDA.Add(a);
            a = new Aluno(16, 1, 4, 14, 15, 15); LDA.Add(a);
            a = new Aluno(17, 2, 2, 11, 11, 12); LDA.Add(a);
            a = new Aluno(17, 3, 2, 13, 14, 15); LDA.Add(a);
            a = new Aluno(17, 3, 10, 11, 11, 11); LDA.Add(a);
            a = new Aluno(17, 2, 10, 10, 9, 10); LDA.Add(a);
            a = new Aluno(18, 3, 10, 12, 10, 11); LDA.Add(a);
            a = new Aluno(16, 1, 7, 15, 16, 16); LDA.Add(a);
            a = new Aluno(17, 2, 4, 11, 10, 11); LDA.Add(a);
            a = new Aluno(17, 1, 2, 9, 12, 13); LDA.Add(a);
            a = new Aluno(22, 1, 12, 7, 8, 5); LDA.Add(a);
            a = new Aluno(18, 2, 8, 10, 9, 10); LDA.Add(a);
            a = new Aluno(16, 1, 0, 11, 12, 11); LDA.Add(a);
            a = new Aluno(18, 1, 8, 7, 8, 7); LDA.Add(a);
            a = new Aluno(16, 2, 4, 9, 11, 10); LDA.Add(a);
            a = new Aluno(18, 1, 4, 7, 8, 6); LDA.Add(a);
            a = new Aluno(16, 1, 2, 14, 13, 12); LDA.Add(a);
            a = new Aluno(17, 1, 0, 12, 12, 13); LDA.Add(a);
            a = new Aluno(17, 1, 0, 9, 10, 10); LDA.Add(a);
            a = new Aluno(18, 2, 2, 12, 12, 13); LDA.Add(a);
            a = new Aluno(17, 4, 2, 14, 15, 17); LDA.Add(a);
            a = new Aluno(19, 2, 0, 10, 10, 11); LDA.Add(a);
            a = new Aluno(18, 2, 4, 11, 10, 11); LDA.Add(a);
            a = new Aluno(17, 3, 2, 11, 12, 14); LDA.Add(a);
            a = new Aluno(18, 3, 4, 11, 12, 14); LDA.Add(a);
            a = new Aluno(18, 2, 4, 11, 11, 13); LDA.Add(a);
            a = new Aluno(19, 2, 4, 11, 13, 14); LDA.Add(a);
            a = new Aluno(18, 2, 2, 16, 16, 16); LDA.Add(a);
            a = new Aluno(17, 1, 0, 9, 10, 10); LDA.Add(a);
            a = new Aluno(17, 4, 2, 10, 11, 12); LDA.Add(a);
            a = new Aluno(20, 2, 8, 10, 12, 12); LDA.Add(a);
            a = new Aluno(18, 2, 2, 15, 15, 15); LDA.Add(a);
            a = new Aluno(18, 2, 2, 10, 10, 11); LDA.Add(a);
            a = new Aluno(18, 3, 2, 10, 11, 12); LDA.Add(a);
            a = new Aluno(17, 3, 2, 15, 12, 13); LDA.Add(a);
            a = new Aluno(18, 3, 0, 11, 12, 13); LDA.Add(a);
            a = new Aluno(17, 1, 8, 8, 8, 9); LDA.Add(a);
            a = new Aluno(18, 2, 6, 15, 16, 16); LDA.Add(a);
            a = new Aluno(17, 2, 0, 11, 11, 14); LDA.Add(a);
            a = new Aluno(18, 2, 8, 10, 11, 12); LDA.Add(a);
            a = new Aluno(18, 2, 4, 10, 12, 14); LDA.Add(a);
            a = new Aluno(18, 2, 12, 8, 9, 10); LDA.Add(a);
            a = new Aluno(19, 2, 16, 11, 12, 12); LDA.Add(a);
            a = new Aluno(18, 4, 10, 16, 16, 16); LDA.Add(a);
            a = new Aluno(18, 2, 2, 13, 13, 13); LDA.Add(a);
            a = new Aluno(17, 2, 2, 16, 17, 18); LDA.Add(a);
            a = new Aluno(18, 2, 8, 14, 14, 15); LDA.Add(a);
            a = new Aluno(17, 2, 6, 15, 16, 16); LDA.Add(a);
            a = new Aluno(17, 2, 6, 12, 12, 12); LDA.Add(a);
            a = new Aluno(18, 2, 15, 12, 9, 10); LDA.Add(a);
            a = new Aluno(18, 1, 6, 11, 12, 12); LDA.Add(a);
            a = new Aluno(18, 2, 2, 14, 12, 13); LDA.Add(a);
            a = new Aluno(17, 3, 8, 13, 15, 15); LDA.Add(a);
            a = new Aluno(19, 2, 0, 9, 8, 10); LDA.Add(a);
            a = new Aluno(18, 1, 0, 10, 10, 10); LDA.Add(a);
            a = new Aluno(18, 1, 10, 10, 10, 11); LDA.Add(a);
            a = new Aluno(17, 1, 22, 11, 11, 10); LDA.Add(a);
            a = new Aluno(17, 1, 18, 13, 13, 13); LDA.Add(a);
            a = new Aluno(18, 4, 2, 17, 17, 18); LDA.Add(a);
            a = new Aluno(18, 2, 0, 12, 13, 13); LDA.Add(a);
            a = new Aluno(17, 2, 12, 12, 12, 14); LDA.Add(a);
            a = new Aluno(18, 2, 10, 12, 13, 14); LDA.Add(a);
            a = new Aluno(17, 2, 0, 12, 12, 12); LDA.Add(a);
            a = new Aluno(18, 3, 0, 18, 18, 18); LDA.Add(a);
            a = new Aluno(17, 3, 0, 13, 13, 14); LDA.Add(a);
            a = new Aluno(18, 3, 0, 14, 15, 15); LDA.Add(a);
            a = new Aluno(18, 2, 0, 17, 17, 17); LDA.Add(a);
            a = new Aluno(18, 2, 2, 15, 16, 16); LDA.Add(a);
            a = new Aluno(17, 3, 0, 17, 18, 18); LDA.Add(a);
            a = new Aluno(17, 4, 0, 18, 19, 19); LDA.Add(a);
            a = new Aluno(18, 3, 0, 14, 15, 15); LDA.Add(a);
            a = new Aluno(17, 1, 0, 14, 15, 15); LDA.Add(a);
            a = new Aluno(19, 2, 2, 14, 13, 13); LDA.Add(a);
            a = new Aluno(18, 2, 0, 13, 14, 14); LDA.Add(a);
            a = new Aluno(18, 4, 0, 16, 17, 17); LDA.Add(a);
            a = new Aluno(18, 1, 0, 18, 18, 17); LDA.Add(a);
            a = new Aluno(18, 2, 0, 14, 15, 15); LDA.Add(a);
            a = new Aluno(17, 1, 0, 12, 13, 13); LDA.Add(a);
            a = new Aluno(17, 3, 0, 7, 7, 8); LDA.Add(a);
            a = new Aluno(17, 3, 0, 16, 16, 16); LDA.Add(a);
            a = new Aluno(17, 4, 0, 18, 18, 18); LDA.Add(a);
            a = new Aluno(19, 3, 0, 9, 10, 11); LDA.Add(a);
            a = new Aluno(20, 1, 0, 14, 15, 15); LDA.Add(a);
            a = new Aluno(19, 2, 0, 10, 10, 11); LDA.Add(a);
            a = new Aluno(18, 2, 2, 10, 10, 11); LDA.Add(a);
            a = new Aluno(18, 2, 2, 12, 12, 15); LDA.Add(a);
            a = new Aluno(17, 2, 2, 11, 12, 14); LDA.Add(a);
            a = new Aluno(17, 1, 2, 15, 16, 17); LDA.Add(a);
            a = new Aluno(18, 3, 2, 14, 15, 17); LDA.Add(a);
            a = new Aluno(18, 1, 8, 12, 12, 15); LDA.Add(a);
            a = new Aluno(17, 3, 2, 15, 15, 17); LDA.Add(a);
            a = new Aluno(18, 2, 8, 11, 12, 14); LDA.Add(a);
            a = new Aluno(19, 2, 9, 11, 10, 10); LDA.Add(a);
            a = new Aluno(18, 2, 0, 12, 11, 13); LDA.Add(a);
            a = new Aluno(18, 1, 4, 11, 12, 14); LDA.Add(a);
            a = new Aluno(17, 1, 2, 14, 15, 17); LDA.Add(a);
            a = new Aluno(17, 2, 14, 15, 14, 17); LDA.Add(a);
            a = new Aluno(17, 2, 0, 12, 12, 13); LDA.Add(a);
            a = new Aluno(17, 2, 2, 11, 12, 14); LDA.Add(a);
            a = new Aluno(18, 1, 2, 8, 9, 11); LDA.Add(a);
            a = new Aluno(19, 3, 12, 10, 10, 11); LDA.Add(a);
            a = new Aluno(19, 2, 2, 8, 8, 9); LDA.Add(a);
            a = new Aluno(18, 1, 2, 10, 10, 10); LDA.Add(a);
            a = new Aluno(17, 2, 4, 14, 13, 13); LDA.Add(a);
            a = new Aluno(17, 3, 0, 11, 11, 10); LDA.Add(a);
            a = new Aluno(17, 3, 0, 17, 18, 17); LDA.Add(a);
            a = new Aluno(17, 3, 0, 14, 14, 15); LDA.Add(a);
            a = new Aluno(18, 3, 0, 14, 14, 14); LDA.Add(a);
            a = new Aluno(18, 3, 0, 13, 14, 13); LDA.Add(a);
            a = new Aluno(17, 1, 0, 17, 18, 17); LDA.Add(a);
            a = new Aluno(17, 1, 2, 11, 10, 10); LDA.Add(a);
            a = new Aluno(17, 3, 0, 13, 12, 13); LDA.Add(a);
            a = new Aluno(17, 3, 4, 15, 14, 15); LDA.Add(a);
            a = new Aluno(17, 1, 2, 11, 12, 11); LDA.Add(a);
            a = new Aluno(18, 4, 0, 11, 11, 12); LDA.Add(a);
            a = new Aluno(19, 1, 0, 11, 10, 10); LDA.Add(a);
            a = new Aluno(18, 2, 2, 10, 9, 10); LDA.Add(a);
            a = new Aluno(17, 3, 0, 15, 15, 15); LDA.Add(a);
            a = new Aluno(18, 1, 6, 15, 14, 15); LDA.Add(a);
            a = new Aluno(18, 2, 8, 10, 11, 12); LDA.Add(a);
            a = new Aluno(18, 2, 0, 10, 9, 12); LDA.Add(a);
            a = new Aluno(18, 4, 6, 14, 13, 14); LDA.Add(a);
            a = new Aluno(17, 3, 8, 11, 13, 14); LDA.Add(a);
            a = new Aluno(17, 2, 0, 12, 13, 15); LDA.Add(a);
            a = new Aluno(18, 4, 4, 14, 14, 15); LDA.Add(a);
            a = new Aluno(17, 2, 0, 14, 14, 16); LDA.Add(a);
            a = new Aluno(18, 2, 0, 12, 12, 13); LDA.Add(a);
            a = new Aluno(18, 2, 6, 16, 16, 17); LDA.Add(a);
            a = new Aluno(17, 2, 18, 10, 12, 14); LDA.Add(a);
            a = new Aluno(18, 3, 0, 11, 12, 14); LDA.Add(a);
            a = new Aluno(18, 3, 4, 14, 16, 17); LDA.Add(a);
            a = new Aluno(18, 3, 4, 15, 14, 17); LDA.Add(a);
            a = new Aluno(18, 3, 0, 14, 13, 14); LDA.Add(a);
            a = new Aluno(17, 3, 0, 11, 12, 13); LDA.Add(a);
            a = new Aluno(17, 2, 10, 12, 15, 15); LDA.Add(a);
            a = new Aluno(17, 2, 4, 12, 16, 16); LDA.Add(a);
            a = new Aluno(19, 1, 16, 10, 11, 11); LDA.Add(a);
            a = new Aluno(17, 1, 6, 10, 13, 13); LDA.Add(a);
            a = new Aluno(21, 3, 0, 9, 12, 12); LDA.Add(a);
            a = new Aluno(18, 2, 11, 9, 11, 12); LDA.Add(a);
            a = new Aluno(18, 2, 9, 13, 14, 15); LDA.Add(a);
            a = new Aluno(17, 2, 0, 13, 17, 17); LDA.Add(a);
            a = new Aluno(17, 3, 2, 12, 15, 15); LDA.Add(a);
            a = new Aluno(18, 2, 0, 14, 17, 17); LDA.Add(a);
            a = new Aluno(21, 2, 21, 9, 10, 10); LDA.Add(a);
            a = new Aluno(20, 3, 8, 11, 15, 15); LDA.Add(a);
            a = new Aluno(19, 1, 5, 9, 10, 11); LDA.Add(a);
            a = new Aluno(17, 2, 10, 16, 18, 18); LDA.Add(a);
            a = new Aluno(18, 3, 5, 14, 17, 17); LDA.Add(a);
            a = new Aluno(18, 1, 13, 13, 14, 14); LDA.Add(a);
            a = new Aluno(19, 1, 10, 7, 11, 11); LDA.Add(a);
            a = new Aluno(18, 2, 10, 14, 17, 17); LDA.Add(a);
            a = new Aluno(20, 1, 5, 8, 10, 10); LDA.Add(a);
            a = new Aluno(18, 2, 4, 10, 13, 13); LDA.Add(a);
            a = new Aluno(16, 1, 11, 10, 11, 11); LDA.Add(a);
            a = new Aluno(16, 2, 0, 12, 12, 12); LDA.Add(a);
            a = new Aluno(15, 1, 6, 10, 10, 10); LDA.Add(a);
            a = new Aluno(15, 1, 4, 10, 10, 11); LDA.Add(a);
            a = new Aluno(16, 2, 0, 16, 17, 17); LDA.Add(a);
            a = new Aluno(15, 1, 0, 6, 8, 9); LDA.Add(a);
            a = new Aluno(16, 2, 5, 10, 11, 11); LDA.Add(a);
            a = new Aluno(16, 3, 0, 10, 11, 11); LDA.Add(a);
            a = new Aluno(17, 2, 0, 10, 10, 10); LDA.Add(a);
            a = new Aluno(17, 1, 0, 6, 6, 7); LDA.Add(a);
            a = new Aluno(15, 1, 0, 13, 14, 14); LDA.Add(a);
            a = new Aluno(16, 4, 4, 10, 9, 11); LDA.Add(a);
            a = new Aluno(15, 2, 0, 10, 10, 10); LDA.Add(a);
            a = new Aluno(15, 1, 4, 6, 7, 8); LDA.Add(a);
            a = new Aluno(16, 1, 0, 12, 11, 12); LDA.Add(a);
            a = new Aluno(17, 1, 2, 10, 11, 12); LDA.Add(a);
            a = new Aluno(15, 1, 0, 14, 16, 16); LDA.Add(a);
            a = new Aluno(16, 2, 0, 7, 0, 0); LDA.Add(a);
            a = new Aluno(17, 2, 4, 8, 9, 9); LDA.Add(a);
            a = new Aluno(15, 2, 0, 12, 13, 14); LDA.Add(a);
            a = new Aluno(15, 2, 7, 7, 9, 8); LDA.Add(a);
            a = new Aluno(16, 2, 4, 9, 10, 11); LDA.Add(a);
            a = new Aluno(15, 2, 8, 7, 9, 9); LDA.Add(a);
            a = new Aluno(15, 2, 0, 11, 11, 11); LDA.Add(a);
            a = new Aluno(17, 1, 8, 8, 10, 9); LDA.Add(a);
            a = new Aluno(16, 3, 6, 16, 16, 17); LDA.Add(a);
            a = new Aluno(15, 1, 3, 11, 13, 13); LDA.Add(a);
            a = new Aluno(16, 2, 2, 15, 15, 15); LDA.Add(a);
            a = new Aluno(16, 2, 0, 10, 11, 11); LDA.Add(a);
            a = new Aluno(16, 2, 4, 9, 10, 11); LDA.Add(a);
            a = new Aluno(16, 3, 0, 10, 8, 8); LDA.Add(a);
            a = new Aluno(16, 3, 3, 9, 8, 8); LDA.Add(a);
            a = new Aluno(15, 2, 0, 9, 10, 9); LDA.Add(a);
            a = new Aluno(16, 2, 0, 13, 14, 15); LDA.Add(a);
            a = new Aluno(17, 1, 4, 10, 11, 11); LDA.Add(a);
            a = new Aluno(16, 4, 0, 13, 10, 13); LDA.Add(a);
            a = new Aluno(16, 3, 2, 10, 9, 10); LDA.Add(a);
            a = new Aluno(15, 2, 1, 11, 10, 11); LDA.Add(a);
            a = new Aluno(16, 1, 0, 13, 12, 14); LDA.Add(a);
            a = new Aluno(15, 2, 0, 13, 14, 14); LDA.Add(a);
            a = new Aluno(15, 3, 2, 14, 11, 12); LDA.Add(a);
            a = new Aluno(16, 1, 6, 11, 11, 11); LDA.Add(a);
            a = new Aluno(18, 2, 9, 9, 8, 8); LDA.Add(a);
            a = new Aluno(15, 1, 0, 10, 9, 11); LDA.Add(a);
            a = new Aluno(16, 2, 1, 14, 13, 14); LDA.Add(a);
            a = new Aluno(15, 1, 1, 13, 12, 13); LDA.Add(a);
            a = new Aluno(16, 2, 0, 13, 12, 13); LDA.Add(a);
            a = new Aluno(15, 2, 4, 13, 12, 12); LDA.Add(a);
            a = new Aluno(16, 2, 2, 12, 11, 12); LDA.Add(a);
            a = new Aluno(16, 1, 0, 14, 14, 16); LDA.Add(a);
            a = new Aluno(16, 1, 4, 10, 8, 10); LDA.Add(a);
            a = new Aluno(15, 1, 2, 10, 11, 11); LDA.Add(a);
            a = new Aluno(15, 3, 0, 12, 13, 14); LDA.Add(a);
            a = new Aluno(16, 1, 2, 10, 8, 8); LDA.Add(a);
            a = new Aluno(15, 1, 11, 12, 10, 11); LDA.Add(a);
            a = new Aluno(16, 2, 0, 7, 7, 8); LDA.Add(a);
            a = new Aluno(17, 1, 4, 9, 9, 10); LDA.Add(a);
            a = new Aluno(19, 1, 0, 9, 9, 10); LDA.Add(a);
            a = new Aluno(17, 1, 2, 9, 10, 11); LDA.Add(a);
            a = new Aluno(15, 1, 0, 9, 10, 9); LDA.Add(a);
            a = new Aluno(16, 2, 1, 9, 10, 11); LDA.Add(a);
            a = new Aluno(16, 1, 6, 7, 7, 8); LDA.Add(a);
            a = new Aluno(17, 2, 0, 11, 10, 11); LDA.Add(a);
            a = new Aluno(16, 1, 1, 9, 10, 10); LDA.Add(a);
            a = new Aluno(18, 3, 6, 7, 9, 10); LDA.Add(a);
            a = new Aluno(19, 3, 6, 7, 9, 9); LDA.Add(a);
            a = new Aluno(18, 1, 0, 8, 9, 10); LDA.Add(a);
            a = new Aluno(18, 1, 4, 9, 11, 10); LDA.Add(a);
            a = new Aluno(19, 2, 12, 7, 8, 9); LDA.Add(a);
            a = new Aluno(16, 2, 2, 8, 10, 10); LDA.Add(a);
            a = new Aluno(17, 1, 5, 9, 9, 10); LDA.Add(a);
            a = new Aluno(16, 2, 0, 8, 9, 9); LDA.Add(a);
            a = new Aluno(16, 1, 0, 14, 13, 13); LDA.Add(a);
            a = new Aluno(16, 1, 2, 14, 14, 14); LDA.Add(a);
            a = new Aluno(17, 4, 0, 10, 11, 10); LDA.Add(a);
            a = new Aluno(16, 2, 0, 14, 13, 14); LDA.Add(a);
            a = new Aluno(16, 1, 0, 17, 16, 16); LDA.Add(a);
            a = new Aluno(17, 1, 12, 6, 7, 7); LDA.Add(a);
            a = new Aluno(16, 1, 8, 14, 12, 13); LDA.Add(a);
            a = new Aluno(17, 4, 2, 10, 8, 9); LDA.Add(a);
            a = new Aluno(16, 4, 0, 14, 14, 14); LDA.Add(a);
            a = new Aluno(19, 3, 0, 12, 13, 13); LDA.Add(a);
            a = new Aluno(17, 1, 0, 11, 11, 11); LDA.Add(a);
            a = new Aluno(20, 2, 8, 11, 9, 10); LDA.Add(a);
            a = new Aluno(17, 3, 0, 11, 11, 10); LDA.Add(a);
            a = new Aluno(17, 1, 0, 10, 9, 9); LDA.Add(a);
            a = new Aluno(16, 2, 0, 16, 17, 18); LDA.Add(a);
            a = new Aluno(17, 2, 0, 15, 17, 17); LDA.Add(a);
            a = new Aluno(17, 2, 1, 11, 9, 10); LDA.Add(a);
            a = new Aluno(18, 2, 9, 7, 7, 7); LDA.Add(a);
            a = new Aluno(16, 1, 0, 8, 6, 8); LDA.Add(a);
            a = new Aluno(16, 1, 2, 7, 6, 7); LDA.Add(a);
            a = new Aluno(18, 2, 8, 9, 8, 10); LDA.Add(a);
            a = new Aluno(16, 2, 0, 14, 16, 16); LDA.Add(a);
            a = new Aluno(16, 1, 0, 14, 14, 15); LDA.Add(a);
            a = new Aluno(18, 2, 8, 8, 5, 8); LDA.Add(a);
            a = new Aluno(16, 2, 0, 8, 7, 0); LDA.Add(a);
            a = new Aluno(16, 2, 6, 6, 8, 8); LDA.Add(a);
            a = new Aluno(16, 2, 0, 8, 10, 10); LDA.Add(a);
            a = new Aluno(16, 2, 4, 8, 8, 8); LDA.Add(a);
            a = new Aluno(18, 4, 2, 5, 6, 6); LDA.Add(a);
            a = new Aluno(16, 2, 2, 7, 9, 8); LDA.Add(a);
            a = new Aluno(17, 3, 0, 15, 14, 16); LDA.Add(a);
            a = new Aluno(17, 1, 1, 13, 14, 14); LDA.Add(a);
            a = new Aluno(16, 3, 0, 10, 9, 10); LDA.Add(a);
            a = new Aluno(17, 1, 5, 9, 9, 9); LDA.Add(a);
            a = new Aluno(16, 1, 1, 11, 11, 11); LDA.Add(a);
            a = new Aluno(17, 1, 8, 7, 10, 9); LDA.Add(a);
            a = new Aluno(17, 2, 0, 10, 10, 10); LDA.Add(a);
            a = new Aluno(16, 2, 2, 9, 7, 8); LDA.Add(a);
            a = new Aluno(16, 2, 0, 14, 15, 16); LDA.Add(a);
            a = new Aluno(16, 1, 0, 11, 12, 12); LDA.Add(a);
            a = new Aluno(15, 2, 11, 9, 11, 10); LDA.Add(a);
            a = new Aluno(15, 4, 8, 13, 14, 14); LDA.Add(a);
            a = new Aluno(15, 1, 11, 12, 13, 12); LDA.Add(a);
            a = new Aluno(16, 3, 2, 11, 11, 11); LDA.Add(a);
            a = new Aluno(16, 2, 8, 9, 10, 10); LDA.Add(a);
            a = new Aluno(17, 1, 5, 9, 11, 11); LDA.Add(a);
            a = new Aluno(17, 2, 0, 11, 9, 11); LDA.Add(a);
            a = new Aluno(16, 3, 1, 10, 11, 12); LDA.Add(a);
            a = new Aluno(17, 1, 2, 9, 9, 8); LDA.Add(a);
            a = new Aluno(17, 1, 2, 12, 11, 12); LDA.Add(a);
            a = new Aluno(17, 2, 8, 8, 9, 8); LDA.Add(a);
            a = new Aluno(17, 2, 0, 13, 15, 16); LDA.Add(a);
            a = new Aluno(16, 1, 0, 10, 11, 11); LDA.Add(a);
            a = new Aluno(17, 2, 2, 11, 10, 11); LDA.Add(a);
            a = new Aluno(17, 2, 0, 17, 18, 18); LDA.Add(a);
            a = new Aluno(16, 2, 0, 12, 13, 13); LDA.Add(a);
            a = new Aluno(17, 2, 0, 13, 14, 13); LDA.Add(a);
            a = new Aluno(19, 2, 2, 9, 9, 10); LDA.Add(a);
            a = new Aluno(17, 1, 4, 11, 11, 12); LDA.Add(a);
            a = new Aluno(17, 1, 3, 10, 11, 10); LDA.Add(a);
            a = new Aluno(16, 3, 5, 13, 14, 13); LDA.Add(a);
            a = new Aluno(16, 1, 4, 9, 10, 11); LDA.Add(a);
            a = new Aluno(17, 2, 2, 7, 9, 10); LDA.Add(a);
            a = new Aluno(17, 1, 0, 8, 13, 10); LDA.Add(a);
            a = new Aluno(18, 1, 0, 12, 12, 13); LDA.Add(a);
            a = new Aluno(17, 1, 0, 10, 9, 10); LDA.Add(a);
            a = new Aluno(18, 2, 6, 10, 9, 10); LDA.Add(a);
            a = new Aluno(16, 2, 0, 11, 13, 12); LDA.Add(a);
            a = new Aluno(17, 1, 0, 7, 0, 0); LDA.Add(a);
            a = new Aluno(16, 1, 2, 11, 9, 10); LDA.Add(a);
            a = new Aluno(16, 1, 0, 10, 10, 9); LDA.Add(a);
            a = new Aluno(18, 1, 2, 9, 7, 9); LDA.Add(a);
            a = new Aluno(18, 1, 0, 4, 0, 0); LDA.Add(a);
            a = new Aluno(19, 1, 4, 6, 11, 9); LDA.Add(a);
            a = new Aluno(18, 2, 9, 4, 8, 8); LDA.Add(a);
            a = new Aluno(16, 1, 6, 7, 8, 8); LDA.Add(a);
            a = new Aluno(19, 1, 4, 8, 9, 9); LDA.Add(a);
            a = new Aluno(16, 2, 8, 5, 5, 7); LDA.Add(a);
            a = new Aluno(17, 1, 9, 7, 9, 10); LDA.Add(a);
            a = new Aluno(20, 1, 12, 8, 11, 10); LDA.Add(a);
            a = new Aluno(18, 1, 8, 10, 11, 10); LDA.Add(a);
            a = new Aluno(18, 1, 8, 9, 10, 11); LDA.Add(a);
            a = new Aluno(19, 2, 8, 10, 9, 11); LDA.Add(a);
            a = new Aluno(17, 2, 4, 8, 9, 10); LDA.Add(a);
            a = new Aluno(18, 1, 0, 9, 10, 9); LDA.Add(a);
            a = new Aluno(19, 1, 4, 8, 9, 10); LDA.Add(a);
            a = new Aluno(18, 2, 2, 6, 8, 8); LDA.Add(a);
            a = new Aluno(19, 1, 0, 6, 8, 7); LDA.Add(a);
            a = new Aluno(18, 1, 0, 8, 6, 0); LDA.Add(a);
            a = new Aluno(17, 1, 0, 10, 11, 11); LDA.Add(a);
            a = new Aluno(17, 3, 5, 8, 7, 8); LDA.Add(a);
            a = new Aluno(17, 2, 0, 8, 8, 0); LDA.Add(a);
            a = new Aluno(18, 2, 3, 7, 6, 8); LDA.Add(a);
            a = new Aluno(17, 1, 0, 8, 10, 9); LDA.Add(a);
            a = new Aluno(17, 1, 0, 7, 10, 10); LDA.Add(a);
            a = new Aluno(18, 2, 3, 7, 8, 7); LDA.Add(a);
            a = new Aluno(18, 2, 2, 12, 13, 14); LDA.Add(a);
            a = new Aluno(17, 1, 0, 11, 12, 13); LDA.Add(a);
            a = new Aluno(18, 2, 0, 12, 13, 14); LDA.Add(a);
            a = new Aluno(18, 2, 0, 18, 18, 18); LDA.Add(a);
            a = new Aluno(18, 1, 3, 17, 17, 17); LDA.Add(a);
            a = new Aluno(17, 2, 0, 17, 18, 18); LDA.Add(a);
            a = new Aluno(18, 2, 0, 9, 0, 0); LDA.Add(a);
            a = new Aluno(18, 1, 8, 10, 11, 11); LDA.Add(a);
            a = new Aluno(18, 1, 5, 12, 13, 14); LDA.Add(a);
            a = new Aluno(17, 1, 4, 12, 13, 14); LDA.Add(a);
            a = new Aluno(18, 2, 4, 8, 8, 10); LDA.Add(a);
            a = new Aluno(18, 3, 0, 11, 12, 13); LDA.Add(a);
            a = new Aluno(18, 2, 0, 5, 0, 0); LDA.Add(a);
            a = new Aluno(18, 2, 2, 9, 10, 10); LDA.Add(a);
            a = new Aluno(19, 1, 0, 5, 0, 0); LDA.Add(a);
            a = new Aluno(17, 4, 0, 18, 18, 18); LDA.Add(a);
            a = new Aluno(17, 2, 5, 11, 11, 12); LDA.Add(a);
            a = new Aluno(18, 2, 2, 8, 10, 11); LDA.Add(a);
            a = new Aluno(18, 2, 0, 11, 11, 12); LDA.Add(a);
            a = new Aluno(19, 2, 0, 8, 0, 0); LDA.Add(a);
            a = new Aluno(18, 3, 5, 14, 14, 15); LDA.Add(a);
            a = new Aluno(17, 2, 4, 10, 11, 11); LDA.Add(a);
            a = new Aluno(18, 2, 0, 10, 10, 10); LDA.Add(a);
            a = new Aluno(17, 2, 2, 12, 12, 12); LDA.Add(a);
            a = new Aluno(17, 2, 0, 15, 14, 15); LDA.Add(a);
            a = new Aluno(18, 1, 2, 14, 13, 14); LDA.Add(a);
            a = new Aluno(18, 3, 0, 19, 17, 18); LDA.Add(a);
            a = new Aluno(18, 2, 0, 16, 15, 15); LDA.Add(a);
            a = new Aluno(18, 2, 6, 13, 12, 13); LDA.Add(a);
            a = new Aluno(17, 2, 4, 15, 14, 15); LDA.Add(a);
            a = new Aluno(17, 2, 0, 13, 13, 13); LDA.Add(a);
            a = new Aluno(18, 2, 0, 8, 10, 9); LDA.Add(a);
            a = new Aluno(18, 3, 0, 15, 16, 16); LDA.Add(a);
            a = new Aluno(17, 1, 0, 8, 8, 9); LDA.Add(a);
            a = new Aluno(18, 1, 0, 10, 10, 10); LDA.Add(a);
            a = new Aluno(18, 2, 0, 7, 5, 0); LDA.Add(a);
            a = new Aluno(18, 1, 3, 9, 10, 10); LDA.Add(a);
            a = new Aluno(17, 3, 8, 10, 11, 12); LDA.Add(a);
            a = new Aluno(17, 1, 4, 7, 8, 9); LDA.Add(a);
            a = new Aluno(18, 3, 0, 15, 17, 17); LDA.Add(a);
            a = new Aluno(18, 3, 4, 10, 11, 12); LDA.Add(a);
            a = new Aluno(19, 2, 4, 7, 8, 9); LDA.Add(a);
            a = new Aluno(18, 2, 1, 13, 14, 14); LDA.Add(a);
            a = new Aluno(18, 2, 1, 16, 16, 16); LDA.Add(a);
            a = new Aluno(17, 2, 10, 8, 9, 9); LDA.Add(a);
            a = new Aluno(18, 2, 4, 17, 18, 19); LDA.Add(a);
            a = new Aluno(18, 1, 0, 7, 7, 0); LDA.Add(a);
            a = new Aluno(17, 2, 4, 14, 15, 16); LDA.Add(a);
            a = new Aluno(19, 1, 0, 5, 8, 0); LDA.Add(a);
            a = new Aluno(18, 1, 0, 7, 7, 0); LDA.Add(a);
            a = new Aluno(18, 3, 0, 14, 17, 15); LDA.Add(a);
            a = new Aluno(17, 2, 0, 6, 9, 11); LDA.Add(a);
            a = new Aluno(18, 1, 4, 7, 9, 10); LDA.Add(a);
            a = new Aluno(19, 3, 4, 10, 11, 10); LDA.Add(a);
            a = new Aluno(18, 2, 4, 15, 15, 16); LDA.Add(a);
            a = new Aluno(18, 2, 6, 11, 12, 9); LDA.Add(a);
            a = new Aluno(17, 1, 6, 10, 10, 10); LDA.Add(a);
            a = new Aluno(18, 1, 4, 10, 11, 11); LDA.Add(a);

            #endregion

            return LDA;
        }

    }
}
