# Fact c4653054

Store id: 598e6f05-850b-4c66-b519-93410bd60de7

## Text

```text
def deconstruct(self)
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
- posted_at: `2026-11-09T22:39:42.9949130+00:00`

## Data

```json
{
  "end_line": 81,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 78,
  "symbol": "CompositePrimaryKey.deconstruct"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":78,"selector":"L78-L81","symbol":"CompositePrimaryKey.deconstruct"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.deconstruct](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 81,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 78,
    "symbol": "CompositePrimaryKey.deconstruct"
  },
  "id": "598e6f05-850b-4c66-b519-93410bd60de7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.9949130+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 78,
        "selector": "L78-L81",
        "symbol": "CompositePrimaryKey.deconstruct"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "9fa0dcfe-68bc-4727-acd0-2b2c8d548432",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.deconstruct",
  "tags": [
    "entity:method"
  ],
  "text": "def deconstruct(self)"
}
```
