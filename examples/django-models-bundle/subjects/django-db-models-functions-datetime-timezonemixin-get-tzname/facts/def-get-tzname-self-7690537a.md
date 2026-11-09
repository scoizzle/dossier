# Fact 7690537a

Store id: d1e64ef0-17a8-46da-bfc9-a45346b64b81

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
- posted_at: `2026-11-09T23:44:53.3161220+00:00`

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
  "id": "d1e64ef0-17a8-46da-bfc9-a45346b64b81",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.3161220+00:00"
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
  "subject_id": "1a93abc7-e52f-48dc-a9b3-bd7a12c89dba",
  "subject_name": "django/db/models/functions/datetime::TimezoneMixin.get_tzname",
  "tags": [
    "entity:method"
  ],
  "text": "def get_tzname(self)"
}
```
