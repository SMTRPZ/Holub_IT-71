using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PictureMatrix
{
    public class DefaultStrategy : IParameterCout
    {
        private int con;
        private int ent;
        private int cor;
        private int asm;

        public int getCon()
        {
            return this.con;
        } 
        
        public int getEnt()
        {
            return this.ent;
        } 

        public int getCor()
        {
            return this.cor;
        }
        public int getAsm()
        {
            return this.asm;
        }

        public void countParameters(double i, double j)
        {
            this.asm = this.ASM(i, j);
            this.cor = this.COR(i, j);
            this.con = this.CON(i, j);
            this.ent = this.ENT(i, j);

        }
        public int CON(double i, double j)
        {
            double res = i - j;
            return (int)Math.Pow(res, 2)*this.p(i, j);
        }
        public int ENT(double i, double j)
        {
            return (int)this.p(i, j)* (int)Math.Log(this.p(i, j));
        }
        public int COR(double i, double j)
        {
            return (int)i* (int)j *this.p(i, j);
        }
        public int ASM(double i, double j)
        {
            return (int)Math.Pow(this.p(i, j), 2);
        }

        public int p(double i, double j)
        {
            return (int)i * (int)j;
        }
    }
}