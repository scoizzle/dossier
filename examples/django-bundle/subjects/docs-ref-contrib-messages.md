# docs/ref/contrib/messages

- Subject: docs/ref/contrib/messages (id `c34debf2-0663-4823-8122-ce2c3ca9bf91`)
- Kind: subject
- Budget: 1200 tokens
- Used: 897 tokens
- Facts shown: 22 of 135
- Conflicts: 0
- Gaps: 0

## Facts

- ``cleaned_data`` is the cleaned data from the form which is used for string formatting [7252ccb0]
- def get_success_message(self, cleaned_data): return self.success_message % dict( cleaned_data, calculated_field=self.object.calculated_field, ) [4a6661eb]
- # Change the messages level to ensure the debug message is added. messages.set_level(request, messages.DEBUG) messages.debug(request, "Test message...") [0502080e]
- # In another request, record only messages with a level of WARNING and higher messages.set_level(request, messages.WARNING) messages.success(request, "Your profile was updated.") # ignored messages.warning(request, "Your account is about to expire.") # recorded [c0d3b7fd]
- # Set the messages level back to default. messages.set_level(request, None) [d5ae2ec1]
- * ``extra_tags``: A string containing custom tags for this message, separated by spaces. It's empty by default. [6ddc2695]
- * ``level_tag``: The string representation of the level. By default, it's the lowercase version of the name of the associated constant, but this can be changed if you need by using the :setting:`MESSAGE_TAGS` setting. [b5acd0c1]
- * ``level``: An integer describing the type of the message (see the `message levels`_ section above). [eb310170]
- * ``message``: The actual text of the message. [1f8630ef]
- * ``tags``: A string combining all the message's tags (``extra_tags`` and ``level_tag``) separated by spaces. [a267f2cf]
- .. method:: get_success_message(cleaned_data) [cb44a3a8]
- Adds a success message attribute to :class:`~django.views.generic.edit.FormView` based classes [c587b1bf]
- Asserts that :mod:`~django.contrib.messages` added to the :class:`response <django.http.HttpResponse>` matches ``expected_messages``. [a02922e0]
- By default, the comparison is ordering dependent. You can disable this by setting the ``ordered`` argument to ``False``. [9120eb7a]
- CRITICAL = 50 [ccc3577c]
- MESSAGE_STORAGE = "django.contrib.messages.storage.cookie.CookieStorage" [cc2eae3b]
- MESSAGE_TAGS = { messages.INFO: "", 50: "critical", } [7c4527cb]
- This behavior avoids writing to the session whenever possible. It should provide the best performance in the general case. [e0abf479]
- This class first uses ``CookieStorage``, and falls back to using ``SessionStorage`` for the messages that could not fit in a single cookie. It also requires Django's ``contrib.sessions`` application. [ef3e6c25]
- This class stores all messages inside of the request's session. Therefore it requires Django's ``contrib.sessions`` application. [ef35362f]
- This class stores the message data in a cookie (signed with a secret hash to prevent manipulation) to persist notifications across requests. Old messages are dropped if the cookie data size would exceed 2048 bytes. [b66b1534]
- When you loop over the list of messages in a template, what you get are instances of the ``Message`` class. They have only a few attributes: [754665c4]

## Beyond the budget

108 more facts did not fit in the budget: [acad2ae0] [e352a3ec] [2af392b3] [ed9b8b60] [c6e8e47f] [3109678c] [c05c3ad0030e2165] [778e0c56] [e9e8791e] [11e88996] [2bc93803] [b04c3e11] [32643ad1] [5b91e56a] [a0256a77] [58f0d895] [3a81a022] [4d5067ac] [6bca971e] [0f7c8201] [fa0d2841] [f1f76455] [2c63d76e] [5979e6a9] [e2c44b6f] [6c19b140] [1732ea16a7d09411-5] [b8dc82cd] [8a9d6ce0] [8138e61b] [6e0729da] [168d319e] [fc5ebb84] [0bc756fa] [8796e2d0] [52805fe1] [dd828c7c] [aee7bc1a] [1f8cfe58] [b9304add] [685d15dfb6eb2285-67] [7e76e05a] [ddeff58a] [e75731a7] [c412d5f6] [0e1cd4a1] [9adac882] [6f64e0d9] [779ac034] [b9cdc8dc] [a3ac43f6] [1f1317f6] [f762aaa3] [fb922785] [8fb88880] [46141c55] [7b450901] [0b5caa99] [fb3387fe] [bcc20f78] [d025b12c] [62c31207] [f4e68d65] [98dc2a1c] [b1bdabcd] [1c098f41] [335ec519] [b8b0c6f8] [1829ffb5] [84ca861a] [653a620f] [abd8b9fa] [00883b83] [3e31d0b5] [edb43d65] [15dc51db] [59869c27] [f3b800f6] [7a20c1b2] [f37c94eb] [346ba7d5] [2cb321d8] [fecd7aa9] [1fa8b16c] [94005583b32250b8-4] [db504480] [1b197bd1] [768f41d4] [2a042191630e69fa-4] [106aca30] [fc39c4f3] [c4416fd5] [19c00e19] [164dc08a] [d9ade85b] [5c7146fe] [d6a2145e] [6c4b5e42] [01c623dd] [92603ce9] [b7974c91] [2c0cf640] [cd9acf24] [bdbd9205] [058f4656] [eb717561] [0d0291c9] [39f70186]
