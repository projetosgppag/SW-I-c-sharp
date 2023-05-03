namespace pasta;
class FuncN1 : Func
{
    public override double Lucro(){
        return base.Lucro() * 0.01;
    }
}
