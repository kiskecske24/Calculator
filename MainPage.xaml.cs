namespace calulator;
using NCalc;


public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
    
    public const double π = 3.1415926535897931;

    public bool isdegree=false;

    

    private void PercentageButtonClicked(object sender, EventArgs e)
    {
        bool isAlreadyThere = false;
            string szoveg = calculatorlabel.Text;
            if (szoveg.Length==0)
            {
                isAlreadyThere=true;
            }
            if (szoveg.EndsWith("/"))
                {
                    isAlreadyThere=true;
                }
            else if (szoveg.EndsWith("*"))
                {
                    isAlreadyThere=true;
                }
            else if (szoveg.EndsWith("-"))
                {
                    isAlreadyThere=true;
                }
            else if (szoveg.EndsWith("+"))
                {
                    isAlreadyThere=true;
                }
        if (calculatorlabel.Text.Length>0 & isAlreadyThere==false) 
        {
            var expression = new Expression (calculatorlabel.Text);
            var result = expression.Evaluate();
            testlabel.Text =result.ToString();
            float number = float.Parse(testlabel.Text)/100;
            testlabel.Text = Convert.ToString(number);
        }
    }

    

    private void BackspaceButtonClicked(object sender, EventArgs e)
    {
        if (calculatorlabel.Text.Length>0)
        {
            calculatorlabel.Text = calculatorlabel.Text.Remove(calculatorlabel.Text.Length-1);
        }    
    }
    private void DeleteButtonClicked(object sender, EventArgs e)
    {
        if (calculatorlabel.Text == "")
        {
            testlabel.Text="";
        }
        else
        {
            calculatorlabel.Text = "";
        }
    }
    private void CommaButtonClicked(object sender, EventArgs e)
    {
        calculatorlabel.Text = calculatorlabel.Text + ".";
    }
    
    private void PlusMinusButtonClicked(object sender, EventArgs e)
    {
        string szoveg=calculatorlabel.Text;
        bool isNegative=true;
        if (szoveg.StartsWith("-"))
        {
            isNegative=true;
        }
        else
        {
            isNegative=false;
        }

        if (isNegative==false)
        {
            calculatorlabel.Text="-"+calculatorlabel.Text;
        }
        else
        {
            calculatorlabel.Text = szoveg.Remove(0,1);
        }
    }
    private void MinusButtonClicked(object sender, EventArgs e)
    {
        bool isAlreadyThere = false;
            string szoveg = calculatorlabel.Text;
            if (szoveg.Length==0)
            {
                isAlreadyThere=true;
            }
            if (szoveg.EndsWith("/"))
                {
                    isAlreadyThere=true;
                }
            else if (szoveg.EndsWith("*"))
                {
                    isAlreadyThere=true;
                }
            else if (szoveg.EndsWith("-"))
                {
                    isAlreadyThere=true;
                }
            else if (szoveg.EndsWith("+"))
                {
                    isAlreadyThere=true;
                }
            if (isAlreadyThere==false)
                {
                    calculatorlabel.Text = calculatorlabel.Text + "-";
                }    
    }
    public void PlusButtonClicked(object sender, EventArgs e)
    {
        bool isAlreadyThere = false;
        string szoveg = calculatorlabel.Text;
        if (szoveg.Length==0)
            {
                isAlreadyThere=true;
            }
        if (szoveg.EndsWith("/"))
            {
                isAlreadyThere=true;
            }
        else if (szoveg.EndsWith("*"))
            {
                isAlreadyThere=true;
            }
        else if (szoveg.EndsWith("-"))
            {
                isAlreadyThere=true;
            }
        else if (szoveg.EndsWith("+"))
            {
                isAlreadyThere=true;
            }
        if (isAlreadyThere==false)
            {
                calculatorlabel.Text = calculatorlabel.Text + "+";
            }    
    }
    private void DivideButtonClicked(object sender, EventArgs e)
    {
        bool isAlreadyThere = false;
        string szoveg = calculatorlabel.Text;
        if (szoveg.Length==0)
            {
                isAlreadyThere=true;
            }
        if (szoveg.EndsWith("/"))
            {
                isAlreadyThere=true;
            }
        else if (szoveg.EndsWith("*"))
            {
                isAlreadyThere=true;
            }
        else if (szoveg.EndsWith("-"))
            {
                isAlreadyThere=true;
            }
        else if (szoveg.EndsWith("+"))
            {
                isAlreadyThere=true;
            }
        if (isAlreadyThere==false)
            {
                calculatorlabel.Text = calculatorlabel.Text + "/";
            }     
    }

    private void TimesButtonClicked(object sender, EventArgs e)
    {   
        bool isAlreadyThere = false;
        string szoveg = calculatorlabel.Text;
        if (szoveg.Length==0)
            {
                isAlreadyThere=true;
            }
        if (szoveg.EndsWith("/"))
            {
                isAlreadyThere=true;
            }
        else if (szoveg.EndsWith("*"))
            {
                isAlreadyThere=true;
            }
        else if (szoveg.EndsWith("-"))
            {
                isAlreadyThere=true;
            }
        else if (szoveg.EndsWith("+"))
            {
                isAlreadyThere=true;
            }
        if (isAlreadyThere==false)
            {
                calculatorlabel.Text = calculatorlabel.Text + "*";
            }
    }
    private void StartBracketsButtonClicked(object sender, EventArgs e)
    {
        calculatorlabel.Text = calculatorlabel.Text + "(";
    }
    private void EndBracketsButtonClicked(object sender, EventArgs e)
    {
        bool endsWith=true;
        if (calculatorlabel.Text.EndsWith("("))
        {
            endsWith=false;
        }
            if (endsWith==true)
            {
                calculatorlabel.Text = calculatorlabel.Text + ")";
            }
    }

    private void Button0Clicked(object sender, EventArgs e)
    {
        calculatorlabel.Text = calculatorlabel.Text + "0";
    }
    
    private void Button1Clicked(object sender, EventArgs e)
    {
        calculatorlabel.Text = calculatorlabel.Text+"1";
    }
    private void Button2Clicked(object sender, EventArgs e)
    {
        calculatorlabel.Text = calculatorlabel.Text + "2";
    }
    private void Button3Clicked(object sender, EventArgs e)
    {
        calculatorlabel.Text = calculatorlabel.Text + "3";
    }
    private void Button4Clicked(object sender, EventArgs e)
    {
        calculatorlabel.Text = calculatorlabel.Text + "4";
    }
    private void Button5Clicked(object sender, EventArgs e)
    {
        calculatorlabel.Text = calculatorlabel.Text + "5";
    }
    private void Button6Clicked(object sender, EventArgs e)
    {
        calculatorlabel.Text = calculatorlabel.Text + "6";
    }
    private void Button7Clicked(object sender, EventArgs e)
    {
        calculatorlabel.Text = calculatorlabel.Text + "7";
    }
    private void Button8Clicked(object sender, EventArgs e)
    {
        calculatorlabel.Text = calculatorlabel.Text + "8";
    }
    private void Button9Clicked(object sender, EventArgs e)
    {
        calculatorlabel.Text = calculatorlabel.Text + "9";
    }
    
    private void FunctionsButtonClicked(object sender, EventArgs e)
    {   
        Basicpage.IsVisible=!Basicpage.IsVisible;
        Functionspage.IsVisible=!Functionspage.IsVisible;
    }
    private void ToDegrees(object sender, EventArgs eventArgs)
    {
        isdegree=!isdegree;
        if (isdegree==true)
            {
                isdegreelabel.Text="Deg";
            }
        else if (isdegree==false)
            {
                isdegreelabel.Text="Rad";
            }

    }
    private void CosineButtonClicked(object sender, EventArgs e)
    {   
        if (isdegree==true)
            {
                double degrees=float.Parse(calculatorlabel.Text)/180*3.1415926535897931;
                string strdegrees=degrees.ToString();
                calculatorlabel.Text="Cos(" + strdegrees + ")"; 
            }
        else if (isdegree==false)
            {
                if (calculatorlabel.Text=="")
                {
                    calculatorlabel.Text="Cos(";
                }
                else
                { 
                    calculatorlabel.Text="Cos(" + calculatorlabel.Text + ")";
                }
            }
    }
    private void SinusButtonClicked(object sender, EventArgs e)
    {
        if (isdegree==true)
            {
                double degrees=float.Parse(calculatorlabel.Text)/180*3.1415926535897931;
                string strdegrees=degrees.ToString();
                calculatorlabel.Text="Sin(" + strdegrees + ")"; 
            }
            else if (isdegree==false)
            {
                if (calculatorlabel.Text=="")
                {
                    calculatorlabel.Text="Sin(";
                }
                else
                { 
                    calculatorlabel.Text="Sin(" + calculatorlabel.Text + ")";
                }
            }
    }
    private void TangentButtonClicked(object sender, EventArgs e)
    {
        if (isdegree==true)
            {
                double degrees=float.Parse(calculatorlabel.Text)/180*3.1415926535897931;
                string strdegrees=degrees.ToString();
                calculatorlabel.Text="Tan(" + strdegrees + ")"; 
            }
            else if (isdegree==false)
            {
                if (calculatorlabel.Text=="")
                    {
                        calculatorlabel.Text="Tan(";
                    }
                    else
                    { 
                        calculatorlabel.Text="Tan(" + calculatorlabel.Text + ")";
                    }
            }
    }
    private void CotangentButtonClicked(object sender, EventArgs e)
    {   
        if (isdegree==true)
            {
                double degrees=float.Parse(calculatorlabel.Text)/180*3.1415926535897931;
                string strdegrees=degrees.ToString();
                calculatorlabel.Text="Sin(" + strdegrees + ")"; 
            }
            else if (isdegree==false)
            {
                if (calculatorlabel.Text=="")
                {
                    calculatorlabel.Text="Ctg(";
                }
                else
                { 
                    calculatorlabel.Text="Ctg(" + calculatorlabel.Text + ")";
                }
            }
    }    
    
    private void piButtonClicked(object sender, EventArgs e)
    {
        calculatorlabel.Text=calculatorlabel.Text + π;
    }
    private void PrimeGenClicked(object sender, EventArgs e)
    {
        Int64 number=Int64.Parse(calculatorlabel.Text);
        int i=2;
        string primes="";
        while (i<number)
        {   
            if (number%i!=0)
            {
                i++;
            }
            else
            {   
                if (primes.Length==0)
                {
                    primes=primes+ i;
                }
                else
                {
                    primes=primes+'*'+i;
                }
                number=number/i;
                i=2;
            }
        }
        if(i==number)
        {
            if (primes.Length==0)
                {
                    primes=primes+ i;
                }
                else
                {
                    primes=primes+'*'+i;
                }
        }
        testlabel.Text="primes: " + primes;
    }
    private void SquaredButtonClicked(object sender, EventArgs e)
    {
        var expression = new Expression (calculatorlabel.Text);
        var result = expression.Evaluate();
        string number;
        number = result.ToString();
        calculatorlabel.Text=result.ToString()+"^2";
        int finalnumber=int.Parse(number)*int.Parse(number);
        testlabel.Text=finalnumber.ToString();
    }
    private void XtotheNClicked(object sender, EventArgs e)
    {
        calculatorlabel.Text=calculatorlabel.Text+"^";
        
    }
    private void AnswerButtonClicked(object sender, EventArgs e)
    {
        if (testlabel.Text.Length>0)
        {
            calculatorlabel.Text=testlabel.Text;
            testlabel.Text="";
        }
    }


    public bool equation=false;
    
    public float a;
    public float b;
    public float c;
    public bool aset=false;
    public bool bset=false;
    public bool cset=false;
    private void equationmethod(object sender, EventArgs e)
    {
        equation=true;
        
        if (aset==false)
        {
            calculatorlabel.Text= "a=";
            aset=true;  
        }           
                    
        else if (bset==false)
        {
            calculatorlabel.Text= "b=";
            bset=true;  
        }    
        else if (cset==false)
        {
            calculatorlabel.Text= "c=";
            cset=true;  
        }    
                    
        
    }
    
    private void EqualsButtonClicked(object sender, EventArgs e)
    {   
        if (equation==false)
            {
                int Place=calculatorlabel.Text.Length-calculatorlabel.Text.IndexOf('^');
                bool check=calculatorlabel.Text.Contains("^");
                    if(char.IsDigit(calculatorlabel.Text.Last())==true && check==true)
                    {
                        int Sequence=int.Parse(calculatorlabel.Text.Substring(Place-1));
                        string substring=calculatorlabel.Text.Substring(0, calculatorlabel.Text.Length-Place);
                        var expression = new Expression (substring);
                        var result = expression.Evaluate();
                        int number = int.Parse(result.ToString());
                        int finalnumber=1;
                        int i=0;
                        Console.WriteLine(Sequence);
                        
                        while (i<Sequence)
                        {
                            
                            finalnumber=number*finalnumber;
                            Console.WriteLine(finalnumber);
                            i++;
                            
                        }
                        testlabel.Text=finalnumber.ToString();
                        

                    }       
                    else  
                    {   
                        bool isAlreadyThere = false;
                        string szoveg = calculatorlabel.Text;
                        if (szoveg.Length==0)
                        {
                            isAlreadyThere=true;
                        }
                        if (szoveg.EndsWith("/"))
                            {
                                isAlreadyThere=true;
                            }
                        else if (szoveg.EndsWith("*"))
                            {
                                isAlreadyThere=true;
                            }
                        else if (szoveg.EndsWith("-"))
                            {
                                isAlreadyThere=true;
                            }
                        else if (szoveg.EndsWith("+"))
                            {
                                isAlreadyThere=true;
                            }
                        if (calculatorlabel.Text.Length>0 & isAlreadyThere==false) 
                        {
                            var expression = new Expression (calculatorlabel.Text);
                            var result = expression.Evaluate();
                            testlabel.Text =result.ToString();
                        }
                    }
            }
        else if (equation==true)
            {
                if (aset==true && bset==false)     
                {
                    a = int.Parse(calculatorlabel.Text.Substring(2)); 
                    calculatorlabel.Text="";
                }

                else if (bset==true && cset==false)
                {
                    b = float.Parse(calculatorlabel.Text.Substring(2));
                    calculatorlabel.Text=""; 
                }
                
                else if (cset==true)
                {
                    c = float.Parse(calculatorlabel.Text.Substring(2));
                    float d = b*b-4*a*c;
                    if (d<0)
                    {
                        calculatorlabel.Text="No value found for x";
                        equation=false;
                        aset=false; 
                        bset=false; 
                        cset=false;    
                    }
                    else if(d==0)
                    {
                        double result1 = (-b)/(2*a);
                        calculatorlabel.Text = "x=" + result1;
                        equation=false;
                        aset=false; 
                        bset=false; 
                        cset=false;    
                    }
                    else if (d>0)
                    {
                        double sqrt = Math.Sqrt(d);
                        double result1 = (-b+sqrt)/(2*a);
                        double result2 = (-b-sqrt)/(2*a);
                        calculatorlabel.Text ="d="+ d + " x1=" + result1 +  " x2=" + result2 ;
                        equation=false;
                        aset=false; 
                        bset=false; 
                        cset=false;    
                    }           
                }                
            }
    }
    private void SquarerootButtonClicked(object sender, EventArgs e)
    {
        if (calculatorlabel.Text=="")
        {
            calculatorlabel.Text="Sqrt(";
        }
        else 
        {
            calculatorlabel.Text="Sqrt("+calculatorlabel.Text+")";
        }    
    }

}

