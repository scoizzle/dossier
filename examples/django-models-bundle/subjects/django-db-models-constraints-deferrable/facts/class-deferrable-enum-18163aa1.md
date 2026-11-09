# Fact 18163aa1

Store id: 5318d94b-c1df-4cf0-b762-27a6a1654172

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
- posted_at: `2026-11-09T23:31:54.2078090+00:00`

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
  "id": "5318d94b-c1df-4cf0-b762-27a6a1654172",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:54.2078090+00:00"
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
  "subject_id": "bc8e6bd9-d6be-424c-a276-c106106a203b",
  "subject_name": "django/db/models/constraints::Deferrable",
  "tags": [
    "entity:class"
  ],
  "text": "class Deferrable(Enum)"
}
```
