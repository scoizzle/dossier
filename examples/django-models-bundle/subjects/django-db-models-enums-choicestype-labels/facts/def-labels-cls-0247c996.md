# Fact 0247c996

Store id: 55ac0ef9-6049-4346-a784-92da434bf494

## Text

```text
def labels(cls)
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
- posted_at: `2026-11-09T23:31:55.5014880+00:00`

## Data

```json
{
  "end_line": 47,
  "entity_kind": "method",
  "parent": "ChoicesType",
  "start_line": 45,
  "symbol": "ChoicesType.labels"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/enums.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":45,"selector":"L45-L47","symbol":"ChoicesType.labels"}`

## Referenced by

None.

## Subject

[django/db/models/enums::ChoicesType.labels](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 47,
    "entity_kind": "method",
    "parent": "ChoicesType",
    "start_line": 45,
    "symbol": "ChoicesType.labels"
  },
  "id": "55ac0ef9-6049-4346-a784-92da434bf494",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.5014880+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 45,
        "selector": "L45-L47",
        "symbol": "ChoicesType.labels"
      },
      "rel": "derived_from",
      "target": "django/db/models/enums.py"
    }
  ],
  "status": "live",
  "subject_id": "ff46c671-ff5b-4a35-ad87-ee2ab01d0a6b",
  "subject_name": "django/db/models/enums::ChoicesType.labels",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def labels(cls)"
}
```
