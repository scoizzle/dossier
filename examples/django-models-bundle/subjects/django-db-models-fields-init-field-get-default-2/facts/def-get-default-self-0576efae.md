# Fact 0576efae

Store id: 231aeee5-8055-447d-9122-9b542c2a779b

## Text

```text
def get_default(self)
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
- posted_at: `2026-11-09T22:39:42.3490680+00:00`

## Data

```json
{
  "end_line": 1063,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 1061,
  "symbol": "Field.get_default"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1061,"selector":"L1061-L1063","symbol":"Field.get_default"}`

## Items

```json
[
  {
    "text": "Return the default value for this field.",
    "locator": {
      "line": 1062
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field.get_default](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1063,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 1061,
    "symbol": "Field.get_default"
  },
  "id": "231aeee5-8055-447d-9122-9b542c2a779b",
  "items": [
    {
      "locator": {
        "line": 1062
      },
      "text": "Return the default value for this field."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.3490680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1061,
        "selector": "L1061-L1063",
        "symbol": "Field.get_default"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "a8dc60fe-e7f3-41cf-a7f4-77f7da0d7d23",
  "subject_name": "django/db/models/fields/__init__::Field.get_default",
  "tags": [
    "entity:method"
  ],
  "text": "def get_default(self)"
}
```
