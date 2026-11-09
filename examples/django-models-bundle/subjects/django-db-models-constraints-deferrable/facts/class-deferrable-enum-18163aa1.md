# Fact 18163aa1

Store id: f6559e56-4cf0-4dfb-9eee-aedf08952847

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
- posted_at: `2026-11-09T22:39:40.7190220+00:00`

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
  "id": "f6559e56-4cf0-4dfb-9eee-aedf08952847",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.7190220+00:00"
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
  "subject_id": "073d3e6e-f98f-4894-9f3c-c3a9c7838561",
  "subject_name": "django/db/models/constraints::Deferrable",
  "tags": [
    "entity:class"
  ],
  "text": "class Deferrable(Enum)"
}
```
