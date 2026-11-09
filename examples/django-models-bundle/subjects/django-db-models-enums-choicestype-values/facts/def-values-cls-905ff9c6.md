# Fact 905ff9c6

Store id: 626c97f8-086c-429e-ab63-0cc1d5e09d8a

## Text

```text
def values(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.0445550+00:00`

## Data

```json
{
  "end_line": 51,
  "entity_kind": "method",
  "parent": "ChoicesType",
  "start_line": 49,
  "symbol": "ChoicesType.values"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":49,"selector":"L49-L51","symbol":"ChoicesType.values"}`

## Referenced by

None.

## Subject

[django/db/models/enums::ChoicesType.values](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 51,
    "entity_kind": "method",
    "parent": "ChoicesType",
    "start_line": 49,
    "symbol": "ChoicesType.values"
  },
  "id": "626c97f8-086c-429e-ab63-0cc1d5e09d8a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.0445550+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 49,
        "selector": "L49-L51",
        "symbol": "ChoicesType.values"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "d42e7670-f67f-4f2f-bda8-9ff71351a74f",
  "subject_name": "django/db/models/enums::ChoicesType.values",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def values(cls)"
}
```
