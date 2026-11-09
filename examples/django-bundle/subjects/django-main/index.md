# django/__main__

- Subject: django/__main__ (id `3eb99b15-fd87-4e15-8a87-9633c2f661bc`)
- Kind: subject
- Budget: 1200 tokens (highlight threshold; every fact is listed)
- Used: 94 tokens
- Facts shown: 4 facts
- Conflicts: 0
- Gaps: 0

## Facts

- """ Invokes django-admin when the django module is run as a script. [40629598]
- Example: python -m django check """ [a02637a2]
- from django.core import management [7429fcd5]
- if __name__ == "__main__": management.execute_from_command_line() [a77945e1]
