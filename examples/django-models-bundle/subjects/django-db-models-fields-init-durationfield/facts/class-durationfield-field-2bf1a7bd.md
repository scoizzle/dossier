# Fact 2bf1a7bd

Store id: d619d4f5-8897-462f-af4c-a6bb11d8d918

## Text

```text
class DurationField(Field)
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
- posted_at: `2026-11-09T23:44:50.1269830+00:00`

## Data

```json
{
  "end_line": 1994,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 1936,
  "symbol": "DurationField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1936,"selector":"L1936-L1994","symbol":"DurationField"}`

## Items

```json
[
  {
    "text": "Store timedelta objects.",
    "locator": {
      "line": 1937
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::DurationField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1994,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 1936,
    "symbol": "DurationField"
  },
  "id": "d619d4f5-8897-462f-af4c-a6bb11d8d918",
  "items": [
    {
      "locator": {
        "line": 1937
      },
      "text": "Store timedelta objects."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1269830+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1936,
        "selector": "L1936-L1994",
        "symbol": "DurationField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "d6b01c6c-d1b4-4748-8499-fad34125a060",
  "subject_name": "django/db/models/fields/__init__::DurationField",
  "tags": [
    "entity:class"
  ],
  "text": "class DurationField(Field)"
}
```
