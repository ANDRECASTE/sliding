using System;
using System.Collections.Generic;
using System.Linq;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        int lunghezza= digits.Length;
        int prodmassimo=0;

        if(span>lunghezza)
            throw new System.ArgumentException();
        
        if(span<0)
            throw new System.ArgumentException();
        
        if(span==0)
            return 1;
        
        char[] vet= digits.ToCharArray();

        for(int i=0; i<lunghezza;i++)
        {
            if(char.IsLetter(vet[i]))
            {
                throw new System.ArgumentException();
            }
        }

        for(int j=0; j<=lunghezza-span;j++)
        {
            int prod=1;
            int segnap=j; 

            for(int k=0; k<span ;k++)
            {
                prod= prod*(vet[segnap]-48);
                segnap=segnap+1;
            }

            if (prod>prodmassimo)
            {
                prodmassimo=prod;
            }
        }

        return prodmassimo;
    }
}