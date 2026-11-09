# Fact c2d855b6

Store id: 0260ae6a-a998-4686-aeeb-c4f2a1ef368d

## Text

```text
class PositionRef(Ref)
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
- posted_at: `2026-11-09T23:32:05.6288360+00:00`

## Data

```json
{
  "end_line": 39,
  "entity_kind": "class",
  "parent": "compiler",
  "start_line": 33,
  "symbol": "PositionRef"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":33,"selector":"L33-L39","symbol":"PositionRef"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::PositionRef](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 39,
    "entity_kind": "class",
    "parent": "compiler",
    "start_line": 33,
    "symbol": "PositionRef"
  },
  "id": "0260ae6a-a998-4686-aeeb-c4f2a1ef368d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.6288360+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 33,
        "selector": "L33-L39",
        "symbol": "PositionRef"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "5585daa6-dd6d-4327-af26-3594037ecc96",
  "subject_name": "django/db/models/sql/compiler::PositionRef",
  "tags": [
    "entity:class"
  ],
  "text": "class PositionRef(Ref)"
}
```
