import Client.Client;
import javax.swing.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
public class AdaugareClient {
    private static AdaugareClient Instance = new AdaugareClient();
    private JPanel mainPanel3;
    private JLabel Nume;
    private JLabel Telefon;
    private JLabel Adresa;
    private JTextField numeText;
    private JTextField telefonText;
    private JTextField AdresaText;
    private JButton salvatiButton;



    private AdaugareClient() {
        salvatiButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                Client client = new Client();
                client.setNumeClienti(numeText.getText());
                client.setTelefon(telefonText.getText());
                client.setAdresa(AdresaText.getText());
                AdapostAnimale.getInstance().AdaugareClient(client);
                AdapostAnimale.getInstance().getFrameAdaugare().setVisible(false);
                AdapostAnimale.getInstance().getFrame().setVisible(true);
            }
        });
    }

    public static AdaugareClient getInstance(){

        return Instance;
    }

    public JPanel getPanel(){

        return mainPanel3;
    }
}