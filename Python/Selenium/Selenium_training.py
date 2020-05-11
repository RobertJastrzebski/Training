from selenium import webdriver
import os

class Chrome():

    url= "https://letskodeit.teachable.com/pages/practice"
    driverlocation = "E:\\2. Tester manualny\\Gitgub Repository\\Python\\Selenium\\Chromedriver.exe"
    os.environ["webdriver.chrome.driver"] = driverlocation
    driver = webdriver.Chrome(driverlocation)

    def test(self):

        Chrome.driver.get(self.url)

    def find_by_id(self):
        Chrome.driver.get(Chrome.url)
        elementById= Chrome.driver.find_element_by_id("name")
        if elementById is not None:
            print("znalezione")


chromerun = Chrome()
# chromerun.test()
chromerun.find_by_id()
