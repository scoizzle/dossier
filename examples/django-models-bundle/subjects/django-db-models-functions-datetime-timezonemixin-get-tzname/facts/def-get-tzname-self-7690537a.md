# Fact 7690537a

Store id: e343d62f-3e63-47ac-a29e-f1722e68482c

## Text

```text
def get_tzname(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:01.1678940+00:00`

## Data

```json
{
  "end_line": 36,
  "entity_kind": "method",
  "parent": "TimezoneMixin",
  "start_line": 25,
  "symbol": "TimezoneMixin.get_tzname"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":25,"selector":"L25-L36","symbol":"TimezoneMixin.get_tzname"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TimezoneMixin.get_tzname](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 36,
    "entity_kind": "method",
    "parent": "TimezoneMixin",
    "start_line": 25,
    "symbol": "TimezoneMixin.get_tzname"
  },
  "id": "e343d62f-3e63-47ac-a29e-f1722e68482c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.1678940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 25,
        "selector": "L25-L36",
        "symbol": "TimezoneMixin.get_tzname"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "4e6a9f0f-8194-4266-b437-3fb7bef0512f",
  "subject_name": "django/db/models/functions/datetime::TimezoneMixin.get_tzname",
  "tags": [
    "entity:method"
  ],
  "text": "def get_tzname(self)"
}
```
