# Fact 0247c996

Store id: 9a59426b-c3dd-4aab-8971-e5eb528d060a

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
- posted_at: `2026-11-09T22:39:41.3024910+00:00`

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
  "id": "9a59426b-c3dd-4aab-8971-e5eb528d060a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.3024910+00:00"
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
  "subject_id": "dc1ffa5d-6863-4c30-a9a8-b14cb9176faf",
  "subject_name": "django/db/models/enums::ChoicesType.labels",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def labels(cls)"
}
```
