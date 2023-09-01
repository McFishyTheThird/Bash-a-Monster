namespace BigBad;
public class BadPeople
{
    public int hp;
    public int dmgReduction;
    public int maxHp = 100;
    
    public void ResetHP()
    {
        hp = maxHp;
    }
}
