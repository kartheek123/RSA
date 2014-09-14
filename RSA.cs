using System; 
using System.IO;

class bonusAssignment
{
 
 	static void Main()
 	{


ulong p = 32779;
ulong q = 30059;
ulong n = 985303961;
ulong phi(n) = 985241124;
ulong e = 1055555;
ulong d = 433979135;


string plainText = "Hello D.E.A.R. I am student 20522351. This is my little secret: 32779 and 30059. The ICC World Twenty20 is the international championship of Twenty20 cricket. It is organized by cricket's government body, the International Cricket Council. The tournament consists of 12 teams representing different cricket playing nations. The event is generally held every two years, and all matches are accorded Twenty20 International status. The 2014 event will be a host to 16 nations. Previous winners include India, Pakistan, England and West Indies.";
        
        char[] charactersplit=new char[plainText.Length]; //array for storing each character
        charactersplit = plainText.ToCharArray();      //storing each char
        
        ulong [] splitstoring = new ulong[plainText.Length/4];
        ulong[] ASCII= new ulong[plainText.Length];
        
        long[] myencryption = new long[splitstoring.Length];
        long[] otherencryption = new long[splitstoring.Length];
        
       

        for(int i=0; i<charactersplit.Length; i++)
        (
            foreach(char c in charactersplit)
            (
                ASCII[i]=Convert.ToInt32(c);
                i++;
            )
        )
        
        public ulong mcalc(ulong x1, ulong x2, ulong x3, ulong x4)
        {
            ulong m = x1*Math.Pow(256,3)+x2*Math.Pow(256,2)+x3*Math.Pow(256,1)+x*4;
            return m;
        }
        
        public mcalculations()
        {   ulong x1=0;
            ulong x2=1;
            ulong x3=2;
            ulong x4=3;
            int counter=0;
        while(x4 <= ASCII.Length)
        {
            splitstoring[counter]=mcalc(ASCII[x1],ASCII[x2],ASCII[x3],ASCII[x4]);
            x1 +=4;
            x2 +=4;
            x3 +=4;
            x4 +=4;
            counter++;
        }
        }
    
        public ulong Repeatedsquaring(ulong splitstoring, ulong n, ulong d)
        {
            ulong output=1;
            while(true)
            {   if(d%2=1)
                {
                    output=((output*splitstoring) % n);
                }
                
                d=d/2;
                if(e=0)
                {break;}
                
                splitstoring=((splitstoring*splitstoring) % n);
            }
            return output;
        }
        
        for(int k=0; k<splitstoring.Length; k++)
        (
            myencryption[k]=Repeatedsquaring(splitstoring[k],n,d);
        )
        
        for(int l=0; l<myecryption.Length; l++)
        (
            otherencryption[l]=Repeatedsquaring(myencryption[l],3125033603,52741219);
        )
        
       

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Kartheek\Documents\ECE 150\20522351.txt"))
                {
                    file.Write(n + " " + e + " " + plainText.Length + " ");

                    for(int i = 0; i < myencryption.Length; i++)
                    {
                        file.Write(otherencryption[i] + " ");
                    }
                    file.Close();
                }
    }
        
}