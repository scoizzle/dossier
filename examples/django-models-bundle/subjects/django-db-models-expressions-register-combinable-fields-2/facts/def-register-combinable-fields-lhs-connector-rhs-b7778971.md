# Fact b7778971

Store id: aa933d59-881c-4aae-8bb4-26c760ba9794

## Text

```text
def register_combinable_fields(lhs, connector, rhs, result)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.5408600+00:00`

## Data

```json
{
  "end_line": 705,
  "entity_kind": "function",
  "parent": "expressions",
  "start_line": 696,
  "symbol": "register_combinable_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":696,"selector":"L696-L705","symbol":"register_combinable_fields"}`

## Items

```json
[
  {
    "text": "Register combinable types: lhs <connector> rhs -> result e.g. register_combinable_fields( IntegerField, Combinable.ADD, FloatField, FloatField )",
    "locator": {
      "line": 697
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/expressions::register_combinable_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 705,
    "entity_kind": "function",
    "parent": "expressions",
    "start_line": 696,
    "symbol": "register_combinable_fields"
  },
  "id": "aa933d59-881c-4aae-8bb4-26c760ba9794",
  "items": [
    {
      "locator": {
        "line": 697
      },
      "text": "Register combinable types: lhs <connector> rhs -> result e.g. register_combinable_fields( IntegerField, Combinable.ADD, FloatField, FloatField )"
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5408600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 696,
        "selector": "L696-L705",
        "symbol": "register_combinable_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "9c5a6c58-ce5c-477c-bc43-22032694fa5e",
  "subject_name": "django/db/models/expressions::register_combinable_fields",
  "tags": [
    "entity:function"
  ],
  "text": "def register_combinable_fields(lhs, connector, rhs, result)"
}
```
