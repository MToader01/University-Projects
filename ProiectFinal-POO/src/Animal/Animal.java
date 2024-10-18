package Animal;

public class Animal{
    private String nume;

    private String specie;

    private String rasa;
    private int varsta;

    public Animal()
    {}

    public Animal(String nume, String specie, String rasa, int varsta)
    {
        this.nume=nume;
        this.specie=specie;
        this.rasa=rasa;
        this.varsta=varsta;
    }

    public void setNume(String nume){
        this.nume=nume;
    }

    public void setSpecie(String specie){
        this.specie=specie;
    }

    public void setRasa(String rasa){
        this.rasa=rasa;
    }

    public void setVarsta(int varsta){
        this.varsta=varsta;
    }

    public String getNume(){
        return this.nume;
    }

    public String getSpecie(){
        return this.specie;
    }

    public String getRasa(){
        return this.rasa;
    }

    public int getVarsta(){
        return this.varsta;
    }
}