# django/__main__

- Subject: django/__main__ (id `1174cbcf-2efa-48b6-8e59-0ed54470c9f5`)
- Kind: subject
- Budget: 1200 tokens
- Used: 94 tokens
- Facts shown: 4 of 4
- Conflicts: 0
- Gaps: 0

## Facts

- """ Invokes django-admin when the django module is run as a script. [40629598]
- Example: python -m django check """ [a02637a2]
- from django.core import management [7429fcd5]
- if __name__ == "__main__": management.execute_from_command_line() [a77945e1]
