using Firebase.Database;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LligaPingPong
{
    public partial class Main : Form
    {
        private Lliga lligaActual;
        private int indexPartitActual;
        private string idPartit;
        

        public Main()
        {
            InitializeComponent();
            lligaActual = new Lliga("Lliga1");
            lligaActual.getJugadors().Clear();
            lligaActual.getPartits().Clear();
            eliminarJugadors();
            eliminarPartits();
        }

        private void crear_jugador_click(object sender, EventArgs e)
        {
            String nom = inputNom.Text;
            String partits = inputPartits.Text;
            String punts = inputPunts.Text;
            int count = 0;
            int inserirPunts = Convert.ToInt32(punts);
            int inserirPartits = Convert.ToInt32(partits);

            inserir(nom, inserirPunts, inserirPartits);

            MessageBox.Show("Jugador creat!");
           
        }

        private void cargar_llista_click(object sender, EventArgs e)
        {
            obtenirJugador();
        }

        private void creaLliga()
        {
            int count = lligaActual.getJugadors().Count;
            int ultimJugador = 0;

            for (int i=0; i<count; i++)
            {
                for (ultimJugador = i; ultimJugador < count; ultimJugador++)
                {
                    if (lligaActual.getJugador(i) != lligaActual.getJugador(ultimJugador)) {

                        inserirPartit(lligaActual.getJugador(i).nom, lligaActual.getJugador(ultimJugador).nom,lligaActual.getJugador(i).idJugador, lligaActual.getJugador(ultimJugador).idJugador, 0, 0);

                    }
                }
            }
            
        }

        private async void eliminarPartits()
        {
            var firebase = new FirebaseClient("https://pingpongleague-398d0.firebaseio.com/");
            var child = firebase.Child("partits");
            await child.DeleteAsync();
        }

        private async void eliminarJugadors()
        {
            var firebase = new FirebaseClient("https://pingpongleague-398d0.firebaseio.com/");
            var child = firebase.Child("jugadors");
            await child.DeleteAsync();
        }

        private async Task obtenirPartits()
        {
            var firebase = new FirebaseClient("https://pingpongleague-398d0.firebaseio.com/");
            var partits = await firebase.Child("partits").OnceAsync<Partit>();

            foreach (var p1 in partits)
            {
                p1.Object.idPartit = p1.Key;
                string jugador1 = p1.Object.nJugador1;
                string jugador2 = p1.Object.nJugador2;
                string punts1 = p1.Object.punts1.ToString();
                string punts2 = p1.Object.punts2.ToString();

                ListViewItem listViewItem = new ListViewItem(jugador1);
                listViewItem.Name = p1.Object.idPartit;
                if (!lvPartits.Items.ContainsKey(listViewItem.Name))
                { 
                    listViewItem.SubItems.Add(jugador2);
                    listViewItem.SubItems.Add(punts1);
                    listViewItem.SubItems.Add(punts2);
                    listViewItem.SubItems.Add("");
                    listViewItem.SubItems.Add(p1.Object.idPartit);
                    lvPartits.Items.Add(listViewItem);
                }
            }
        }

        private void crear_lliga_click(object sender, EventArgs e)
        {
            creaLliga();
            MessageBox.Show("Lliga creada!");
        }

        private void veure_partits_click(object sender, EventArgs e)
        {
            obtenirPartits();
        }

        private async void canviar_resultat_click(object sender, EventArgs e)
        {
            var firebase = new FirebaseClient("https://pingpongleague-398d0.firebaseio.com/");
            var partits = firebase.Child("partits/" + idPartit);

            for (int i = 0; i < lligaActual.getPartits().Count; i++)
            {
                if (lligaActual.getPartits()[i].idPartit.Equals(idPartit))
                {
                    int inserirPunts1 = Convert.ToInt32(inputPunts1.Text);
                    int inserirPunts2 = Convert.ToInt32(inputPunts2.Text);
                    String id1 = lligaActual.getPartits()[i].idJugador1;
                    String id2 = lligaActual.getPartits()[i].idJugador2;
                    
                    lvPartits.Items[indexPartitActual].SubItems[2].Text = inputPunts1.Text;
                    lligaActual.getPartits()[i].punts1 = inserirPunts1;
                    lvPartits.Items[indexPartitActual].SubItems[3].Text = inputPunts2.Text;
                    lligaActual.getPartits()[i].punts2 = inserirPunts2;
                    String id = lligaActual.getPartits()[i].getGuanyador();

                    await partits.PutAsync(lligaActual.getPartit(i));

                    for (int j = 0; j < lligaActual.getJugadors().Count; j++)
                    {
                        if (id.Equals(lligaActual.getJugadors()[j].idJugador))
                        {
                            sumarPunts(firebase, j);
                        }
                        if (id1.Equals(lligaActual.getJugadors()[j].idJugador))
                        {
                            sumarPartits(firebase, j);
                        }
                        if (id2.Equals(lligaActual.getJugadors()[j].idJugador))
                        {
                            sumarPartits(firebase, j);
                        }
                    }
                    obtenirJugador();
                }
            }
        }

        private async void sumarPartits(FirebaseClient firebase,int i)
        {
            lligaActual.getJugador(i).nombrePartits++;
            var child1 = firebase.Child("jugadors/" + lligaActual.getJugador(i).idJugador);
            await child1.PutAsync(lligaActual.getJugador(i));
            for (int j = 0; j < lvJugadors.Items.Count; j++)
            {
                if (lvJugadors.Items[i].SubItems[3].Text.Equals(lligaActual.getJugador(i).idJugador))
                    lvJugadors.Items[i].SubItems[2].Text = lligaActual.getJugador(i).nombrePartits.ToString();
            }
        }

        private async void sumarPunts(FirebaseClient firebase, int i)
        {
            lligaActual.getJugador(i).punts = lligaActual.getJugador(i).punts + 3;
            var child2 = firebase.Child("jugadors/" + lligaActual.getJugador(i).idJugador);
            await child2.PutAsync(lligaActual.getJugador(i));
            for (int j = 0; j < lvJugadors.Items.Count; j++)
            {
                if (lvJugadors.Items[i].SubItems[3].Text.Equals(lligaActual.getJugador(i).idJugador))
                    lvJugadors.Items[i].SubItems[1].Text = lligaActual.getJugador(i).punts.ToString();
            }
        }

        private async void inserir(String nom, int punts, int nombrePartits)
        {
            var firebase = new FirebaseClient("https://pingpongleague-398d0.firebaseio.com/");
            var child = firebase.Child("jugadors");
            Jugador jugador = new Jugador(nom, punts, nombrePartits);
            var p1 = await child.PostAsync(jugador);
            jugador.idJugador = p1.Key;
            lligaActual.nouJugador(jugador);
            obtenirJugador();
        }

        private async void inserirPartit(String nomJugador1, String nomJugador2, String idJugador1, String idJugador2, int punts1, int punts2)
        {
            var firebase = new FirebaseClient("https://pingpongleague-398d0.firebaseio.com/");
            var child = firebase.Child("partits");

            Partit partit = new Partit(nomJugador1, nomJugador2, idJugador1, idJugador2, punts1, punts2);

            var p1 = await child.PostAsync(partit);
            partit.idPartit = p1.Key;
            lligaActual.nouPartit(partit);
        }

        private async Task obtenirJugador()
        {
            var firebase = new FirebaseClient("https://pingpongleague-398d0.firebaseio.com/");
            var jugadors = await firebase.Child("jugadors").OnceAsync<Jugador>();

            foreach (var p1 in jugadors)
            {
                p1.Object.idJugador = p1.Key;

                string punts = p1.Object.punts.ToString();
                string partits = p1.Object.nombrePartits.ToString();

                ListViewItem listViewItem = new ListViewItem(p1.Object.nom);
                listViewItem.Name = p1.Object.idJugador;
                if (!lvJugadors.Items.ContainsKey(listViewItem.Name))
                {
                    listViewItem.SubItems.Add(punts);
                    listViewItem.SubItems.Add(partits);
                    listViewItem.SubItems.Add(p1.Object.idJugador);
                    lvJugadors.Items.Add(listViewItem);
                }
            }
            obtenirJugador();
        }

        private void lvPartits_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPartits.SelectedItems.Count > 0)
            {
                indexPartitActual = this.lvPartits.SelectedIndices[0];
                string punts1 = lvPartits.Items[indexPartitActual].SubItems[2].Text;
                string punts2 = lvPartits.Items[indexPartitActual].SubItems[3].Text;
                idPartit = lvPartits.Items[indexPartitActual].SubItems[5].Text;
                inputPunts1.Text = punts1;
                inputPunts2.Text = punts2;
            }
        }
    } 
}

    
   

