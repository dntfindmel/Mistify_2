Album albumTwentyOnePilots = new Album();
albumTwentyOnePilots.Nome = "BlurryFace";

Music musica1 = new Music();
musica1.NomeMusica = "HeavyDirtySoul";
musica1.Duracao = 235;

Music musica2 = new Music();
musica2.NomeMusica = "Stressed Out";
musica2.Duracao = 203;

albumTwentyOnePilots.AdicionarMusica(musica1);
albumTwentyOnePilots.AdicionarMusica(musica2);

albumTwentyOnePilots.ExbirMusicasAlbum();

Banda twentyOnePilots = new Banda();
twentyOnePilots.Nome = "Twenty One Pilots";
twentyOnePilots.AdicionarAlbum(albumTwentyOnePilots);
twentyOnePilots.Discografia();