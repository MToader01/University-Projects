package Client;

public class Client{
    private String numeClienti;

    private String telefon;

    private String adresa;

    public Client()
    {}

    public Client(String numeClienti, String telefon, String adresa)
    {
        this.numeClienti=numeClienti;
        this.telefon=telefon;
        this.adresa=adresa;
    }

    public void setNumeClienti(String numeClienti){
        this.numeClienti=numeClienti;
    }

    public void setTelefon(String telefon){
        this.telefon=telefon;
    }

    public void setAdresa(String adresa){
        this.adresa=adresa;
    }


    public String getNumeClienti(){
        return this.numeClienti;
    }

    public String getTelefon(){
        return this.telefon;
    }

    public String getAdresa(){
        return this.adresa;
    }
}