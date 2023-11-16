Episodio ep1 = new(1, "Como conviver com uma mente agitada", 10);
ep1.AdicionarConvidado("Melyssa");
ep1.AdicionarConvidado("Nathalie");


Episodio ep2 = new(2, "Lidando com a pressão da perfeição", 15);
ep2.AdicionarConvidado("Daniel");
ep2.AdicionarConvidado("Milene");

Podcast podcast = new Podcast("Lidando com frustrações", "Sophia");
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep1);
podcast.ExibirDetalhes();