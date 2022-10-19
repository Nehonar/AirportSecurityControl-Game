using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class boardingpassPassport : MonoBehaviour
{   
    public FlightsPanel flightPanel;

    // Data date and time
    public TextMeshProUGUI realTime;
    public TextMeshProUGUI realDate;

    // Boarding pass and passport
    public TextMeshProUGUI nationality;
    public TextMeshProUGUI dateOfBirth;
    public TextMeshProUGUI dateOfExpiration;
    public TextMeshProUGUI destination;
    public TextMeshProUGUI date;
    public TextMeshProUGUI hour;

    // stats TODO pasar al menu del juego
    public List<string> minutes = new List<string>() {
        "00", "15", "30", "45"
    };
    public int probability = 5;
    public bool passengerState = true;

    // Start is called before the first frame update
    void Start()
    {
        // create data to boarding pass and passport
        createDataTicketPass();
    }

    // Update is called once per frame
    void Update()
    {
        realTime.text = System.DateTime.Now.ToString("HH:mm:ss");
        realDate.text = System.DateTime.Now.ToString("dd/MM/yyyy");
    }

    // Create data for a ticket and passport
    public void createDataTicketPass() {
        int dataRandomFlight = UnityEngine.Random.Range(0, 3);
        
        nationality.text = nationality.text + getRandomCountry();
        dateOfBirth.text = dateOfBirth.text + calculateDateOfBirth();
        dateOfExpiration.text = dateOfExpiration.text + calculateDateOfExpiration();
        generateBoarding(dataRandomFlight);
    }

    // Get random country
    public string getRandomCountry(){
        int randomPotluck = UnityEngine.Random.Range(1, 100);

        if(randomPotluck <= probability){
            return flightPanel.countries[UnityEngine.Random.Range(0, 4)];
        }
        else{
            return flightPanel.countries[UnityEngine.Random.Range(0, 4)];
        }
    }

    // Calculate a random birthday
    public string calculateDateOfBirth(){
        var dateTime = System.DateTime.Now;
        int randomAges = UnityEngine.Random.Range(-34675, -6570);

        return dateTime.AddDays(randomAges).ToString("dd/MM/yyyy");
    }

    // Calculate a date of passport expiration
    public string calculateDateOfExpiration(){
        var dateTime = System.DateTime.Now;
        int randomRange = UnityEngine.Random.Range(1, 100);

        if (randomRange <= probability) {
            return dateTime.AddDays(UnityEngine.Random.Range(-100, 1)).ToString("dd/MM/yyyy");
        }
        else {
            return dateTime.AddDays(UnityEngine.Random.Range(0, 1500)).ToString("dd/MM/yyyy");
        }
    }

    public void generateBoarding(int randomFlight){
        if(randomFlight == 0){
            destination.text = destination.text + flightPanel.flight1Destination.text;
            hour.text = hour.text + flightPanel.flight1Time.text;
            date.text = date.text + calculateDate();
            passengerState = flightPanel.flight1;
        }
        else if(randomFlight == 1){
            destination.text = destination.text + flightPanel.flight2Destination.text;
            hour.text = hour.text + flightPanel.flight2Time.text;
            date.text = date.text + calculateDate();
            passengerState = flightPanel.flight2;
        }
        else if(randomFlight == 2){
            destination.text = destination.text + flightPanel.flight3Destination.text;
            hour.text = hour.text + flightPanel.flight3Time.text;
            date.text = date.text + calculateDate();
            passengerState = flightPanel.flight3;
        }
        else if (randomFlight == 3){
            destination.text = destination.text + flightPanel.flight4Destination.text;
            hour.text = hour.text + flightPanel.flight4Time.text;
            date.text = date.text + calculateDate();
            passengerState = flightPanel.flight4;
        }
    }

    // calculate date to flight 
    public string calculateDate(){
        var dateTime = System.DateTime.Now;

        if(UnityEngine.Random.Range(0, 100) <= probability){
            passengerState = false;
            return dateTime.AddDays(UnityEngine.Random.Range(-1, -5)).ToString("dd/MM/yyyy");
        }
        else{
            return dateTime.ToString("dd/MM/yyyy");
        }
    }

    // calculate hour and minute flight
    public string calculateHour(){
        var dateTime = System.DateTime.Now;
        var index = UnityEngine.Random.Range(0, 3);
        int randomHourFlight = UnityEngine.Random.Range(1, 100);
        string minute = minutes[index];

        // random spown person with lost flight
        // TODO 5 is a random passenger or difficult
        if (randomHourFlight <= probability) {
            dateTime.AddHours(UnityEngine.Random.Range(-1, -5));
            return dateTime.Hour.ToString("HH") + ":" + minute;
        }
        else {
            dateTime.AddHours(UnityEngine.Random.Range(0, 4));
            return dateTime.Hour.ToString("HH") + ":" + minute;
        }
    }

    public void returnAirport(){
        Destroy(gameObject, 1.0f);
    }
}
