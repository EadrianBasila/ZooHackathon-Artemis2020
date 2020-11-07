#hi
#testing connection
from selenium.webdriver.common.keys import Keys
from msedge.selenium_tools import Edge, EdgeOptions

options = EdgeOptions()
options.use_chromium = True
driver = Edge(options=options)

# navigate to login screen
driver.get('https://www.facebook.com/login')
driver.maximize_window()

#login account
email = driver.find_element_by_name('email').send_keys('artemis11620@gmail.com')
password = driver.find_element_by_name('pass').send_keys('@rtemiS1120', Keys.RETURN)

<<<<<<< HEAD
=======
# find search input and search for term
search_input = driver.find_element_by_xpath('//input[@dir="ltr"]')
search_input.send_keys('Pangolin for sale', Keys.RETURN)
>>>>>>> ce1c05f8ecc06e785b416c4c12f59ad6d8e11785
