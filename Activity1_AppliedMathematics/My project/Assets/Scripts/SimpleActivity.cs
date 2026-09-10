using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class SimpleActivity : MonoBehaviour {
    public Transform[] noGoZones; public Transform finish;
    public GameObject winPanel; public float speed = 5, warning = 2, danger = 1, maxTime = 2;
    float timer;
    void Update() {
        if (winPanel.activeSelf) return;
        var k = Keyboard.current;
        Vector3 input = new(k.dKey.isPressed.CompareTo(k.aKey.isPressed), 0, k.wKey.isPressed.CompareTo(k.sKey.isPressed));
        transform.position += input.normalized * speed * Time.deltaTime;
        bool near = false;
        foreach (Transform zone in noGoZones)
        {
            float distance = (transform.position - zone.position).magnitude;
            bool warned = distance < warning;
            near |= warned;
            zone.localRotation = Quaternion.Euler(0, 0, warned ? Mathf.Sin(Time.time * 30) * 10 : 0);
            zone.GetComponent<Renderer>().material.color = warned ? Color.red : Color.yellow;
            if (distance < danger) Restart();
        }
        timer = near ? timer + Time.deltaTime : 0;
        if (timer > maxTime) Restart();
        if ((transform.position - finish.position).magnitude < 1.5f) winPanel.SetActive(true);
    }
    void Restart() => SceneManager.LoadScene(SceneManager.GetActiveScene().name);
}
