# Fact a7779551

Store id: 6eea3f86-3d84-43ee-8dff-229a8a514c40

## Text

```text
def value_to_string(self, obj)
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
- posted_at: `2026-11-09T22:39:42.3564600+00:00`

## Data

```json
{
  "end_line": 1132,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1127,
  "symbol": "Field.value_to_string"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1127,"selector":"L1127-L1132","symbol":"Field.value_to_string"}`

## Items

```json
[
  {
    "text": "Return a string value of this field from the passed obj. This is used by the serialization framework.",
    "locator": {
      "line": 1128
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.value_to_string](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1132,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1127,
    "symbol": "Field.value_to_string"
  },
  "id": "6eea3f86-3d84-43ee-8dff-229a8a514c40",
  "items": [
    {
      "locator": {
        "line": 1128
      },
      "text": "Return a string value of this field from the passed obj. This is used by the serialization framework."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3564600+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1127,
        "selector": "L1127-L1132",
        "symbol": "Field.value_to_string"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "be2108d1-9969-47a0-9dff-c5c99741f868",
  "subject_name": "django/db/models/fields/__init__::Field.value_to_string",
  "tags": [
    "entity:method"
  ],
  "text": "def value_to_string(self, obj)"
}
```
