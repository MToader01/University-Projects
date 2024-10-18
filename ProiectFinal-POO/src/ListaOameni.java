import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.util.ArrayList;

public class ListaOameni {
    private static ListaOameni Instance = new ListaOameni();
    private JPanel mainPanel5;
    private JList list2;
    private JButton backButton2;


    private ListaOameni() {
        backButton2.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                AdapostAnimale.getInstance().getFrameLista().setVisible(false);
                AdapostAnimale.getInstance().getFrame().setVisible(true);
            }
        });
    }

    public JPanel getPanel()
    {
        return this.mainPanel5;
    }

    public void setList(ArrayList<String> Clienti)
    {

        this.list2.setListData(Clienti.toArray());
    }

    public static ListaOameni getInstance(){

        return Instance;
    }
}