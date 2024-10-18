import Animal.Animal;
import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

public class AdaugareAnimal {
    private static AdaugareAnimal Instance = new AdaugareAnimal();
    private JTextField numeAnimalText;
    private JTextField specieAnimalText;
    private JTextField rasaAnimalText;
    private JTextField varstaAnimalText;
    private JButton adaugaAnimalButton;
    private JPanel mainPanel2;
    private JLabel numeAnimal;
    private JLabel specieAnimal;
    private JLabel varstaAnimal;
    private JLabel rasaAnimal;


    private AdaugareAnimal() {
        adaugaAnimalButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Animal animal = new Animal();
                animal.setNume(numeAnimalText.getText());
                animal.setSpecie(specieAnimalText.getText());
                animal.setRasa(rasaAnimalText.getText());
                animal.setVarsta(Integer.parseInt(varstaAnimalText.getText()));
                AdapostAnimale.getInstance().AdaugareAnimal(animal);
                AdapostAnimale.getInstance().getFrameAdaugare().setVisible(false);
                AdapostAnimale.getInstance().getFrame().setVisible(true);
            }
        });
    }

    public static AdaugareAnimal getInstance(){

        return Instance;
    }

    public JPanel getPanel(){

        return mainPanel2;
    }
}