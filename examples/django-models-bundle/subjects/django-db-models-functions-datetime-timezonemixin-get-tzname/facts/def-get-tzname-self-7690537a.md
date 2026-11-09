# Fact 7690537a

Store id: a7996966-58ea-4291-ab9f-a2c8231ca3cf

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
- posted_at: `2026-11-09T22:39:46.1018420+00:00`

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
  "id": "a7996966-58ea-4291-ab9f-a2c8231ca3cf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.1018420+00:00"
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
  "subject_id": "31ff00e1-632a-4b83-a788-65c6936b2794",
  "subject_name": "django/db/models/functions/datetime::TimezoneMixin.get_tzname",
  "tags": [
    "entity:method"
  ],
  "text": "def get_tzname(self)"
}
```
