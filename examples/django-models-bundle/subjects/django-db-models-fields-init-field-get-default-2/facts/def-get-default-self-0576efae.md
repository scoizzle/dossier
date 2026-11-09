# Fact 0576efae

Store id: 0e0f08c4-0ef8-439c-aa72-c3c3885e9b76

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
- posted_at: `2026-11-09T23:44:50.0411900+00:00`

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
  "id": "0e0f08c4-0ef8-439c-aa72-c3c3885e9b76",
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
    "posted_at": "2026-11-09T23:44:50.0411900+00:00"
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
  "subject_id": "825782da-106b-46b3-96db-b280c3f9cd57",
  "subject_name": "django/db/models/fields/__init__::Field.get_default",
  "tags": [
    "entity:method"
  ],
  "text": "def get_default(self)"
}
```
