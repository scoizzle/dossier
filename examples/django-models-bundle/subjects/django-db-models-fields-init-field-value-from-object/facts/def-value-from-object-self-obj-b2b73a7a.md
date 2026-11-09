# Fact b2b73a7a

Store id: 494d74a2-489a-42fb-9139-c52e24d75a79

## Text

```text
def value_from_object(self, obj)
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
- posted_at: `2026-11-09T23:44:50.0499400+00:00`

## Data

```json
{
  "end_line": 1193,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1191,
  "symbol": "Field.value_from_object"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1191,"selector":"L1191-L1193","symbol":"Field.value_from_object"}`

## Items

```json
[
  {
    "text": "Return the value of this field in the given model instance.",
    "locator": {
      "line": 1192
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.value_from_object](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1193,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1191,
    "symbol": "Field.value_from_object"
  },
  "id": "494d74a2-489a-42fb-9139-c52e24d75a79",
  "items": [
    {
      "locator": {
        "line": 1192
      },
      "text": "Return the value of this field in the given model instance."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.0499400+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1191,
        "selector": "L1191-L1193",
        "symbol": "Field.value_from_object"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "bafb5142-5ce3-4385-beba-75b2d2685e4a",
  "subject_name": "django/db/models/fields/__init__::Field.value_from_object",
  "tags": [
    "entity:method"
  ],
  "text": "def value_from_object(self, obj)"
}
```
