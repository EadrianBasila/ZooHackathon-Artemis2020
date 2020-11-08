import re
import csv
from time import sleep
from selenium.webdriver.common.keys import Keys
from selenium.common.exceptions import NoSuchElementException
from msedge.selenium_tools import Edge, EdgeOptions

def get_facebook_data(card):
    Name = card.find_element_by_xpath('.//span').text
    try:
        posteddate = card.find_element_by_xpath('.//span').get_attribute('d2edcug0 hpfvmrgz qv66sw1b c1et5uql rrkovp55 jq4qci2q a3bd9o3v knj5qynh m9osqain')
    except NoSuchElementException:
        return
    
    text = card.find_element_by_xpath('.//div[2]/div[2]/div[1]').text
    attachment = card.find_element_by_xpath('.//div[2]/div[2]/div[2]').text
    content = text + attachment

    post = (Name, posteddate, content)
    return post

options = EdgeOptions()
options.use_chromium = True
driver = Edge(options=options)

# navigate to login screen
driver.get('https://www.facebook.com/login')
driver.maximize_window()

#login account
email = driver.find_element_by_name('email').send_keys('artemis11620@gmail.com')
password = driver.find_element_by_name('pass').send_keys('@rtemiS1120', Keys.RETURN)

# find search input and search for term
search_input = driver.find_element_by_xpath('//input[@dir="ltr"]')
search_input.send_keys('Pangolin for sale', Keys.RETURN)

data = []
post_ids = set()
last_position = driver.execute_script("return window.pageYOffset;")
scrolling = True

#tested code from twitter scraper
while scrolling:
    page_cards = driver.find_elements_by_xpath('//div[@data-testid="tweet"]')
    for card in page_cards[-15:]:
        post = get_facebook_data(card)
        if post:
            post_id = ''.join(post)
            if post_id not in post_ids:
                post_ids.add(post_id)
                data.append(post)
            
    scroll_attempt = 0
    while True:
        # check scroll position
        driver.execute_script('window.scrollTo(0, document.body.scrollHeight);')
        sleep(1)
        curr_position = driver.execute_script("return window.pageYOffset;")
        if last_position == curr_position:
            scroll_attempt += 1
            
            # end of scroll region
            if scroll_attempt >= 3:
                scrolling = False
                break
            else:
                sleep(1) # attempt another scroll
        else:
            last_position = curr_position
            break

# close the web driver
driver.close()

with open('data_fbpost.csv', 'w', newline='', encoding='utf-8') as f:
    header = ['Name', 'Timestamp', 'Content']
    writer = csv.writer(f)
    writer.writerow(header)
    writer.writerows(data)