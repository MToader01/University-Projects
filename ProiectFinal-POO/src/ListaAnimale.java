import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;

public class ListaAnimale {
    private static ListaAnimale Instance = new ListaAnimale();
    private JPanel animalPanel;
    private JList listaAnimale;
    private JButton backButton1;


    private ListaAnimale() {
        backButton1.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                AdapostAnimale.getInstance().getFrameLista().setVisible(false);
                AdapostAnimale.getInstance().getFrame().setVisible(true);
            }
        });
    }

    public JPanel getPanel()
    {
        return this.animalPanel;
    }

    public void setListaAnimale(ArrayList<String> Angajati)
    {
        this.listaAnimale.setListData(Angajati.toArray());
    }

    public static ListaAnimale getInstanceAnimal(){
        return Instance;
    }
}