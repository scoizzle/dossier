# Fact 08d345ba

Store id: 4a7c93b9-70b2-460f-af68-f7f8f5853ec8

## Text

```text
def __xor__(self, other)
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
- posted_at: `2026-11-09T23:32:05.0567720+00:00`

## Data

```json
{
  "end_line": 94,
  "entity_kind": "method",
  "parent": "Q",
  "start_line": 93,
  "symbol": "Q.__xor__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/query_utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":93,"selector":"L93-L94","symbol":"Q.__xor__"}`

## Referenced by

None.

## Subject

[django/db/models/query_utils::Q.__xor__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 94,
    "entity_kind": "method",
    "parent": "Q",
    "start_line": 93,
    "symbol": "Q.__xor__"
  },
  "id": "4a7c93b9-70b2-460f-af68-f7f8f5853ec8",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.0567720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 93,
        "selector": "L93-L94",
        "symbol": "Q.__xor__"
      },
      "rel": "derived_from",
      "target": "django/db/models/query_utils.py"
    }
  ],
  "status": "live",
  "subject_id": "1422058a-682e-4750-ac0b-4687a2558076",
  "subject_name": "django/db/models/query_utils::Q.__xor__",
  "tags": [
    "entity:method"
  ],
  "text": "def __xor__(self, other)"
}
```
