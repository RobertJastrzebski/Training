import time
import os
class ScreenShot():

    def __init__(self,driver):
        self.driver =driver

    def screenShot(self):
        """
        Takes screenshot
        """
        filename= str(round(time.time()*1000))+".png"
        screenshotDirectory= "Selenium\project_1\screenshots"
        relativePath= screenshotDirectory+filename
        self.driver.save_screenshots(relativePath)
        print("Screenshot save to directory: " + relativePath)


