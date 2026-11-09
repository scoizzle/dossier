# Fact 18163aa1

Store id: e50519c5-a304-4a79-9330-885f2099729c

## Text

```text
class Deferrable(Enum)
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
- posted_at: `2026-11-09T23:44:48.7831720+00:00`

## Data

```json
{
  "end_line": 266,
  "entity_kind": "class",
  "parent": "constraints",
  "start_line": 260,
  "symbol": "Deferrable"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/constraints.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":260,"selector":"L260-L266","symbol":"Deferrable"}`

## Referenced by

None.

## Subject

[django/db/models/constraints::Deferrable](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 266,
    "entity_kind": "class",
    "parent": "constraints",
    "start_line": 260,
    "symbol": "Deferrable"
  },
  "id": "e50519c5-a304-4a79-9330-885f2099729c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.7831720+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 260,
        "selector": "L260-L266",
        "symbol": "Deferrable"
      },
      "rel": "derived_from",
      "target": "django/db/models/constraints.py"
    }
  ],
  "status": "live",
  "subject_id": "b19f5efa-30a2-49f4-9c64-e1976efc6262",
  "subject_name": "django/db/models/constraints::Deferrable",
  "tags": [
    "entity:class"
  ],
  "text": "class Deferrable(Enum)"
}
```
