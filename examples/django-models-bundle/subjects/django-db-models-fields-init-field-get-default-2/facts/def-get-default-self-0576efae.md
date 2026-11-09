# Fact 0576efae

Store id: 7957028d-98d7-4896-a82f-fed80d483729

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
- posted_at: `2026-11-09T23:31:56.5245910+00:00`

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
  "id": "7957028d-98d7-4896-a82f-fed80d483729",
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
    "posted_at": "2026-11-09T23:31:56.5245910+00:00"
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
  "subject_id": "75f38379-f14d-4c84-8abf-e122d7761d7b",
  "subject_name": "django/db/models/fields/__init__::Field.get_default",
  "tags": [
    "entity:method"
  ],
  "text": "def get_default(self)"
}
```
