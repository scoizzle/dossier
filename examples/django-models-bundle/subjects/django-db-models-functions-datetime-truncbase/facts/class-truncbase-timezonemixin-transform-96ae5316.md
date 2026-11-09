# Fact 96ae5316

Store id: cca92507-18ce-4e72-a28a-a57376ef02c1

## Text

```text
class TruncBase(TimezoneMixin, Transform)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:01.2496030+00:00`

## Data

```json
{
  "end_line": 345,
  "entity_kind": "class",
  "parent": "datetime",
  "start_line": 244,
  "symbol": "TruncBase"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/datetime.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":244,"selector":"L244-L345","symbol":"TruncBase"}`

## Referenced by

None.

## Subject

[django/db/models/functions/datetime::TruncBase](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 345,
    "entity_kind": "class",
    "parent": "datetime",
    "start_line": 244,
    "symbol": "TruncBase"
  },
  "id": "cca92507-18ce-4e72-a28a-a57376ef02c1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.2496030+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 244,
        "selector": "L244-L345",
        "symbol": "TruncBase"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/datetime.py"
    }
  ],
  "status": "live",
  "subject_id": "7af9c79c-2317-4083-a115-13b4ba722bb5",
  "subject_name": "django/db/models/functions/datetime::TruncBase",
  "tags": [
    "entity:class"
  ],
  "text": "class TruncBase(TimezoneMixin, Transform)"
}
```
