Episodio ep1 = new(1, "O MAIOR RAPPER BRASILHEIRO ", 85);
ep1.AddConvidados("DJONGA");

Episodio ep2 = new(2, "Um dos maiores humoristas ", 235);
ep2.AddConvidados("Marucio Meireles");

Episodio ep3 = new(3, "Médicina moderna", 655);
ep3.AddConvidados("Drauzio Varella");

Podcast podcast = new("PODPAH", "Igão e Mitico");
podcast.Addeps(ep1);
podcast.Addeps(ep2);
podcast.Addeps(ep3);
podcast.ExibirDetalhes();