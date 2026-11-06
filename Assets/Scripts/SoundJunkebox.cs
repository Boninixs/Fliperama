using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundJunkebox : MonoBehaviour
{
     [Header("Músicas")]
    public AudioClip[] musicas;
    public bool tocarAoIniciar = false;
    public bool tocarProximaAutomaticamente = true;
 
    [Header("Interação")]
    public Transform jogador;           
    public float distanciaInteracao = 3f;
    public KeyCode teclaTocarPausar = KeyCode.E;
    public KeyCode teclaProxima = KeyCode.Q;
 
    [Header("Efeito visual (opcional)")]
    public Light luzJukebox;            
    public Color[] coresLuz = { Color.magenta, Color.cyan, Color.yellow, Color.red };
 
    private AudioSource audioSource;
    private int indiceAtual = 0;
    private bool pausado = false;
 
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null) audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.loop = false;
        audioSource.spatialBlend = 1f;     
        audioSource.minDistance = 2f;
        audioSource.maxDistance = 20f;
 
        if (tocarAoIniciar) Tocar(indiceAtual);
    }

   void Update()
    {
        if (musicas == null || musicas.Length == 0) return;
 
        bool perto = jogador == null ||
                     Vector3.Distance(jogador.position, transform.position) <= distanciaInteracao;
 
        if (perto && Input.GetKeyDown(teclaTocarPausar)) TocarOuPausar();
        if (perto && Input.GetKeyDown(teclaProxima)) Proxima();
 
        // terminou a música -> toca a próxima
        if (tocarProximaAutomaticamente && !pausado && !audioSource.isPlaying && audioSource.clip != null
            && audioSource.time == 0f)
        {
            Proxima();
        }
 
        AtualizarLuz();
    }
 
    void Tocar(int indice)
    {
        indiceAtual = indice;
        audioSource.clip = musicas[indiceAtual];
        audioSource.Play();
        pausado = false;
    }
 
    public void TocarOuPausar()
    {
        if (audioSource.clip == null) { Tocar(indiceAtual); return; }
 
        if (audioSource.isPlaying) { audioSource.Pause(); pausado = true; }
        else { audioSource.UnPause(); pausado = false; }
    }
 
    public void Proxima()
    {
        Tocar((indiceAtual + 1) % musicas.Length);
    }
 
    void AtualizarLuz()
    {
        if (luzJukebox == null) return;
        luzJukebox.enabled = audioSource.isPlaying;
        if (!audioSource.isPlaying || coresLuz.Length == 0) return;
 
        float t = Time.time * 0.5f;
        int a = Mathf.FloorToInt(t) % coresLuz.Length;
        int b = (a + 1) % coresLuz.Length;
        luzJukebox.color = Color.Lerp(coresLuz[a], coresLuz[b], t - Mathf.Floor(t));
        luzJukebox.intensity = 1.5f + Mathf.Sin(Time.time * 6f) * 0.5f;
    }

    void OnMouseDown()
    {
        TocarOuPausar();
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, distanciaInteracao);
    }
}
