import Animal.Animal;
import Client.Client;

import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;

public class AdapostAnimale extends JFrame{
    private static AdapostAnimale Instance = new AdapostAnimale();

    public AdapostAnimale(String title){
        super(title);
        this.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        this.setContentPane(mainPanel);
        this.pack();
    }

    private JFrame F;
    private JFrame Fl;
    private JFrame Fa;
    private JFrame Fb;
    private ArrayList<Animal> ListaAnimale = new ArrayList<Animal>();
    private JRadioButton adaugatiUnAnimalRadioButton;
    private JRadioButton adaugatiUnClientRadioButton;
    private JRadioButton aratatiAnimaleleRadioButton;
    private JRadioButton aratatiClientiiRadioButton;
    private JButton selectatiButton;
    private JPanel mainPanel;

    private AdapostAnimale() {
        selectatiButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                F.setVisible(false);
                if(adaugatiUnAnimalRadioButton.isSelected())
                {
                    ArrayList<String> animale = new ArrayList<String>();
                    for(Animal i : ListaAnimale){
                        StringBuffer message = new StringBuffer();
                        message.append(i.getNume());
                        message.append(" ");
                        message.append(i.getSpecie());
                        message.append(" ");
                        message.append(i.getRasa());
                        message.append(" ");
                        message.append(i.getVarsta());
                        animale.add(message.toString());
                    }
                    ListaAnimale.getInstanceAnimale().setListaAnimale(animale);
                    Fl.setVisible(true);
                } else if (adaugatiUnClientRadioButton.isSelected()) {
                    ArrayList<String> clienti = new ArrayList<String>();
                    for(Client j : ListaOameni) {
                        StringBuffer message2 = new StringBuffer();
                        message2.append(j.getNumeClienti());
                        message2.append(" ");
                        message2.append(j.getTelefon());
                        message2.append(" ");
                        message2.append(j.getAdresa());
                        clienti.add(message2.toString());
                    }
                    ListaOameni.getInstance().setList(clienti);
                    Fa.setVisible(true);
                }else if (aratatiAnimaleleRadioButton.isSelected()) {
                    Fb.setVisible(true);
                }else if (aratatiClientiiRadioButton.isSelected()) {
                    Fb.setVisible(true);
                }
            }
        });
    }

    public static void main(String[] args) {
        Instance.F = new JFrame("Adapost de Animale");
        ListaAnimale a = ListaAnimale().getInstanceAnimal();
        AdaugareAnimal fa = AdaugareAnimal.getInstance();
        Instance.Fl=new JFrame();
        Instance.Fa=new JFrame();
        Instance.Fl.setContentPane(a.getPanel());
        Instance.Fa.setContentPane(fa.getPanel());
        Instance.F.setContentPane(Instance.mainPanel);
        ButtonGroup bg = new ButtonGroup();
        bg.add(Instance.adaugatiUnAnimalRadioButton);
        bg.add(Instance.adaugatiUnClientRadioButton);
        bg.add(Instance.aratatiAnimaleleRadioButton);
        bg.add(Instance.aratatiClientiiRadioButton);
        Instance.aratatiAnimaleleRadioButton.setSelected(true);
        Instance.F.pack();
        Instance.Fa.pack();
        Instance.Fl.pack();
        Instance.F.setVisible(true);
        Instance.aratatiClientiiRadioButton.setSelected(true);
        Instance.F.pack();
        Instance.Fa.pack();
        Instance.Fl.pack();
        Instance.F.setVisible(true);
    }
    public JFrame getFrame(){
        return this.F;
    }

    public JFrame getFrameLista(){
        return this.Fl;
    }

    public JFrame getFrameAdaugare(){
        return this.Fa;
    }

    public static AdapostAnimale getInstance(){
        return Instance;
    }

    public void AdaugareAnimal(Animal animal){
        ListaAnimale.add(animal);
    }
    public void AdaugareClient(Client client){
        ListaOameni.add(client);
    }
}