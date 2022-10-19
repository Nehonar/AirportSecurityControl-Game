using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FlightsPanel : MonoBehaviour
{   
    // Data panel flights
    public TextMeshProUGUI flight1Time;
    public TextMeshProUGUI flight1Destination;
    public TextMeshProUGUI flight1State;
    public TextMeshProUGUI flight2Time;
    public TextMeshProUGUI flight2Destination;
    public TextMeshProUGUI flight2State;
    public TextMeshProUGUI flight3Time;
    public TextMeshProUGUI flight3Destination;
    public TextMeshProUGUI flight3State;
    public TextMeshProUGUI flight4Time;
    public TextMeshProUGUI flight4Destination;
    public TextMeshProUGUI flight4State;

    // Data
    public List<string> countries = new List<string>() {
        "United States", "Canada", "Afghanistan", "Albania", "Algeria", "American Samoa", 
        "Andorra", "Angola", "Anguilla", "Antarctica", "Argentina", "Armenia", "Aruba", 
        "Australia", "Austria", "Azerbaijan", "Bahamas", "Bahrain", "Bangladesh", "Barbados", 
        "Belarus", "Belgium", "Belize", "Benin", "Bermuda", "Bhutan", "Bolivia", 
        "Bosnia and Herzegovina", "Bouvet Island", "Brazil", "Bulgaria", "Burkina Faso", 
        "Cameroon", "Cape Verde", "Cayman Islands", "Central African Republic", "Chile", 
        "China", "Christmas Island", "Cocos Islands", "Colombia", "Comoros", "Congo", 
        "Cook Islands", "Costa Rica", "Croatia", "Cuba", "Cyprus", "Czech Republic", "Denmark", 
        "Dominica", "Dominican Republic", "East Timor", "Ecudaor", "Egypt", "El Salvador", 
        "Equatorial Guinea", "Eritrea", "Estonia", "Ethiopia", "Falkland Islands", "Fiji", 
        "Finland", "France", "French Guiana", "French Polynesia", "Gabon", "Gambia", 
        "Georgia", "Germany", "Ghana", "Gibraltar", "Greece", "Greenland", 
        "Grenada", "Guadeloupe", "Guam", "Guatemala", "Guinea", "Guinea-Bissau", "Guyana", 
        "Haiti", "Honduras", "Hong Kong", "Hungary", "Iceland", "India", "Indonesia", "Iran", 
        "Iraq", "Ireland", "Israel", "Italy", "Ivory Coast", "Jamaica", "Japan", "Jordan", 
        "Kazakhstan", "Kenya", "Kiribati", "Korea", "Kosovo", "Kuwait", "Kyrgyzstan", "Lebanon", 
        "Lesotho", "Liberia", "Libyan Arab Jamahiriya", "Liechtenstein", "Lithuania", 
        "Luxembourg", "Macau", "Macedonia", "Madagascar", "Malawi", "Malaysia", "Maldives", 
        "Mali", "Malta", "Marshall Islands", "Martinique", "Mauritania", "Mauritius", "Mayotte", 
        "Mexico", "Micronesia", "Moldova, Republic of", "Monaco", "Mongolia", 
        "Montserrat", "Morocco", "Mozambique", "Myanmar", "Namibia", "Nauru", "Nepal", 
        "Netherlands", "Netherlands Antilles", "New Caledonia", "New Zealand", "Nicaragua", 
        "Niger", "Nigeria", "Niue", "Norfork Island", "Northern Mariana Islands", "Norway", "Oman", 
        "Pakistan", "Palau", "Panama", "Papua New Guinea", "Paraguay", "Peru", "Philippines", 
        "Pitcairn", "Poland", "Portugal", "Puerto Rico", "Qatar", "Reunion", "Romania", 
        "Russian Federation", "Rwanda", "Saint Kitts and Nevis", "Saint Lucia", "Samoa", "San Marino", 
        "Sao Tome and Principe", "Saudi Arabia", "Senegal", "Seychelles", "Sierra Leone", 
        "Singapore", "Slovakia", "Slovenia", "Solomon Islands", "Somalia", "South Africa", 
        "South Sudan", "Spain", "Sri Lanka", "St. Helena", "St. Pierre and Miquelon", "Sudan", 
        "Suriname", "Swaziland", "Sweden", "Switzerland", "Syrian Arab Republic", "Taiwan", 
        "Tajikistan", "Tanzania", "Thailand", "Togo", "Tokelau", "Tonga", "Trinidad and Tobago", 
        "Tunisia", "Turkey", "Turkmenistan", "Turks and Caicos Islands", "Tuvalu", "Uganda", 
        "Ukraine", "United Arab Emirates", "United Kingdom", "Uruguay", "Uzbekistan", "Vanuatu", 
        "Vatican City State", "Venezuela", "Vietnam", "Virigan Islands", "Virgin Islands", 
        "Western Sahara", "Yemen", "Yugoslavia", "Zaire", "Zambia", "Zimbabwe"
    };
    public List<string> minutes = new List<string>(){
        "00", "15", "30", "45"
    };
    public int probability = 5;
    public bool flight1 = true;
    public bool flight2 = true;
    public bool flight3 = true;
    public bool flight4 = true;

    // Start is called before the first frame update
    void Start()
    {
        createFlights();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // create panel flights data
    public void createFlights(){
        var dateTime = System.DateTime.Now;

        // Flight 1 data
        flight1 = (UnityEngine.Random.Range(0, 100) <= probability) ? false : true; 
        flight1State.text = flight1 ? "on time" : "cancelled";
        flight1Time.text = flight1 ? randomTime() : "--:--";
        flight1Destination.text = countries[UnityEngine.Random.Range(0, countries.Count)];

        // Flight 2 data
        flight2 = (UnityEngine.Random.Range(0, 100) <= probability) ? false : true;
        flight2State.text = flight2 ? "on time" : "cancelled";
        flight2Time.text = flight2 ? randomTime() : "--:--";
        flight2Destination.text = countries[UnityEngine.Random.Range(0, countries.Count)];

        // Flight 3 data
        flight3 = (UnityEngine.Random.Range(0, 100) <= probability) ? false : true;
        flight3State.text = flight3 ? "on time" : "cancelled";
        flight3Time.text = flight3 ? randomTime() : "--:--";
        flight3Destination.text = countries[UnityEngine.Random.Range(0, countries.Count)];

        // Flight 4 data
        flight4 = (UnityEngine.Random.Range(0, 100) <= probability) ? false : true;
        flight4State.text = flight4 ? "on time" : "cancelled";
        flight4Time.text = flight4 ? randomTime() : "--:--";
        flight4Destination.text = countries[UnityEngine.Random.Range(0, countries.Count)];
    }

    public string randomTime(){
        var dateTime = System.DateTime.Now;

        string minute = minutes[UnityEngine.Random.Range(0, 3)];
        string newTime = dateTime.AddHours(UnityEngine.Random.Range(1, 4)).ToString("HH") + ":" + minute;
        
        return newTime;
    }

}
