# Fact b2b73a7a

Store id: d5dd2e81-abae-450d-a1ea-a30e2ca28ffa

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
- posted_at: `2026-11-09T22:39:42.3621070+00:00`

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
  "id": "d5dd2e81-abae-450d-a1ea-a30e2ca28ffa",
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
    "posted_at": "2026-11-09T22:39:42.3621070+00:00"
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
  "subject_id": "63fe75fb-1ffd-486b-babe-a74f36203f4e",
  "subject_name": "django/db/models/fields/__init__::Field.value_from_object",
  "tags": [
    "entity:method"
  ],
  "text": "def value_from_object(self, obj)"
}
```
