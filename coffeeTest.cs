//scripting in unity: if conditions in c#
using UnityEngine;
using System.Collections;

public class CoffeeTester : MonoBehavior
{
    float coffeeTemp = 85.0f;
    float maxTemp = 70.f;
    float minTemp = 40.f;
    
    void Update()
    {
      if(Input.GetKeyDown(KeyCode.Space))
        TemperatureTest();
      
      coffeeTemp -= Time.deltaTime * 5f;
    }
    
    void TemperatureTest()
    {
      if(coffeeTemp > maxTemp)
      {
        print("Coffee is too hot");
      }
      else if(coffeeTemp < minTemp)
      {
        print("Coffee is too cold"); 
      }
      else
      {
        print("Coffee is just right.");
      }
    }
}
